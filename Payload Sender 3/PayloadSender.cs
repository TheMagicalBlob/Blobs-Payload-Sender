using Blobs_Payload_Sender.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.Remoting.Messaging;

#if DEBUG
using System.Diagnostics;
#endif

namespace PayloadSender
{
    internal partial class Payload_Sender : Form // 71, 117
    {
        internal const string version = "2.65.84"
        ;

        public Payload_Sender()
        {
            //##-> Initialize form and form references
            Venat = this;
            Settings = new Settings();
            HoveredControl = null;

            InitializeComponent();
            InitializeAdditionalEventHandlers(Venat);

            // Populate build label
            BuildLabel.Text += version;




            //##-> Shrink the form to hide the theme editor controls
            ThemeHeightAdjustment = Height - (PayloadPathBox.Location.Y + PayloadPathBox.Height + 6); // Save the amount adjusted for later toggling of the editor's visibility

            Venat.Height -= ThemeHeightAdjustment;




            //##-> Initialize thread used to send payloads
            PayloadThread = new Thread(Connect);
            LocalServerThread = new Thread(LocalServer);

            getIPBoxValue = (_) => IPBox.Text;
            getPortBoxValue = (_) => PortBox.Text;
            getElfdrPortBoxValue = (_) => ElfdrPortBox.Text;

            getPathBoxValue = (_) => PayloadPathBox.Text;

            editStatusLabel = (msg) => tempStatusLabel.Text = msg?.ToString() ?? "null";




            //##-> Miscellaneous other form setup crap
#if !DEBUG
            // Hide debug controls
            toggleDebugServerBtn.Visible = false;
            scaleBtn.Visible = false;
#endif
            // Load & apply saved control states/values
            LoadSavedSettings();
        }







        //========================================\\
        //--|   Global Variable Declarations   |--\\
        //========================================\\
        #region [Global Variable Declarations]

        public static string PayloadPath;
        


        private static Payload_Sender Venat;

        private static Settings Settings;

        private readonly Thread PayloadThread;
        private readonly Thread LocalServerThread;

        private TcpClient PayloadSocket;

        private delegate object CTControlProbe(object obj = null);

        private CTControlProbe getIPBoxValue, getElfdrPortBoxValue, getPortBoxValue, editStatusLabel, getPathBoxValue;

        private bool ReadyToConnect;

        /// <summary>
        /// Default Size 1.4.6
        /// ClientSize = new Size(215, 99); 
        /// Box.Size = new Size(215, 82);
        /// </summary>
        private bool ThemePanelOpen;

        public static bool MouseIsDown;
        public static Point MouseDif;
        #endregion
















        //=================================\\
        //--|   Function Declarations   |--\\
        //=================================\\
        #region [Function Declarations]

        /// <summary>
        /// //!
        /// </summary>
        /// <param name="colour"></param>
        private void ChangeControlColours(int colour)
        {
            ThemeBox.Value = colour;

            var c = Color.FromArgb(alpha:0xFF, ThemeBox.Red, ThemeBox.Green, ThemeBox.Blue);

            foreach (var control in Controls.Cast<Control>().Where(control => control.GetType() != typeof(Label)))
            {
                control.ForeColor = c;
            }

            Settings.Theme = colour;
            Settings.Save();
        }






        /// <summary>
        /// //!
        /// </summary>
        private void LoadSavedSettings()
        {
#if !DEBUG
            try {
#endif
                // Load control states
                IPBox.Text = Settings.IPAddress;

                PortBox.Text = Convert.ToString(Settings.Port);

                PayloadPathBox.Text = Settings.PayloadPath;
                PayloadPathBox.SelectionStart = PayloadPathBox.Text.Length;
                PayloadPathBox.ScrollToCaret();

                PayloadPath = Settings.PayloadPath.Replace("\"", string.Empty);


                // Apply saved theme forecolour
                ThemeBox.Value = Settings.Theme;

                ChangeControlColours(ThemeBox.Value);


                // Set platform the buttons' states
                TogglePlatformButtonsSelectionHighlight(false);
                ToggleBinOrElfButtonsSelectionHighlight(false);

                TogglePlatformButtonsVisibility();
#if !DEBUG
            }
            catch (Exception fuck)
            {
                MessageBox.Show(fuck.Message, "An error occurred when loading the settings. See exception message below");
            }
#endif
        }






