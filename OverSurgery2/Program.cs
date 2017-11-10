using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;


namespace OverSurgery2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        private static char c = 'x';
        [STAThread]
        static void Main()
        {
            System.Threading.Timer t = new System.Threading.Timer(TimerCallback, null, 0, 2000);
            while (c != 's')
            {
                ConsoleKeyInfo keypress = Console.ReadKey();
                c = keypress.KeyChar;
                TimerCallback(null);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());

        }
        private static void TimerCallback(Object o)
        {
            Console.Write("Password to be Hashed: ");
            Console.WriteLine(LoginController.Instance().HashPassword(Console.ReadLine()));
        }
    }
}
