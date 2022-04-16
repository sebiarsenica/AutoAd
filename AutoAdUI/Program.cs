using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoAdUI
{
    public class Global
    {
        public static string filePath = "D://facultate/Anul 2/Semestrul 1/Medii si instrumente de programare/Teme Laborator/AutoAd/Anunturi";
        public static int index = 0;
    }

    
    
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
            Application.Run(new Form2());
        }
    }
}