        /// <summary>
        /// //!
        /// </summary>
        private void Connect()
        {
            int sent;
            byte[] payload;
            var error = string.Empty;
            PayloadSocket = null;

            while (true)
            {
                while (!ReadyToConnect)
                {
                    Thread.Sleep(7); // Wait for first/subsequent file
                }




                try {
                    // Verify provided file path
                    if (!File.Exists(PayloadPath))
                    {
                        throw new FileNotFoundException();
                    }


                    // Send the sekected elfdr payload and sleep for ~3 seconds before sending the main provided payload
                    if (sendElfdrCheckBox.Checked)
                    {
                        PayloadSocket = new TcpClient();
                        PayloadSocket.Connect(new IPEndPoint(IPAddress.Parse(getIPBoxValue().ToString()), Convert.ToInt32(getElfdrPortBoxValue())));

                        _echo("Loading selcted elfdr payload... ");
                        payload = GetSelectedElfdrPayload();
                        echo($"payload loaded. (Size: {payload.Length:X})");


                        _echo("Sending elfdr payload... ");
                        sent = PayloadSocket.Client.Send(payload);
                        echo($"payload sent. (sent: {sent:X})\n");


                        if (sent < 0)
                        {
                            goto QUOI;
                        }

                        if (sent < payload.Length)
                        {
                            error = "(not all data was sent)";
                            goto fack;
                        }
                        if (sent > payload.Length)
                        {
                            error = "(sent more than filesize?!)";
                            goto fack;
                        }

                        echo("loader sent without error.\n");
                        Thread.Sleep(3300);
                    }
                    sent = -1;






                    // Reset socket and send the payload provided in the PayloadPathBox
                    PayloadSocket = new TcpClient();
                    PayloadSocket.Connect(new IPEndPoint(IPAddress.Parse(getIPBoxValue().ToString()), Convert.ToInt32(getPortBoxValue())));

                    _echo("Loading selcted payload... ");
                    payload = File.ReadAllBytes(PayloadPath);
                    echo($"payload loaded. (Size: {payload.Length:X})");

                    _echo("Sending loaded payload... ");
                    sent = PayloadSocket.Client.Send(payload);
                    echo($"payload sent. (sent: {sent:X})\n");

                    if (sent < 0)
                    {
                        goto QUOI;
                    }

                    if (sent < payload.Length)
                    {
                        error = "(not all data was sent)";
                        goto fack;
                    }

                    if (sent > payload.Length)
                    {
                        error = "(sent more than filesize?!)";
                        goto fack;
                    }

                    Venat?.Invoke(editStatusLabel, "Success");
                    continue;




                fack:
                    echo($"sent the wrong amount of data; see exception message");

                    Venat?.Invoke(editStatusLabel, "TCP Error");
                    MessageBox.Show($"Error: Sent amount wasn't equal to the size of the selected file.\nSent 0x{sent:X} out of 0x{payload.Length:X}", error);



                QUOI:
                    echo("sent value remained negative!");

                    error = "QUOI?!";
                    Venat?.Invoke(editStatusLabel, "!ERROR!");
                    MessageBox.Show($"Error: Sent buffer size was negative- something has gone terribly wrong. {nameof(sent)} == {sent}", error);
                }
                catch (SocketException err)
                {
                    echo($"A SocketException was raised in {nameof(Connect)}().\nMessage:\n\t{err.Message.Replace("\n", "\n\t")}");
                    Venat?.Invoke(editStatusLabel, "Socket Error");
                    
                    MessageBox.Show($"Socket Error: Please verify the provided IP and Port, and that the payload loader is running.", err.Message);
                }
                catch (FileNotFoundException)
                {
                    echo("File doesn't exist, doing jack.");
                    Venat?.Invoke(editStatusLabel, "File Error!");
                    MessageBox.Show("Invalid payload path provided (File doesn't exist). Please update the path.\nPath: " + PayloadPath, $"Payload Path did not point to a valid file.");
                }
                finally {
                    if (PayloadSocket?.Connected ?? false)
                    {
                        PayloadSocket?.Close();
                    }
                    ReadyToConnect = false;
                }
            }
        }






        /// <summary>
        /// //!
        /// </summary>
        private void LocalServer()
        {
#if DEBUG
            var listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 23);

