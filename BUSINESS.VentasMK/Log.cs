using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Hosting;

namespace BUSINESS.VentasMK
{
    public class Log
    {
        public string fileName;
        public Log(string file)
        {
            fileName = file;
        }
        public Log()
        {
            fileName = HostingEnvironment.ApplicationPhysicalPath + "Logs/Log_" + DateTime.Now.ToString("yyyy-MM-dd") + ".log";
        }
        public void EscribirLog(Exception ex)
        {
            try
            {
                using (StreamWriter w = File.AppendText(fileName))
                {
                    w.WriteLine("--------------------------------------------------------------------------------");
                    w.WriteLine(DateTime.Now.ToString() + " - EXCEPCION");
                    w.WriteLine("Message: " + ex.Message);
                    w.WriteLine("Source: " + ex.Source);
                    w.WriteLine("TargetSite: " + ex.TargetSite);
                    w.WriteLine("StackTrace: " + ex.StackTrace);
                    w.WriteLine("InnerException: " + ex.InnerException);
                    w.WriteLine("--------------------------------------------------------------------------------");
                }
            }
            catch { }
        }

    }
}
