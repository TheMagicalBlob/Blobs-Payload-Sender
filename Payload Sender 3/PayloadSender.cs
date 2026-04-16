using Blobs_Payload_Sender.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace PayloadSender
{
    internal partial class Payload_Sender : Form
    {
        public Payload_Sender()
        {
            Venat = this;
            Settings = new Settings();

            InitializeComponent();
            InitializeAdditionalEventHandlers(Venat);


            //##-> Shrink the form to hide the theme editor controls
            ThemeHeightAdjustment = Height - ((PayloadPathBox.Location.Y + PayloadPathBox.Height) + 4); // Save the amount adjusted for later toggling of the editor's visibility

            Venat.Height -= ThemeHeightAdjustment;


#if !DEBUG
            try {
#endif
            // Load saved settings
            IPBox.Text = Settings.SAVED_IP;
            PortBox.Text = Convert.ToString(Settings.SAVED_PORT);
            PayloadPathBox.Text = Settings.SAVED_PATH;
            BIN = Settings.SAVED_PATH;

            // Apply saved theme forecolour
            ChangeControlColours(Settings.SAVED_THEME);
            ThemeBox.Text += Settings.SAVED_THEME.ToString("X").PadLeft(6, '0');

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

        public static string BIN = "(Payload Path Here)        ";
        public static Button BTN = new Button();

        private static Payload_Sender Venat;

        private static Settings Settings;

        private static int ThemeHeightAdjustment;

        /// <summary>
        /// Default Size 1.4.6
        /// ClientSize = new Size(215, 99); 
        /// Box.Size = new Size(215, 82);
        /// </summary>
        private bool ThemePanelOpen;

        public static bool MouseIsDown, MouseScrolled;
        public static Point LastPos, MouseDif;
        #endregion








        private void ChangeControlColours(int colour)
        {
            var hexNumber = colour.ToString("X").PadLeft(6, '0');

            var red =   byte.Parse($"{hexNumber[0]}{hexNumber[1]}", System.Globalization.NumberStyles.HexNumber);
            var green = byte.Parse($"{hexNumber[2]}{hexNumber[3]}", System.Globalization.NumberStyles.HexNumber);
            var blue =  byte.Parse($"{hexNumber[4]}{hexNumber[5]}", System.Globalization.NumberStyles.HexNumber);

            Console.WriteLine($"New Argb Colour: 0xFF{red:X}{green.ToString("X").PadLeft(2, '0')}{blue:X}");


            var c = Color.FromArgb(0xFF, red, green, blue);

            foreach (var control in Controls.Cast<Control>().Where(control => control.GetType() != typeof(Label)))
            {
                control.ForeColor = c;
            }

            Settings.SAVED_THEME = colour;
        }









        private void BrowseButton_Click(object sender, EventArgs e) {
            FileDialog O = new OpenFileDialog {
                Filter = "Payload/Executable|*.bin;*.elf",
                Title = "Which File Would You Like To Send?"
            };
            if (O.ShowDialog() == DialogResult.OK) {
                PayloadPathBox.Text = O.FileName;
                Settings.SAVED_PATH = O.FileName;
            }
        }




        private void Connect()
        {
            try {
                Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                s.Connect(new IPEndPoint(IPAddress.Parse(IPBox.Text), Convert.ToInt32(PortBox.Text)));
                s.SendFile(BIN);
                s.Close();

                var b = MessageBoxButtons.OKCancel;
                DialogResult r;
                r = MessageBox.Show("Payload: " + BIN, "Injected Without Issue :) - Press Ok To Continue | Cancel To Exit", b);
                if (r == DialogResult.Cancel) {
                    Settings.Save(); Close();
                }
            }
            catch (Exception fuck) { MessageBox.Show(fuck.Message, "C1"); }
        }




        private void SendButton_Click(object sender, EventArgs e)
        {
            // Some "Obfuscation" So WD Doesn't Think It's A Virus. Aren't False-Positives Fun?
            try {
                Connect();
            } 
            catch (Exception fuck)
            {
                MessageBox.Show(fuck.Message, nameof(SendButton_Click));
            }
        }




        private void PayloadPathBox_TextChanged(object sender, EventArgs e)
        {
            Settings.SAVED_PATH = PayloadPathBox.Text;
            BIN = PayloadPathBox.Text;
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void MouseUpFunc(object sender = null, EventArgs e = null)
        {
            MouseIsDown = false;
        }




        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            ChangeControlColours(Settings.SAVED_THEME);
        }




        private void ResetBtn_Click(object sender, EventArgs e)
        {
            ChangeControlColours(Settings.SAVED_THEME = 0xFF00FF);
        }




        private void ThemeBox_TextChanged(object sender, EventArgs e)
        {
            if (ThemeBox.Text.Length < 2)
            {
                ThemeBox.Text = "0x";
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
                    Settings.SAVED_THEME = @int;
                    Settings.Save();
                }
                else {
                    Console.WriteLine("Oh for fuck sake");
                }
            }
        }


        #endregion













        //=====================================\\
        //---|   Custom Class Extensions   |---\\
        //=====================================\\
        #region [Custom Class Extensions]

        private class RGBBox : TextBox
        {
            public int Hash
            {
                get => _hash;

                set {
                    _hash = value;

                    this.Text = "0x" + _hash.ToString("X").PadLeft(6, '0');
                }
            }

            private int _hash;



            public byte Red
            {
                get => byte.Parse(_hash.ToString("X").PadLeft(6, '0').Remove(2));
            }


            public byte Green
            {
                get => byte.Parse(_hash.ToString("X").PadLeft(6, '0').Remove(4).Substring(2));
            }


            public byte Blue
            {
                get => byte.Parse(_hash.ToString("X").PadLeft(6, '0').Substring(4));
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