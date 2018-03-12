using System;
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
        /// retun system default temp folder path 03-03-2018
        /// </summary>
        /// <returns></returns>
        public static string SystemTempFolder()
        {
            return System.IO.Path.GetTempPath();
        }

        /// <summary>
        /// return dll path also same application startup path 03-03-2018
        /// </summary>
        /// <returns></returns>
        public static string StartupPath()
        {
           return Application.StartupPath;
        }

        /// <summary>
        /// Read a textfile 03-03-2018
        /// </summary>
        /// <param name="txtfile"></param>
        /// <returns></returns>
        public static string ReadTextfile(string txtfile)
        {
            if (File.Exists(txtfile) == true)
                return File.ReadAllText(txtfile, Encoding.UTF8);
            else return "Missing Text File";
        }

        /// <summary>
        /// Create And Append text file  12-03-2018
        /// </summary>
        /// <param name="txtfile"></param>
        /// <param name="attrib"></param>
        /// <returns></returns>
        public static string CreateTextFile(string txtfile, string attrib)
        {
            try
            {
                using (FileStream fs = new FileStream(txtfile, FileMode.OpenOrCreate))
                {
                    using (TextWriter tw = new StreamWriter(fs))
                    {
                        tw.Write(attrib);
                    }
                }
                return "ok";
            }
            catch(Exception ex) { return "Error::" + Environment.NewLine + ex.Message; }   

        }
        
    }
}
