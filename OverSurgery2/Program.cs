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
        [STAThread]
        static void Main()
        {
            while (true)
            {
                switch (Console.ReadKey(true).KeyChar)
                {
                    case 's':
                            Application.EnableVisualStyles();
                            Application.SetCompatibleTextRenderingDefault(false);
                            Application.Run(new LoginForm());
                        break;
                    case 'h':
                        Console.Write("Password to be Hashed: ");
                        Console.WriteLine(LoginController.Instance().HashPassword(Console.ReadLine()));
                        break;
                    default:
                        break;
                }
            }

        }

        /// <summary>
        /// Return a Hashed String
        /// </summary>
        /// <param name="o"></param>
    }
}
