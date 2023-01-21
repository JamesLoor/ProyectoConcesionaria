using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoConcesionaria
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
<<<<<<< HEAD
            Application.Run(new LoginForm());
            Application.Run(new Home());
            Application.Run(new Incomes());
=======
            //Application.Run(new LoginForm());
            Application.Run(new UserDialog());
>>>>>>> b315d3efea146563f3b1e93f98b78a6c3b1c6cdc
        }
    }
}
