using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tennis_Track.Forme;

namespace Tennis_Track
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

            // ------- za verziju bez Logina --------
            Application.Run(new GlavniIzbornik());

            // -------- za normalnu verziju ---------
            //Application.Run(new LoginForm());
        }
    }
}
