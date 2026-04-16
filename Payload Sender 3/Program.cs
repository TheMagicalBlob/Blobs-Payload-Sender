using System;
using System.Windows.Forms;

namespace Payload_Sender_3
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PayloadSender.Payload_Sender());
        }
    }
}
