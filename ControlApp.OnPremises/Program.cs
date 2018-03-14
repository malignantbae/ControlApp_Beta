
using ControlApp.OnPremises.Forms.Dashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlApp.OnPremises
{
   
    static class Program
    {

        public static class MystaticValues
        {
           public static string IdSession = "186200492318";
           public static int rptSsrs = 0;
           
        }
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDashboard());
        }
       
    }
}
