using QuickBill.Properties;
using System;
using System.IO;
using System.Windows.Forms;

namespace QuickBill
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            dboperation operation = new dboperation();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

              string db = Settings.Default.DatabasePath + "\\" + Global.ROOT_DATA_FOLDER + "\\" + Global.DB_NAME_PREFIX + ".sdf";

              if (!File.Exists(db))
              {
                  Application.Run(new registration());
              }
              else
              {
                  if (operation.keyvalidation())
                  {
                      Application.Run(new loginPanel());
                  }
                  else
                  {
                      Application.Run(new registration());
                  }

              }


  
           // Application.Run(new TestPicture());
            
        }
    }
}