            while (true)
            {
                listener.Start();
                _echo($"Listenter started, waiting for socket... ");

                var socket = listener.AcceptSocket();
                echo($"Accepted socket.");

                listener.Stop();




                echo("Waiting for file.");
                while (socket.Available < 1)
                {
                    Thread.Sleep(2);
                }


                echo($"Receiving File... ");
                var dataStream = new MemoryStream();
                int num;
                byte[] buff;

                do {
                    num = socket.Receive(buff = new byte[socket.Available]);

                    dataStream.Write(buff, 0, num);
                    
                    echo($"- Recieved {num:X} bytes. ({(File.ReadAllBytes(PayloadPath).Length - dataStream.Position) + num:X}) - ({num:X})");
                }
                while (socket.Available > 0);



                var newFile = Directory.GetCurrentDirectory() + '\\' + PayloadPath.Substring(PayloadPath.LastIndexOf('\\') + 1);
                
                echo($"File read, saving @{newFile}");
                File.WriteAllBytes(newFile, dataStream.ToArray());
            }
#endif
        }






        /// <summary>
        /// //!
        /// </summary>
        /// <returns></returns>
        private byte[] GetSelectedElfdrPayload()
        {
            if (Settings.Prospero)
            {
                return Resources.elfldr_ps5_0_22_2;
            }
            else
            {
                if (Settings.ElfOverBin)
                {
                    return Resources.elfldr_ps4_0_6_elf;
                }
                else
                {
                    return Resources.elfldr_ps4_0_6_bin;
                }
            }

        }
















        //======================================================\\
        //---|   Form Functionality Function Declarations   |---\\
        //======================================================\\
        #region [Form Functionality Function Delcarations]

        /// <summary>
        /// Post-InitializeComponent Configuration. <br/><br/>
        /// Create Assign Anonymous Event Handlers to Parent and Children.
        /// </summary>
        public void InitializeAdditionalEventHandlers(Payload_Sender Venat)
        {
            var controls = Venat.Controls.Cast<Control>().ToArray();


            // Setup variables used for decorations like the SeparatorLines and border
            InitializeFormDecorations(Venat, controls);


            // Set appropriate event handlers for the controls on the form as well
            foreach (var item in controls)
            {
                item.MouseDown += new MouseEventHandler(MouseDownFunc);
                item.MouseUp += new MouseEventHandler(MouseUpFunc);


                // Avoid applying MouseMove and KeyDown event handlers to text containers (to retain the ability to drag-select text)
                if (!new[] { typeof(RichTextBox), typeof(TextBox), typeof(RGBBox) }.Any(type => item.GetType() == type))
                {
                    // Add the event handler to everything that's not a text container
                    item.MouseMove += new MouseEventHandler((sender, e) => MoveForm());
                }
            }




            // TODO:
            // - Add an updated mouse enter/leave highlight function

            MinimizeBtn.Click += new EventHandler((sender, e) => Venat.WindowState = FormWindowState.Minimized);
            //MinimizeBtn.MouseEnter += new EventHandler((sender, e) => ((Control)sender).ForeColor = Color.FromArgb(90, 100, 255));
            //MinimizeBtn.MouseLeave += new EventHandler((sender, e) => ((Control)sender).ForeColor = Color.FromArgb(0, 0, 0));


            ExitBtn.Click += new EventHandler((sender, e) => exit());
            //ExitBtn.MouseEnter += new EventHandler((sender, e) => ((Control)sender).ForeColor = Color.FromArgb(230, 100, 100));
            //ExitBtn.MouseLeave += new EventHandler((sender, e) => ((Control)sender).ForeColor = Color.FromArgb(0, 0, 0));




            // Set Event Handlers for Form Dragging
            MouseDown += new MouseEventHandler(MouseDownFunc);

            MouseUp += new MouseEventHandler(MouseUpFunc);

            MouseMove += new MouseEventHandler((sender, e) => MoveForm());
        }




        /// <summary>
        /// Handle Form Dragging for Borderless Form.
        /// </summary>
        public static void MoveForm()
        {
            if (MouseIsDown && Venat != null)
            {
                Venat.Location = new Point(MousePosition.X - MouseDif.X, MousePosition.Y - MouseDif.Y);
                Venat.Update();
            }
        }


        /// <summary>
        /// //!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void MouseUpFunc(object sender = null, EventArgs e = null)
        {
            MouseIsDown = false;
        }


        /// <summary>
        /// //!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void MouseDownFunc(object sender = null, EventArgs e = null)
        {
            if (Venat != null)
            {
                MouseDif = new Point(MousePosition.X - Venat.Location.X, MousePosition.Y - Venat.Location.Y);
                MouseIsDown = true;
            }
        }






