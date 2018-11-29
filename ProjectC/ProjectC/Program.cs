using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProjectC
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
            //clsFormProvider.loginF.ShowDialog();
            //if (clsFormProvider.loginF.getFlag())
            //{
            //    Application.Run(clsFormProvider.mainF);
            //}
            //else Application.Exit();
             //Application.Run(new AddProductForm());
            //Application.Run(new StatisticForm());
            //Application.Run(new SupplierForm());
             Application.Run(clsFormProvider.mainF);
            // Application.Run(new LoginForm());
            //Application.Run(new AddForm());
        }
    }
}
