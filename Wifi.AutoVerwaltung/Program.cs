using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wifi.AutoVerwaltung
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

            try
            {
                Application.Run(new FormMain());
            }
            catch (Exception)
            {

                MessageBox.Show("Es ist ein unbehandelter Fehler aufgetreten.\nBitte Wenden Sie sich an den Hersteller","Fehler" , MessageBoxButtons.OK,  MessageBoxIcon.Error);
                return;
            } 
        }
    }
}