        /// <summary>
        /// //!
        /// </summary>
        /// <param name="toggle"></param>
        private void TogglePlatformButtonsSelectionHighlight(bool toggle = true)
        {
            if (toggle)
            {
                Settings.Prospero ^= true;
            }

            if (Settings.Prospero)
            {
                PS5Btn.ForeColor = Color.FromArgb(Settings.Theme);

                PS4Btn.ForeColor = Color.Gray;
            }
            else {
                PS5Btn.ForeColor = Color.Gray;

                PS4Btn.ForeColor = Color.FromArgb(Settings.Theme);
            }


            SetBinOrElfButtonsVisibility(!Settings.Prospero);
        }


        /// <summary>
        /// //!
        /// </summary>
        /// <param name="toggle"></param>
        private void ToggleBinOrElfButtonsSelectionHighlight(bool toggle = true)
        {
            if (toggle)
            {
                Settings.ElfOverBin ^= true;
            }

            if (Settings.ElfOverBin)
            {
                elfElfdrBtn.ForeColor = Color.FromArgb(Settings.Theme);

                binElfdrBtn.ForeColor = Color.Gray;
            }
            else {
                elfElfdrBtn.ForeColor = Color.Gray;

                binElfdrBtn.ForeColor = Color.FromArgb(Settings.Theme);
            }
        }




        /// <summary>
        /// //!
        /// </summary>
        private void TogglePlatformButtonsVisibility()
        {
            var checkedState = sendElfdrCheckBox.Checked;
            var state = !Settings.Prospero && checkedState;

            PS4Btn.Visible = checkedState;
            PS5Btn.Visible = checkedState;

            Settings.SendElfdr = state;

            SetBinOrElfButtonsVisibility(state);
            ToggleElfdrPortBoxVisibility();
        }


        /// <summary>
        /// //!
        /// </summary>
        /// <param name="state"></param>
        private void SetBinOrElfButtonsVisibility(bool state)
        {
            elfElfdrBtn.Visible = state;
            binElfdrBtn.Visible = state;
            arrowLabel.Visible = state;
        }


        /// <summary>
        /// //!
        /// </summary>
        private void ToggleElfdrPortBoxVisibility()
        {
            var checkedState = sendElfdrCheckBox.Checked;
            var state = !Settings.Prospero && checkedState;


            ElfdrPortBox.Visible = checkedState;
            elfdrPortBoxLabel.Visible = state;
            
            portBoxLabel.Visible = state;


            // Move the controls over to fit the new box or fill the gap
            if (checkedState)
            {
                IPBox.Location = new Point(IPBox.Location.X + PortBox.Width / 2, IPBox.Location.Y);
                PortBox.Location = new Point(PortBox.Location.X + (PortBox.Width + 2), PortBox.Location.Y);
            }
            else {
                IPBox.Location = new Point(IPBox.Location.X - PortBox.Width / 2, IPBox.Location.Y);
                PortBox.Location = new Point(PortBox.Location.X - (PortBox.Width + 2), PortBox.Location.Y);
            }
        }
        #endregion












        //========================================\\
        //---|   Event Handler Declarations   |---\\
        //========================================\\
        #region [Event Handler Declarations]

        private void PayloadPathBrowseBtn_Click(object sender, EventArgs e)
        {
            var fileDialogue = new OpenFileDialog
            {
                Filter = "Payload/Executable|*.bin;*.elf",
                Title = "Select a .bin or /elf Payload to send."
            };

            if (fileDialogue.ShowDialog() == DialogResult.OK)
            {
                Settings.PayloadPath = PayloadPathBox.Text = fileDialogue.FileName;
            }
        }




        private void SendButton_Click(object sender, EventArgs e)
        {
            if (ReadyToConnect)
            {
                echo("Already/still sending payload");
                return;
            }


            if (PayloadThread.ThreadState == System.Threading.ThreadState.Unstarted)
            {
                PayloadThread.Start();
            }

            ReadyToConnect = true;
            echo("Ready to Connect");
        }




        private void PS5Btn_Click(object sender, EventArgs e)
        {
            if (Settings.Prospero)
            {
                return;
            }

            TogglePlatformButtonsSelectionHighlight();
        }




        private void PS4Btn_Click(object sender, EventArgs e)
        {
            if (Settings.Prospero)
            {
                TogglePlatformButtonsSelectionHighlight();
            }
        }




