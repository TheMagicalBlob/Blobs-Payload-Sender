using Blobs_Payload_Sender.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Payload_Sender
{
    public partial class Payload_Sender : Form
    {
        public Payload_Sender()
        {
            InitializeComponent();
            InitializeAdditionalEventHandlers(this);
            
            Venat = this;
            var Settings = new Settings();

#if !DEBUG
            try {
#endif
            // Load saved settings
            IPBox.Text = Settings.Default.SAVED_IP;
            PortBox.Text = Convert.ToString(Settings.Default.SAVED_PORT);
            PayloadPathBox.Text = Settings.Default.SAVED_PATH;
            BIN = Settings.Default.SAVED_PATH;

            // Apply saved theme forecolour
            ChangeControlColours(Settings.SAVED_THEME);
            ThemeBox.Text += Settings.SAVED_THEME.ToString("X");

            if (Settings.Default.IsFirstBoot)
            {
                MessageBox.Show("READ ME\n\n- Right-Click The \"Saved\" Button To Choose A New Payload To Save.\n- Clicking The \"Port\" Label Switches The Port Between 9090/9020/9021", "First-Time Message - This Won't Show Again After This");
                Settings.Default.IsFirstBoot = false;
                Settings.Default.Save();
            }
#if !DEBUG
            }

            catch (Exception fuck)
            {
                MessageBox.Show(fuck.Message, "An Oh-Fuck Has Occured!");
            }
#endif
        }


        /// <summary>
        /// Default Size 1.4.6
        /// ClientSize = new Size(215, 99); 
        /// Box.Size = new Size(215, 82);
        /// </summary>
        bool ThemePanelOpen;

        public static string BIN = "(Payload Path Here)        ";
        public static Button BTN = new Button();

        private static Payload_Sender Venat;

        public static bool MouseIsDown, MouseScrolled;
        public static Point LastPos;
        public static Point MouseDif;

        private void ChangeControlColours(int colour)
        {
            var hexNumber = colour.ToString("X");

            var red = byte.Parse(hexNumber.Remove(2), System.Globalization.NumberStyles.HexNumber);
            var green = byte.Parse(hexNumber.Substring(2).Remove(2), System.Globalization.NumberStyles.HexNumber);
            var blue = byte.Parse(hexNumber.Substring(4), System.Globalization.NumberStyles.HexNumber);

            Console.WriteLine($"New Argb Colour: 0xFF{red:X}{green.ToString("X").PadLeft(2, '0')}{blue:X}");


            var c = Color.FromArgb(0xFF, red, green, blue);

            MinimizeBtn.ForeColor = c;
            ExitBtn.ForeColor = c;
            PayloadPathBox.ForeColor = c;
            IPLabel.ForeColor = c;
            PortLabel.ForeColor = c;
            BuildLabel.ForeColor = c;
            IPBox.ForeColor = c;
            PortBox.ForeColor = c;
            PayloadPathBox.ForeColor = c;
            ThemeBtn.ForeColor = c;
            BrowseButton.ForeColor = c;
            SendButton.ForeColor = c;
            Blobs_Payload_Sender.Properties.Settings.Default.SAVED_THEME = colour;
        }









        private void BrowseButton_Click(object sender, EventArgs e) {
            FileDialog O = new OpenFileDialog {
                Filter = "Payload/Executable|*.bin;*.elf",
                Title = "Which File Would You Like To Send?"
            };
            if (O.ShowDialog() == DialogResult.OK) {
                PayloadPathBox.Text = O.FileName;
                Blobs_Payload_Sender.Properties.Settings.Default.SAVED_PATH = O.FileName;
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
                    Blobs_Payload_Sender.Properties.Settings.Default.Save(); Close();
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

        private void PayloadPathBox_TextChanged(object sender, EventArgs e) { Blobs_Payload_Sender.Properties.Settings.Default.SAVED_PATH = PayloadPathBox.Text; BIN = PayloadPathBox.Text; }
        private void CloseBtn_Click(object sender, EventArgs e) { Blobs_Payload_Sender.Properties.Settings.Default.Save(); Close(); }
        private void PortBox_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(PortBox.Text, out var ip))
            {
                Blobs_Payload_Sender.Properties.Settings.Default.SAVED_PORT = ip;
            }
        }
        private void IPBox_TextChanged(object sender, EventArgs e) { Blobs_Payload_Sender.Properties.Settings.Default.SAVED_IP = IPBox.Text; }
        private void MinimizeBtn_Click(object sender, EventArgs e)  { WindowState = FormWindowState.Minimized; Blobs_Payload_Sender.Properties.Settings.Default.Save(); }

        private void ThemeBtn_Click(object sender, EventArgs e)
        {
            if (!ThemePanelOpen)
            {
                ClientSize = new Size(215, 119);
            }
            else {
                ClientSize = new Size(215, 100);
            }

            ThemeBox.Visible = ThemePanelOpen ^= true;
        }

        private void PortLabel_Click(object sender, EventArgs e) {
            if (PortBox.Text == "9021") {
                PortBox.Text = "9090";
            }
            else if (PortBox.Text == "9090") {
                PortBox.Text = "9020";
            }
            else if (PortBox.Text == "9020") {
                PortBox.Text = "9021";
            }
        }















        //==========================================================\\
        //--|   Global Look/Feel-Related Variable Declarations   |--\\
        //==========================================================\\
        #region [Global Look/Feel-Related Variable Declarations]


        public static Color AppColour = Color.FromArgb(20, 20, 20);
        public static Color AppColourLight = Color.FromArgb(42, 42, 42);
        public static Color AppColourSpecial = Color.FromArgb(125, 183, 245);
        public static Color AppAccentColour = Color.FromArgb(210, 240, 250); // Why did I choose this colour specifically? I forget.

        public static Pen FormDecorationPen = new Pen(AppAccentColour); // Colouring for Border Drawing

        public static Font MainFont = new Font("Gadugi", 8.25f, FontStyle.Bold); // For the vast majority of controls; anything the user doesn't edit, really.
        public static Font TextFont = new Font("Segoe UI Semibold", 7.5f); // For option controls with customized contents


        /// <summary> An array of Point() arrays with the start and end points of a line to draw. </summary>
        private Point[][] HSeparatorLines;

        /// <summary> An array of Point() arrays with the start and end points of a line to draw. </summary>
        private Point[][] VSeparatorLines;
        #endregion










        //===============================================\\
        //--|   UI Decoration Function Declarations   |--\\
        //===============================================\\
        #region [UI Decoration Function Declarations]

        /// <summary>
        /// Draw a thin border over the for edges on repaint.
        /// <br/>Draw a thin line from one end of the painted control to the other.
        ///</summary>
        public static void DrawFormDecorations(Form venat, PaintEventArgs yoshiP)
        {
            if (Venat == null || yoshiP == null)
            {
                return;
            }

            // Clear line bounds with the current form's background colour
            yoshiP.Graphics?.Clear(venat.BackColor);

            //##-> Draw Vertical Lines
            foreach (var line in (venat as dynamic).VSeparatorLines ?? Array.Empty<Point[]>())
            {
                yoshiP?.Graphics?.DrawLine(FormDecorationPen, line[0], line[1]);
            }

            //##-> Draw Horizontal Lines
            foreach (var line in (venat as dynamic).HSeparatorLines ?? Array.Empty<Point[]>())
            {
                yoshiP?.Graphics?.DrawLine(FormDecorationPen, line[0], line[1]);
            }

            // Draw a thin (1 pixel) border around the form with the current Pen
            yoshiP?.Graphics?.DrawLines(FormDecorationPen, new[]
            {
                Point.Empty,
                new Point(venat.Width-1, 0),
                new Point(venat.Width-1, venat.Height-1),
                new Point(0, venat.Height-1),
                Point.Empty
            });
        }






        /// <summary>
        /// //!
        /// </summary>
        /// <param name="Venat"></param>
        /// <param name="controls"></param>
        private void InitializeFormDecorations(Form Venat, Control[] controls = null)
        {
            if (controls == null)
            {
                controls = Venat.Controls.Cast<Control>().ToArray();
            }

            var hSeparatorLineScanner = new List<Point[]>();
            var vSeparatorLineScanner = new List<Point[]>();

            // Apply the separator drawing function to any separator lines
            foreach (var line in controls.OfType<Label>())
            {
                if (line.IsSeparatorLine)
                {
                    // Horizontal Lines
                    hSeparatorLineScanner.Add(new Point[2]
                    {
                        new Point(line.StretchToFitForm ? 1 : line.Location.X, line.Location.Y + 7),
                        new Point(line.StretchToFitForm ? line.Parent.Width - 2 : line.Location.X + line.Width, line.Location.Y + 7)
                    });

                    Venat.Controls.Remove(line);
                }
            }

            if (hSeparatorLineScanner.Count > 0)
            {
                HSeparatorLines = hSeparatorLineScanner.ToArray();
            }


            Paint += (venat, yoshiP) => DrawFormDecorations((Form) venat, yoshiP);
        }

        #endregion













        //======================================================\\
        //---|   Form Functionality Function Delcarations   |---\\
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
                if (item.GetType() != typeof(TextBox) && item.GetType() != typeof(RichTextBox))
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

            ExitBtn.Click += new EventHandler((sender, e) => Environment.Exit(0));
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
        #endregion













        //=====================================\\
        //---|   Custom Class Extensions   |---\\
        //=====================================\\
        #region [Custom Class Extensions]

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