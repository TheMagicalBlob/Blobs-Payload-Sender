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
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            do {
                Application.Run(new PayloadSender.Payload_Sender());
                Console.WriteLine("\nRestarting program...");
            }
            while (true); // Restart program when closed through Close() function instead of Environment.Exit(0)
        }
    }
}
