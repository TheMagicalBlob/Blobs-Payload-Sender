using System;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Payload_Sender
{
    public partial class Payload_Sender : Form
    {
        public Payload_Sender()
        {
            InitializeComponent();
            try
            {
                IPBox.Text = Blobs_Payload_Sender.Properties.Settings.Default.SET_IP;
                PortBox.Text = Convert.ToString(Blobs_Payload_Sender.Properties.Settings.Default.SET_PORT);
                T(Blobs_Payload_Sender.Properties.Settings.Default.SET_COLOUR);
                PayloadPathBox.Text = Blobs_Payload_Sender.Properties.Settings.Default.SET_PATH;
                BIN = Blobs_Payload_Sender.Properties.Settings.Default.SET_PATH;
            }
            catch (Exception fuck)
            { MessageBox.Show(fuck.Message, "An Oh-Fuck Has Occured!"); }
        }
        /// <summary> Default Size 1.4.6
        /// ClientSize = new Size(215, 99); 
        /// Box.Size = new Size(215, 82);
        /// </summary>
        int TI = 0;
        public static string BIN = "(Payload Path Here)        ";
        public static Button BTN = new Button();
        public static Button[] TB = new Button[10];
        public static TextBox HashBox = new TextBox();
        public static string HC = HashBox.Text;
        public static TextBox HB = new TextBox();
        public static Color HashColour = ColorTranslator.FromHtml(HC);
        private void T(Color c)
        {
            MinimizeBtn.ForeColor = c;
            CloseBtn.ForeColor = c;
            PayloadPathBox.ForeColor = c;
            IPLabel.ForeColor = c;
            PortLabel.ForeColor = c;
            Box.ForeColor = c;
            BuildLabel.ForeColor = c;
            IPBox.ForeColor = c;
            PortBox.ForeColor = c;
            PayloadPathBox.ForeColor = c;
            ThemeBtn.ForeColor = c;
            ResetLabel.ForeColor = c;
            BrowseButton.ForeColor = c;
            SendButton.ForeColor = c;
            P1_Btn.ForeColor = c;
            Blobs_Payload_Sender.Properties.Settings.Default.SET_COLOUR = c;
        }
        private const int WM_NCHITTEST = 0x84;// *
        private const int HT_CAPTION = 0x2;// *
        protected override void WndProc(ref Message m)// ** Thanks "elimad" On StackOverflow For This Code To Move The Form lol :)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
            {
                m.Result = (IntPtr)(HT_CAPTION);
            }
        }
        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog O = new OpenFileDialog();
            O.Filter = "Payload (*.bin)|*.bin|Elf (*.elf)|*.elf*";
            {
                if (O.ShowDialog() == DialogResult.OK) {
                    PayloadPathBox.Text = O.FileName;
                    Blobs_Payload_Sender.Properties.Settings.Default.SET_PATH = O.FileName;
                }
            }
        }
        private void C() // Standard One
        {try {
                Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                s.Connect(new IPEndPoint(IPAddress.Parse(IPBox.Text), Convert.ToInt32(PortBox.Text)));
                s.SendFile(BIN);
                s.Close();
                MessageBoxButtons b = MessageBoxButtons.YesNoCancel;
                DialogResult r;
                r = MessageBox.Show("Payload: " + BIN, "Injected Without Issue :) - Press Yes To Send It Again, Or Cancel To Exit", b);
                if (r == DialogResult.Cancel) {
                    Blobs_Payload_Sender.Properties.Settings.Default.Save();Close();
                }
                if (r == DialogResult.Yes) {
                    C();
                }
            } catch (Exception fuck)
            { MessageBox.Show(fuck.Message, "private void C()"); }
        }
        private void C2() // For Saved Payloads
        {
            try
            {
                Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                s.Connect(new IPEndPoint(IPAddress.Parse(IPBox.Text), Convert.ToInt32(PortBox.Text)));
                s.SendFile(Blobs_Payload_Sender.Properties.Settings.Default.SET_P1);
                s.Close();
                MessageBoxButtons b = MessageBoxButtons.YesNoCancel;
                DialogResult r;
                r = MessageBox.Show("Payload: " + Blobs_Payload_Sender.Properties.Settings.Default.SET_P1, "Injected Without Issue :) - Press Ok To Send Another, Or Cancel To Exit", b);
                if (r == DialogResult.Cancel)
                { Blobs_Payload_Sender.Properties.Settings.Default.Save(); Close(); }
                if (r == DialogResult.Yes)
                {
                    C2();
                }
            }
            catch (Exception fuck)
            { MessageBox.Show(fuck.Message, "private void C()"); }
        }
        private void SendButton_Click(object sender, EventArgs e)
        {
            try
            { C(); }
            catch (Exception fuck)
            { MessageBox.Show(fuck.Message, "private void SendButton_Click(object sender, EventArgs e)");}
        }

        private void PayloadPathBox_TextChanged(object sender, EventArgs e)
        { 
            Blobs_Payload_Sender.Properties.Settings.Default.SET_PATH = PayloadPathBox.Text; BIN = PayloadPathBox.Text;
        }
        private void CloseBtn_Click(object sender, EventArgs e) { Blobs_Payload_Sender.Properties.Settings.Default.Save(); Close(); }
        private void PortBox_TextChanged(object sender, EventArgs e) { Blobs_Payload_Sender.Properties.Settings.Default.SET_PORT = Convert.ToInt32(PortBox.Text); }
        private void IPBox_TextChanged(object sender, EventArgs e) { Blobs_Payload_Sender.Properties.Settings.Default.SET_IP = IPBox.Text; }
        private void MinimizeBtn_Click(object sender, EventArgs e)  { WindowState = FormWindowState.Minimized; Blobs_Payload_Sender.Properties.Settings.Default.Save(); }

        private void ThemeBtn_Click(object sender, EventArgs e)
        {
            if (TI == 0)
            {
                for (int i = 0; i <= 9; i++)
                {
                    ClientSize = new Size(215, 118); // With HashBox: ClientSize = new Size(214, 140); //  Without HashBox: ClientSize = new Size(214, 118);
                    Box.Size = new Size(215, 101); // With HashBox: Box.Size = new Size(214, 123); //  Without HashBox: Box.Size = new Size(214, 101);
                    TB[i] = new Button();
                    //BTN = new Button();
                    TB[i].Size = new Size(20, 20);
                    TB[i].Location = new Point(3 + i * 21, 78);
                    TB[i].FlatStyle = FlatStyle.Flat;
                    //HashBox.Location = new Point(2, 100);
                    //HashBox.Size = new Size(210, 0);
                    //HashBox.ForeColor = Blobs_Payload_Sender.Properties.Settings.Default.SET_COLOUR;
                    //HashBox.BackColor = Color.Black;
                    //HashBox.TextAlign = (HorizontalAlignment)ContentAlignment.TopCenter;
                    BTN.Location = new Point(170, 103);
                    BTN.FlatStyle = FlatStyle.Flat;
                    BTN.Size = new Size(40, 14);
                    Box.Controls.Add(TB[i]);
                    //Box.Controls.Add(HashBox);
                    //Box.Controls.Add(BTN);
                    //BTN.BringToFront();
                    TI = 1;
                }
            }
            else
            {
                for (int i = 0; i <= 9; i++)
                {
                    Box.Controls.Remove(TB[i]);
                    //Box.Controls.Remove(BTN);
                    //Box.Controls.Remove(HashBox);
                    ClientSize = new Size(215, 100);
                    Box.Size = new Size(215, 83);
                    TI = 0;
                }
            }
            //BTN.Click += new EventHandler(HashTheme);
            TB[0].Click += TM0; TB[0].ForeColor = Color.Fuchsia;
            TB[1].Click += TM1; TB[1].ForeColor = Color.DeepPink;
            TB[2].Click += TM2; TB[2].ForeColor = Color.Red;
            TB[3].Click += TM3; TB[3].ForeColor = Color.Gold;
            TB[4].Click += TM4; TB[4].ForeColor = Color.DarkViolet;
            TB[5].Click += TM5; TB[5].ForeColor = Color.Blue;
            TB[6].Click += TM6; TB[6].ForeColor = Color.Aqua;
            TB[7].Click += TM7; TB[7].ForeColor = Color.DeepSkyBlue;
            TB[8].Click += TM8; TB[8].ForeColor = Color.SpringGreen;
            TB[9].Click += TM9; TB[9].ForeColor = Color.Lime;
            //HashBox.TextChanged += new EventHandler(ChangeHash);
            //TB[10].Click += TM10;TB[10].ForeColor =Color.Green;
        }
        private void TM0(object sender, EventArgs e) {T(Color.Fuchsia);}
        private void TM1(object sender, EventArgs e) {T(Color.DeepPink);}
        private void TM2(object sender, EventArgs e) {T(Color.Red);}
        private void TM3(object sender, EventArgs e) {T(Color.Gold);}
        private void TM4(object sender, EventArgs e) {T(Color.DarkViolet);}
        private void TM5(object sender, EventArgs e) {T(Color.Blue);}
        private void TM6(object sender, EventArgs e) {T(Color.Aqua);}
        private void TM7(object sender, EventArgs e) {T(Color.DeepSkyBlue);}
        private void TM8(object sender, EventArgs e) {T(Color.SpringGreen);}
        private void TM9(object sender, EventArgs e) {T(Color.Lime);}
        //private void TM10(object sender, EventArgs e){T(Color.Green);}
        private void HashTheme(object sender, EventArgs e) { T(HashColour); }
        //private void ChangeHash(object sender, EventArgs e) { HC = HashBox.Text; }

        private void P1_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Blobs_Payload_Sender.Properties.Settings.Default.SET_P1 == "NO_PATH")
                {
                    OpenFileDialog O = new OpenFileDialog();
                    O.Filter = "Payload|*.bin*";
                    {
                        if (O.ShowDialog() == DialogResult.OK)
                        {
                            Blobs_Payload_Sender.Properties.Settings.Default.SET_P1 = O.FileName;
                        }
                    }
                }
                else
                {
                    C2();
                }
            } catch (Exception fuck) {
                DialogResult r = MessageBox.Show(fuck.Message);
                if(r == DialogResult.OK)
                {
                    Blobs_Payload_Sender.Properties.Settings.Default.SET_P1 = "0";
                    P1_Btn_Click(sender, e);
                }
            }
        }

        private void PortLabel_Click(object sender, EventArgs e)
        {
            if (PortBox.Text != "9020") {
                PortBox.Text = "9020";
            }
            else if (PortBox.Text == "9020") {
                PortBox.Text ="9021";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Blobs_Payload_Sender.Properties.Settings.Default.SET_P1 = "NO_PATH";
            P1_Btn_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(BIN);
        }
    }
}