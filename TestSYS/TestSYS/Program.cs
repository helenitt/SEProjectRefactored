using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSYS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new frmWelcome()); 
            //Application.Run(new frmLecStudSearch());
            //Application.Run(new frmStudMenu());
            //Application.Run(new frmLecMenu());
            //Application.Run(new frmStudentList()); 
            //Application.Run(new frmQAdd());
        }
    }
}