        private void binElfdrBtn_Click(object sender, EventArgs e)
        {
            ToggleBinOrElfButtonsSelectionHighlight();
        }




        private void elfElfdrBtn_Click(object sender, EventArgs e)
        {
            ToggleBinOrElfButtonsSelectionHighlight();
        }




        private void RebootBtn_Click(object sender, EventArgs e)
        {
#if DEBUG
            PayloadSocket?.Close();
            Settings?.Save();
            Close();
#endif
        }




        private void ResetSettingsBtn_Click(object sender, EventArgs e)
        {
#if DEBUG
            Settings?.Reset();
            Settings?.Save();
#endif
        }




        private void ResetBtn_Click(object sender, EventArgs e)
        {
            ChangeControlColours(0xF21264);
        }




        private void PayloadPathBox_TextChanged(object sender, EventArgs e)
        {
            var payloadPathBox = sender as TextBox;
            var path = payloadPathBox.Text.Replace("\"", string.Empty);
            Settings.PayloadPath = Settings.PayloadPath.Replace("\"", string.Empty);


            // Avoid saving invalid paths, unless there's no valid one saved anyway
            //if ((File.Exists(path) || (Settings.PayloadPath?.Any() ?? false)) && !File.Exists(Settings.PayloadPath))
            {
                Settings.PayloadPath = path;
            }

            PayloadPath = path;


            // Move the caret to the right of the text box, to show the file name consistently.
            payloadPathBox.SelectionStart = path.Length;
            payloadPathBox.ScrollToCaret();
        }




        private void PortBox_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(PortBox.Text, out var port))
            {
                Settings.Port = port;
            }
        }




        private void IPBox_TextChanged(object sender, EventArgs e) { Settings.IPAddress = IPBox.Text; }




        private void MinimizeBtn_Click(object sender, EventArgs e) { WindowState = FormWindowState.Minimized; Settings.Save(); }




        private void ThemeBtn_Click(object sender, EventArgs e)
        {
            if (!ThemePanelOpen)
            {
                ClientSize = new Size(Width, Height + ThemeHeightAdjustment);
            }
            else {
                ClientSize = new Size(Width, Height - ThemeHeightAdjustment);
            }

            ThemePanelOpen ^= true;

            Refresh();
        }




        private void ThemeBoxApplyBtn_Click(object sender, EventArgs e)
        {
            NumberStyles style;
            var text = ThemeBox.Text.ToLower();

            // Determine the format of the provided hash
            if (text.StartsWith("0x") || text[0] == 'x')
            {
                style = NumberStyles.HexNumber;
                text = text.Replace("0x", string.Empty).Replace("x", string.Empty); // Fix the text box for hex parsing
            }
            else {
                style = NumberStyles.Integer;
            }


            // Parse the theme box text for the new colour hash
            if (int.TryParse(text, style, CultureInfo.CurrentCulture, out int @int))
            {
                ThemeBox.Value = @int;
            }
            else {
                MessageBox.Show("Unable to parse new RGB hash; Please provide either a 3-byte hexadecimal value (eg: 0xFE16A0), or an regular integer", "Three hexadecimal-formatted bytes or decimal integer expected.");
                ResetBtn_Click(null, null);
            }


            // Apply the new colour hash
            ChangeControlColours(ThemeBox.Value);
        }




        private void ArrowBoxesApplyBtn_Click(object sender, EventArgs e)
        {
            ThemeBox.Red = (byte)numericUpDown1.Value;
            ThemeBox.Green = (byte)numericUpDown2.Value;
            ThemeBox.Blue = (byte)numericUpDown3.Value;

            ThemeBox.Text = "0x" + ThemeBox.Value.ToString("X").PadLeft(6, '0');

            ChangeControlColours(ThemeBox.Value);
        }




        private void sendElfdrCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            TogglePlatformButtonsVisibility();
        }




        private void ElfdrPortBox_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(ElfdrPortBox.Text, out var port))
            {
                Settings.ElfdrPort = port;
            }
        }




        private void toggleDebugServerBtn_Click(object sender, EventArgs e)
        {
#if DEBUG
            if (LocalServerThread?.ThreadState == System.Threading.ThreadState.Unstarted)
            {
                LocalServerThread.Start();
            }
            else {
                echo("Server's already running. F*ck you- restart the app.");
            }
#endif
        }




        private void scaleBtn_Click(object sender, EventArgs e)
        {
#if DEBUG
            this.Scale(new SizeF(1.01f, 1.01f));
#endif
        }
