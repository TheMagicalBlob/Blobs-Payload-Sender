using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using Payload_Sender;
using System.Linq;
using System.Net;
using System.Threading;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payload_Sender
{
    public partial class Payload_Sender : Form// default size (196, 98);
    {
        public Payload_Sender()
        {
            InitializeComponent();
            IPBox.Text = Payload_Sender_3.Properties.Settings.Default.SET_IP;
            PortBox.Text = Convert.ToString(Payload_Sender_3.Properties.Settings.Default.SET_PORT);
            if (Payload_Sender_3.Properties.Settings.Default.TM == 1)
            {
                D(1);
            }
            T(Payload_Sender_3.Properties.Settings.Default.SET_COLOUR);
        }
        int TI = 0;
        public static string BIN = "";
        public static Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        //Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        Button BTN = new Button();
        Button[] buttonArray = new Button[8];
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
            BrowseButton.ForeColor = c;
            SendButton.ForeColor = c;
            Payload_Sender_3.Properties.Settings.Default.SET_COLOUR = c;
        }
        private void D(int D)
        {
            if (D == 1)
            {
                bb1.Visible = true;
                bb2.Visible = true;
                bb3.Visible = true;
                BuildLabel.Visible = false;
                ClientSize = new Size(843, 374);
            }
            else
            {
                bb1.Visible = false;
                bb2.Visible = false;
                BuildLabel.Visible = true;
                bb3.Visible = false;
                ClientSize = new Size(196, 98);
            }
        }

        private const int WM_NCHITTEST = 0x84;// *
        private const int HT_CAPTION = 0x2;// *
        protected override void WndProc(ref Message m)// ** Thank You To elimad On StackOverflow For This Code To Move The Form :)
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
            O.Filter = "Payload|*.bin*";
            {
                if (O.ShowDialog() == DialogResult.OK)
                {
                    PayloadPathBox.Text = O.FileName;
                }
            }
        }
        private void C()
        {
            //Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            s.Connect(new IPEndPoint(IPAddress.Parse(IPBox.Text), Convert.ToInt32(PortBox.Text)));
            s.SendFile(BIN);
            s.Close();
            MessageBoxButtons b = MessageBoxButtons.OKCancel;
            DialogResult r;
            r = MessageBox.Show("Payload: " + BIN, "Injected Without Issue :)", b);
            if (r == DialogResult.Cancel)
            {
                Close();
            }
        }
        private void S()// 
        {
            // s.SendFile(BIN);
        }
        private void Cs()
        {
            //s.Close();
            MessageBoxButtons b = MessageBoxButtons.OKCancel;
            DialogResult r;
            r = MessageBox.Show("Payload: " + BIN, "Injected Without Issue :)", b);
            if (r == DialogResult.Cancel)
            {
                Close();
            }
        }
        private void SendButton_Click(object sender, EventArgs e)
        {
            try
            {
                C();
                //S();
                //Cs();
            }
            catch (Exception fuck)
            {
                MessageBoxButtons b = MessageBoxButtons.AbortRetryIgnore;
                DialogResult r = MessageBox.Show(fuck.Message, "An Oh-Fuck Has Occured!", b);
                if (r == DialogResult.Retry)
                {
                    Thread.Sleep(1000);
                    SendButton_Click(sender, e);
                }
                else if (r == DialogResult.Abort)
                {
                    s.Close();
                    Thread.Sleep(1337);
                    //MessageBox.Show("Note: Socket Still Open");
                }
            }
        }

        private void PayloadPathBox_TextChanged(object sender, EventArgs e)
        {
            if (PayloadPathBox.Text == "dbg")
            {
                D(1);
                PayloadPathBox.Text ="(Payload Path Here)        ";
            }
            else if (PayloadPathBox.Text == "rls")
            {
                D(0);
                PayloadPathBox.Text = "(Payload Path Here)        ";
            }
            else if (PayloadPathBox.Text == "debsv")
            {
                D(1);
                PayloadPathBox.Text = "(Payload Path Here)        ";
                Payload_Sender_3.Properties.Settings.Default.TM = 1;
                Payload_Sender_3.Properties.Settings.Default.Save();
            }
            else if (PayloadPathBox.Text == "relsv")
            {
                D(0);
                PayloadPathBox.Text = "(Payload Path Here)        ";
                Payload_Sender_3.Properties.Settings.Default.TM = 0;
                Payload_Sender_3.Properties.Settings.Default.Save();
            }
            else
            {
                BIN = PayloadPathBox.Text;
                Payload_Sender_3.Properties.Settings.Default.SET_PATH = PayloadPathBox.Text;
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
            Payload_Sender_3.Properties.Settings.Default.Save();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            Payload_Sender_3.Properties.Settings.Default.Save();
        }

        private void ThemeBtn_Click(object sender, EventArgs e)
        {
            if (TI == 0)
            {
                ClientSize = new Size(214, 135);
                Box.Size = new Size(214, 117);
                TI = 1;
            }
            else
            {
                ClientSize = new Size(214, 98);
                Box.Size = new Size(214, 81);
                TI = 0;
            }
        }

        private void PinkBtn_Click(object sender, EventArgs e)
        {
            T(Color.Fuchsia);
        }

        private void PorpleBtn_Click(object sender, EventArgs e)
        {
            T(Color.DarkViolet);
        }

        private void CrimsonBtn_Click(object sender, EventArgs e)
        {
            T(Color.Lime);
        }

        private void BlueBtn_Click(object sender, EventArgs e)
        {
            T(Color.Blue);
        }

        private void OrangeBtn_Click(object sender, EventArgs e)
        {
            T(Color.DarkOrange);
        }

        private void YellowBtn_Click(object sender, EventArgs e)
        {
            T(Color.Gold);
        }

        private void RedBtn_Click(object sender, EventArgs e)
        {
            T(Color.Red);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            T(Color.LimeGreen);
        }

        private void AquaButton_Click(object sender, EventArgs e)
        {
            T(Color.Aqua);
        }
        private void buttonButton_Click(object sender, EventArgs e) // 
        {
            if (TI == 0)
            {
                //int h = 5;
                for (int i = 0; i < 10; i++)
                {
                    int T = 50;
                    int L = 350;
                    //Button BTN = new Button();
                    Controls.Add(BTN);
                    BTN.Location = new Point(L, T);
                    BTN.Size = new Size(40, 40);
                    BTN.Click += BTN_Click;
                    TI = 1;
                }
            }
            else if (TI == 1)
            {
                Controls.Remove(BTN);
                TI = 0;
            }
        }
        private void BTN_Click(object sender, EventArgs e)
        {
            //Payload_Sender.Properties.Settings.Default.App_Colour = Color.Red;
            Close();
        }
        private void BTN2_Click(object sender, EventArgs e)
        {
            //if (i == 6)
            {
                MessageBox.Show("Test", "tst");
                //return null;
            }
        }
        private void noButtonButton_Click(object sender, EventArgs e)
        {
            //Button[] buttonArray = new Button[8];
            if (TI == 0)
            {
                int h = 7;
                for (int i = 0; i <= h - 1; i++)
                {
                    buttonArray[i] = new Button();
                    buttonArray[i].Size = new Size(40, 40);
                    buttonArray[i].Name = "D" + i + "";
                    buttonArray[i].Click += BTN2_Click;
                    buttonArray[i].Location = new Point(350, 30 + (i * 40));
                    Controls.Add(buttonArray[i]);
                    TI = 1;
                }
            }
            else
            {
                //int h = 7;
                for (int i = 0; i <= 7 - 1; i++)
                {
                    Controls.Remove(buttonArray[i]);
                    TI = 0;
                }
            }
        }

        private void bb3_Click(object sender, EventArgs e)
        {
            List<Button> buttons = new List<Button>();
            for (int i = 0; i < 10; i++)
            {
                Button newButton = new Button();
                buttons.Add(newButton);
                Controls.Add(newButton);
            }
        }

        private void PortBox_TextChanged(object sender, EventArgs e)
        {
            Payload_Sender_3.Properties.Settings.Default.SET_PORT = Convert.ToInt32(PortBox.Text);
        }

        private void IPBox_TextChanged(object sender, EventArgs e)
        {
            Payload_Sender_3.Properties.Settings.Default.SET_IP = IPBox.Text;
        }
    }
}