using System;
using System.Windows.Forms;
using TSI.Services;

namespace TSI.AppWindows
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            CompositionRoot.Wire(new TSIContainer());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(CompositionRoot.Resolve<FRMEmpleado>());
        }
    }
}