#endregion












        //=======================================================\\
        //---|   Logging/Output Functionality Declarations   |---\\
        //=======================================================\\
        #region [Logging/Output Functionality Declarations]

        /// <summary>
        /// Echo a provided string (or string representation of an object) to the standard console output, followed by a newline.
        /// <br/> Appends an empty new line if no message is provided.
        /// </summary>
#pragma warning disable IDE1006 // bug off, this one's lowercase
        public static void echo(object
#if DEBUG
            message
#else
            _
#endif
            = null)
        {
#if DEBUG
            var str = message?.ToString() ?? string.Empty;

            Console.WriteLine(str);
            Debug.WriteLineIf(!Console.IsOutputRedirected, str);

            if (!Console.IsOutputRedirected)
            {
                Debug.WriteLine(str);
            }
#endif
        }




        /// <summary>
        /// Echo a provided string (or string representation of an object) to the standard console output.
        /// <br/> Appends a single whitespace character if no message is provided.
        /// </summary>
        /// <param name="message"></param>
        public static void _echo(object
#if DEBUG
            message
#else
            _
#endif
            = null
            )
        {
#if DEBUG
            var str = message?.ToString() ?? " ";

            Console.Write(str);

            if (!Console.IsOutputRedirected)
            {
                Debug.Write(str);
            }
#endif
        }




        /// <summary>
        /// Save settings and close the form
        /// </summary>
        /// <param name="exitCode"></param>
        private static void exit(int exitCode = 0)
        {
            echo($"Application exiting with code {exitCode:X}");

            _echo("Saving settings... ");
            if (Settings != null)
            {
                Settings.Save();
                echo("Settings saved.");
            }
            else {
                echo($"{nameof(Payload_Sender)}.{nameof(Settings)} was null for some reason, nothing to save.");
            }

            if (Venat.PayloadSocket != null)
            {
                _echo("Closing socket... ");
                Venat.PayloadSocket?.Close();
                echo("Socket disconnected & closed.");
            }



            Venat.Controls.Clear();
            Venat.Dispose();

            Environment.Exit(exitCode);
        }
#pragma warning restore IDE1006
#endregion
#endregion (function declarations)















        //=====================================\\
        //---|   Custom Class Extensions   |---\\
        //=====================================\\
        #region [Custom Class Extensions]

        private class RGBBox : TextBox
        {
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
            public int Value
            {
                get => _value;

                set {
                    if (value < 0)
                    {
                        throw new InvalidDataException();
                        exit();
                    }
                    
                    _value = value;




                    //##-> Offer a reset if the theme is likely to make the form unreadable
                    int chk = Red; //#
                    chk += Green;  //## Lazily making sure it's not adding them as bytes. Just-in-case it's underflowing, since it was being weird a while ago
                    chk += Blue;   //#

                    if (chk < 25) 
                    {
                        var result = MessageBox.Show("Theme may be too dark, reset theme?", Red + Green + Blue.ToString("X"), MessageBoxButtons.YesNo);

                        if (result == DialogResult.Yes)
                        {
                            Venat.ResetBtn_Click(null, null);
                            return;
                        }
                    }


                    Venat.numericUpDown1.Value = Red;
                    Venat.numericUpDown2.Value = Green;
                    Venat.numericUpDown3.Value = Blue;

                    this.Text = "0x" + _value.ToString("X").PadLeft(6, '0');
                }
            }

            private int _value;






            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
            public byte Red
            {
                get => (byte) (_value / 0x010000);

                set => _value = (value * 0x010000) + (Green * 0x000100) + (Blue * 0x000001);
            }


            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
            public byte Green
            {
                get => (byte) (_value / 0x000100);

                set => _value = (Red * 0x010000) + (value * 0x000100) + (Blue * 0x000001);
            }


            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
            public byte Blue
            {
                get => (byte) (_value / 0x000001);

                set => _value = (Red * 0x010000) + (Green * 0x000100) + (value * 0x000001);
            }
        }






        public class Label : System.Windows.Forms.Label
        {
            public bool IsSeparatorLine { get; set; } = false;


            public bool StretchToFitForm
            {
                get => _stretchToFitForm & IsSeparatorLine;
                set => _stretchToFitForm = value;
            }
            private bool _stretchToFitForm = false;
        }
        #endregion
    }
}