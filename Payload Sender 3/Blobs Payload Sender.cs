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
    public partial class Payload_Sender : Form// default size (214, 98);
    {
        public Payload_Sender()
        {
            InitializeComponent();
            IPBox.Text = Blobs_Payload_Sender.Properties.Settings.Default.SET_IP;
            PortBox.Text = Convert.ToString(Blobs_Payload_Sender.Properties.Settings.Default.SET_PORT);
            if (Blobs_Payload_Sender.Properties.Settings.Default.TM == 1)
            {
                D(1);
            }
            T(Blobs_Payload_Sender.Properties.Settings.Default.SET_COLOUR);
        }
        int TI = 0;
        public static string BIN = "";
        public static Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        //Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        Button BTN = new Button();
        Button[] buttonArray = new Button[10];
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
            Blobs_Payload_Sender.Properties.Settings.Default.SET_COLOUR = c;
        }
        private void D(int D)
        {
            if (D == 1)
            {
                bb2.Visible = true;
                ClientSize = new Size(843, 374);
            }
            else
            {
                bb2.Visible = false;
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
            //s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

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
        private void S() // UNUSED
        {
            // s.SendFile(BIN);
        }
        private void Cs() // UNUSED
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
            catch (Exception)//fuck)
            {
                s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                SendButton_Click(sender, e);
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
                Blobs_Payload_Sender.Properties.Settings.Default.TM = 1;
                Blobs_Payload_Sender.Properties.Settings.Default.Save();
            }
            else if (PayloadPathBox.Text == "relsv")
            {
                D(0);
                PayloadPathBox.Text = "(Payload Path Here)        ";
                Blobs_Payload_Sender.Properties.Settings.Default.TM = 0;
                Blobs_Payload_Sender.Properties.Settings.Default.Save();
            }
            else
            {
                BIN = PayloadPathBox.Text;
                Blobs_Payload_Sender.Properties.Settings.Default.SET_PATH = PayloadPathBox.Text;
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
            Blobs_Payload_Sender.Properties.Settings.Default.Save();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            Blobs_Payload_Sender.Properties.Settings.Default.Save();
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
        private void TM0(object sender, EventArgs e)
        {
            T(Color.Fuchsia);
        }

        private void TM1(object sender, EventArgs e)
        {
            T(Color.BlueViolet);
        }

        private void TM2(object sender, EventArgs e)
        {
            T(Color.DarkViolet);
        }

        private void TM3(object sender, EventArgs e)
        {
            T(Color.Lime);
        }

        private void TM4(object sender, EventArgs e)
        {
            T(Color.Blue);
        }

        private void TM5(object sender, EventArgs e)
        {
            T(Color.DarkOrange);
        }

        private void TM6(object sender, EventArgs e)
        {
            T(Color.Gold);
        }

        private void TM7(object sender, EventArgs e)
        {
            T(Color.Red);
        }

        private void TM8(object sender, EventArgs e)
        {
            T(Color.LimeGreen);
        }

        private void TM9(object sender, EventArgs e)
        {
            T(Color.Aqua);
        }
        private void TM(int i)
        {
            switch (i)
            {
                case 0:
                    T(Color.Red);
                    break;
                case 1:
                    T(Color.Green);
                    break;
                case 2:
                    T(Color.Blue);
                    break;
                case 3:
                    T(Color.DarkOrange);
                    break;
                case 4:
                    T(Color.Gold);
                    break;
            }
        }
        private void noButtonButton_Click(object sender, EventArgs e)
        {
            //Button[] buttonArray = new Button[8];
            if (TI == 0)
            {
                for (int i = 0; i <= 9; i++)
                {
                    buttonArray[i] = new Button();
                    buttonArray[i].Size = new Size(20, 20);
                    buttonArray[i].Name = "D" + i + "";
                    buttonArray[i].Location = new Point(350, 30 + (i * 20));
                    Controls.Add(buttonArray[i]);
                    ClientSize = new Size(214, 135);
                    Box.Size = new Size(214, 117);
                    TI = 1;
                }
            }
            else
            {
                for (int i = 0; i <= 9; i++)
                {
                    Controls.Remove(buttonArray[i]);
                    ClientSize = new Size(214, 98);
                    Box.Size = new Size(214, 81);
                    TI = 0;
                }
            }
            buttonArray[0].Click += TM0;
            buttonArray[1].Click += TM1;
            buttonArray[2].Click += TM2;
            buttonArray[3].Click += TM3;
            buttonArray[4].Click += TM4;
            buttonArray[5].Click += TM5;
            buttonArray[6].Click += TM6;
            buttonArray[7].Click += TM7;
            buttonArray[8].Click += TM8;
        }

        private void PortBox_TextChanged(object sender, EventArgs e)
        {
            Blobs_Payload_Sender.Properties.Settings.Default.SET_PORT = Convert.ToInt32(PortBox.Text);
        }

        private void IPBox_TextChanged(object sender, EventArgs e)
        {
            Blobs_Payload_Sender.Properties.Settings.Default.SET_IP = IPBox.Text;
        }
    }
}