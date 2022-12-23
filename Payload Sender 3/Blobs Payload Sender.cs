using System;
using System.Drawing;
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
            try {
                IPBox.Text = Blobs_Payload_Sender.Properties.Settings.Default.SET_IP;
                PortBox.Text = Convert.ToString(Blobs_Payload_Sender.Properties.Settings.Default.SET_PORT);
                T(Blobs_Payload_Sender.Properties.Settings.Default.SET_COLOUR);
                PayloadPathBox.Text = Blobs_Payload_Sender.Properties.Settings.Default.SET_PATH;
                BIN = Blobs_Payload_Sender.Properties.Settings.Default.SET_PATH;
                if (Blobs_Payload_Sender.Properties.Settings.Default.IsFirstTime) {
                    MessageBox.Show("READ ME\n\n- Right-Click The \"Saved\" Button To Choose A New Payload To Save.\n- Clicking The \"Port\" Label Switches The Port Between 9090/9020/9021", "First-Time Message - This Won't Show Again After This");
                    Blobs_Payload_Sender.Properties.Settings.Default.IsFirstTime = false;
                    Blobs_Payload_Sender.Properties.Settings.Default.Save();
                }
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
        private void T(Color c) {
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
            BrowseButton.ForeColor = c;
            SendButton.ForeColor = c;
            Blobs_Payload_Sender.Properties.Settings.Default.SET_COLOUR = c;
        }

        protected override void WndProc(ref Message m) {
//          Got This Code To Move The Now Borderless Form From StackOverflow lol, Not Mine
            base.WndProc(ref m);        
            const int WM_NCHITTEST = 0x84;
            const int HT_CAPTION = 0x2;
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }
        private void BrowseButton_Click(object sender, EventArgs e) {
            FileDialog O = new OpenFileDialog {
                Filter = "Payload/Executable|*.bin;*.elf",
                Title = "Which File Would You Like To Send?"
            };
            if (O.ShowDialog() == DialogResult.OK) {
                PayloadPathBox.Text = O.FileName;
                Blobs_Payload_Sender.Properties.Settings.Default.SET_PATH = O.FileName;
            }
        }
        private void C()
        {
            try {
                Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                s.Connect(new IPEndPoint(IPAddress.Parse(IPBox.Text), Convert.ToInt32(PortBox.Text)));
                s.SendFile(BIN); s.Close();

                MessageBoxButtons b = MessageBoxButtons.OKCancel; DialogResult r;
                r = MessageBox.Show("Payload: " + BIN, "Injected Without Issue :) - Press Ok To Continue | Cancel To Exit", b);
                if (r == DialogResult.Cancel) {
                    Blobs_Payload_Sender.Properties.Settings.Default.Save(); Close();
                }
            }
            catch (Exception fuck) { MessageBox.Show(fuck.Message, "C1"); }
        }
        private void SendButton_Click(object sender, EventArgs e) {
            try
                { C(); } // Some "Obfuscation" So WD Doesn't Think It's A Virus. Aren't False-Positives Fun?
            catch (Exception fuck)
            { MessageBox.Show(fuck.Message, "SendButton_Click");}
        }

        private void PayloadPathBox_TextChanged(object sender, EventArgs e) { Blobs_Payload_Sender.Properties.Settings.Default.SET_PATH = PayloadPathBox.Text; BIN = PayloadPathBox.Text; }
        private void CloseBtn_Click(object sender, EventArgs e) { Blobs_Payload_Sender.Properties.Settings.Default.Save(); Close(); }
        private void PortBox_TextChanged(object sender, EventArgs e) { Blobs_Payload_Sender.Properties.Settings.Default.SET_PORT = Convert.ToInt32(PortBox.Text); }
        private void IPBox_TextChanged(object sender, EventArgs e) { Blobs_Payload_Sender.Properties.Settings.Default.SET_IP = IPBox.Text; }
        private void MinimizeBtn_Click(object sender, EventArgs e)  { WindowState = FormWindowState.Minimized; Blobs_Payload_Sender.Properties.Settings.Default.Save(); }

        private void ThemeBtn_Click(object sender, EventArgs e) {
            if (TI == 0) {
                for (int i = 0; i <= 9; i++) {
                    ClientSize = new Size(215, 119);
                    Box.Size = new Size(215, 102);
                    TB[i] = new Button();
                    TB[i].Size = new Size(20, 20);
                    TB[i].Location = new Point(3 + i * 21, 78);
                    TB[i].FlatStyle = FlatStyle.Flat;
                    BTN.Location = new Point(170, 103);
                    BTN.FlatStyle = FlatStyle.Flat;
                    BTN.Size = new Size(40, 14);
                    Box.Controls.Add(TB[i]);
                    TI = 1;
                }
            }
            else {
                for (int i = 0; i <= 9; i++) {
                    Box.Controls.Remove(TB[i]);
                    ClientSize = new Size(215, 100);
                    Box.Size = new Size(215, 83);
                    TI = 0;
                }
            }
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
        }
        private void TM0(object sender, EventArgs e) => T(Color.Fuchsia);
        private void TM1(object sender, EventArgs e) => T(Color.DeepPink);
        private void TM2(object sender, EventArgs e) => T(Color.Red);
        private void TM3(object sender, EventArgs e) => T(Color.Gold);
        private void TM4(object sender, EventArgs e) => T(Color.DarkViolet);
        private void TM5(object sender, EventArgs e) => T(Color.Blue);
        private void TM6(object sender, EventArgs e) => T(Color.Aqua);
        private void TM7(object sender, EventArgs e) => T(Color.DeepSkyBlue);
        private void TM8(object sender, EventArgs e) => T(Color.SpringGreen);
        private void TM9(object sender, EventArgs e) => T(Color.Lime);

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
    }
}