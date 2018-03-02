using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AFolderFiles
{
    /// <summary>
    /// This class contains all miscellaneous methods
    /// </summary>
    public class AFolderFilesMiscellaneous
    {
        /// <summary>
        /// retun system default temp folder path
        /// </summary>
        /// <returns></returns>
        public static string SystemTempFolder()
        {
            return System.IO.Path.GetTempPath();
        }

        /// <summary>
        /// return dll path also same application startup path
        /// </summary>
        /// <returns></returns>
        public static string StartupPath()
        {
           return Application.StartupPath;
        }


        public static string ReadTextfile(string txtfile)
        {
            if (File.Exists(txtfile) == true)
                return File.ReadAllText(txtfile, Encoding.UTF8);
            else return "Missing Text File";
        }

    }
}
