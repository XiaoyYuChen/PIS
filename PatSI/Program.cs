using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PatSI
{
    static class Program
    {
      public  static string Version="V1.0";
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BLL.MySqlHelper.init();
#if !DEBUG
            checkVersion frmcv = new checkVersion();
            if (frmcv.ShowDialog() == DialogResult.Abort)
            {
                return;
            }
#endif
            Application.Run(new MDIMain());
            
        }

    }
}
