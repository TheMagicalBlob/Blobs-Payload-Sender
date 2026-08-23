using System;
using System.Windows.Forms;

namespace Payload_Sender
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(params string[] args)
        {
            args = args ?? Array.Empty<string>();

            if (args.Length > 0)
            {
                Application.Run(new PayloadSender.Payload_Sender(args));
                return;
            }



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PayloadSender.Payload_Sender());
        }
    }
}
