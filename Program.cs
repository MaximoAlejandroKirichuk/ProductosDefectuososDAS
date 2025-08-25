using System;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace UI
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Cambia Form1 por el formulario principal de tu app
            Application.Run(new Form1());
        }
    }
}
