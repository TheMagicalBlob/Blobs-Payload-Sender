using Blobs_Payload_Sender.Properties;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace PayloadSender
{
    internal partial class Payload_Sender : Form
    {
        internal const string version = "2.25.19"
        ;

        public Payload_Sender()
        {
            //##-> Initialize form and form references
            Venat = this;
            Settings = new Settings();

            InitializeComponent();
            InitializeAdditionalEventHandlers(Venat);

            // Populate build label
            BuildLabel.Text += version;


            //##-> Shrink the form to hide the theme editor controls
            ThemeHeightAdjustment = Height - (PayloadPathBox.Location.Y + PayloadPathBox.Height + 6); // Save the amount adjusted for later toggling of the editor's visibility

            Venat.Height -= ThemeHeightAdjustment;


            //##-> Initialize thread used to send payloads
            CTSendPayload = new Thread(Connect);




#if !DEBUG
            try {
#endif

            //##-> Handle Saved Settings
            LoadSavedSettings();


            if (Settings.IsFirstBoot)
            {
                MessageBox.Show("READ ME\n\n- Right-Click The \"Saved\" Button To Choose A New Payload To Save.\n- Clicking The \"Port\" Label Switches The Port Between 9090/9020/9021", "First-Time Message - This Won't Show Again After This");
                
                Settings.IsFirstBoot = false;
                Settings.Save();
            }
#if !DEBUG
            }
            catch (Exception fuck)
            {
                MessageBox.Show(fuck.Message, "An error occured when loading the settings. See exception message below");
            }
#endif
        }







        //========================================\\
        //--|   Global Variable Declarations   |--\\
        //========================================\\
        #region [Global Variable Declarations]

        public static string PayloadPath = "(Payload Path Here)        ";

        private static Payload_Sender Venat;

        private static Settings Settings;

        private readonly Thread CTSendPayload;

        private bool ReadyToConnect;

        /// <summary>
        /// Default Size 1.4.6
        /// ClientSize = new Size(215, 99); 
        /// Box.Size = new Size(215, 82);
        /// </summary>
        private bool ThemePanelOpen;

        public static bool MouseIsDown, MouseScrolled;
        public static Point LastPos, MouseDif;
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
            Console.WriteLine($"New RGB Colour: 0x{colour.ToString("X").PadLeft(6, '0')}");

            ThemeBox.Value = colour;

            var c = Color.FromArgb(0xFF, ThemeBox.Red, ThemeBox.Green, ThemeBox.Blue);

            foreach (var control in Controls.Cast<Control>().Where(control => control.GetType() != typeof(Label)))
            {
                control.ForeColor = c;
            }

            Settings.SAVED_THEME = colour;
            Settings.Save();
        }






        /// <summary>
        /// //!
        /// </summary>
        private void LoadSavedSettings()
        {
            IPBox.Text = Settings.SAVED_IP;

            PortBox.Text = Convert.ToString(Settings.SAVED_PORT);

            PayloadPathBox.Text = Settings.SAVED_PATH;
            PayloadPathBox.SelectionStart = PayloadPathBox.Text.Length;
            PayloadPathBox.ScrollToCaret();

            PayloadPath = Settings.SAVED_PATH;



            // Apply saved theme forecolour
            ThemeBox.Value = Settings.SAVED_THEME;

            ChangeControlColours(ThemeBox.Value);
        }









        private void BrowseButton_Click(object sender, EventArgs e)
        {
            var fileDialogue = new OpenFileDialog
            {
                Filter = "Payload/Executable|*.bin;*.elf",
                Title = "Select a .bin or /elf Payload to send."
            };

            if (fileDialogue.ShowDialog() == DialogResult.OK)
            {
                Settings.SAVED_PATH = PayloadPathBox.Text = fileDialogue.FileName;
            }
        }




        private void Connect()
        {
            while (true)
            {
                while (!ReadyToConnect);

                try {
                    ReadyToConnect = false;

                    var payloadSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                    payloadSocket.Connect
                    (
                        new IPEndPoint(IPAddress.Parse(IPBox.Text),
                        Convert.ToInt32(PortBox.Text))
                    );

                    payloadSocket.SendFile(PayloadPath.Replace("\"", string.Empty));
                    payloadSocket.Close();


                    if (MessageBox.Show("Payload: " + PayloadPath, "Injected Without Issue :) - Press Ok To Continue | Cancel To Exit", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    {
                        exit();
                    }
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Please provide a valid payload path. (file does not exist)", $"Path \"{PayloadPath}\" was not valid.");
                }
                catch (Exception fuck)
                {
                    MessageBox.Show(fuck.Message, $"Unexpected error occurred in {nameof(Payload_Sender)}.{nameof(Connect)}().");
                }
            }
        }




        private void SendButton_Click(object sender, EventArgs e)
        {
            if (ReadyToConnect)
            {
                return;
            }

            if (CTSendPayload.ThreadState == System.Threading.ThreadState.Unstarted)
            {
                CTSendPayload.Start();
            }
            else {
                ReadyToConnect = true;
            }
        }




        private void PayloadPathBox_TextChanged(object sender, EventArgs e)
        {
            var payloadPathBox = sender as TextBox;

            Settings.SAVED_PATH = payloadPathBox.Text;
            PayloadPath = payloadPathBox.Text;

            payloadPathBox.SelectionStart = payloadPathBox.Text.Length;
            payloadPathBox.ScrollToCaret();
        }




        private void CloseBtn_Click(object sender, EventArgs e) { Settings.Save(); Close(); }


        private void PortBox_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(PortBox.Text, out var ip))
            {
                Settings.SAVED_PORT = ip;
            }
        }


        private void IPBox_TextChanged(object sender, EventArgs e) { Settings.SAVED_IP = IPBox.Text; }


        private void MinimizeBtn_Click(object sender, EventArgs e)  { WindowState = FormWindowState.Minimized; Settings.Save(); }


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


            ExitBtn.Click += new EventHandler((sender, e) =>
            {
                Settings.Save();
                Environment.Exit(0);
            });
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




        private void ResetBtn_Click(object sender, EventArgs e)
        {
            ChangeControlColours(ThemeBox.Value = 0xFF00FF);
        }




        private void RebootBtn_Click(object sender, EventArgs e)
        {
            Settings?.Save();
            Close();
        }

        private void ThemeBoxApplyBtn_Click(object sender, EventArgs e)
        {
            if (ThemeBox.Text.Length < 2)
            {
                Console.WriteLine($"ThemeBox text too short; re-assigning");
                ThemeBox.Text = "0x" + ThemeBox.Value.ToString("X").PadLeft(6, '0');
                return;
            }
            else if (!ThemeBox.Text.StartsWith("0x"))
            {
                ThemeBox.Text = "0x" + ThemeBox.Text;
            }




            if (ThemeBox.Text.Length > 2)
            {
                if (int.TryParse(ThemeBox.Text.Substring(2), System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.CurrentCulture, out int @int))
                {
                    ThemeBox.Value = @int;
                }
                else {
                    MessageBox.Show("Unable to parse new RGB hash; Please provide a 3-byte hexadecimal value (eg: 0xFE16A0)");
                    ResetBtn_Click(null, null);
                }
            }

            ChangeControlColours(ThemeBox.Value);
        }


        private void ArrowBoxesApplyBtn_Click(object sender, EventArgs e)
        {
            ThemeBox.Red   = (byte) numericUpDown1.Value;
            ThemeBox.Green = (byte) numericUpDown2.Value;
            ThemeBox.Blue = (byte) numericUpDown3.Value;

            ThemeBox.Text = "0x" + ThemeBox.Value.ToString("X").PadLeft(6, '0');

            ChangeControlColours(ThemeBox.Value);
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
        public static void echo(object message = null)
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
        public static void _echo(object message = null)
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
            echo($"Application exiting with code {exitCode} / 0x{exitCode:X}");

            _echo("Saving settings... ");
            if (Settings != null)
            {
                Settings.Save();
                echo("Settings Saved.");
            }
            else {
                echo($"{nameof(Payload_Sender)}.{nameof(Settings)} was null for some reason, nothing to save.");
            }


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
                        return; // Ignore default value
                    }

                    if (value == 0)
                    {
                        throw new InvalidDataException();
                    }


                    _value = value;


                    if (((int) Red + Green + Blue) < 25)
                        {
                        var result = MessageBox.Show("Theme may be too dark, reset theme?", Red + Green + Blue.ToString("X"), MessageBoxButtons.YesNoCancel);

                        if (result == DialogResult.Yes)
                        {
                            Venat.ResetBtn_Click(null, null);
                        }

                        if (result != DialogResult.No)
                        {
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
                get => (byte) (_value / 0x10000);

                set => _value = (value * 0x10000) + (Green * 0x100) + (Blue * 1);
            }


            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
            public byte Green
            {
                get => (byte) (_value / 0x100);

                set => _value = (Red * 0x10000) + (value * 0x100) + (Blue * 1);
            }


            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
            public byte Blue
            {
                get => (byte) (_value / 1);

                set => _value = (Red * 0x10000) + (Green * 0x100) + (value * 1);
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