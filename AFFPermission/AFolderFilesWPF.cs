using System.Reflection;

namespace AFolderFiles
{
    /// <summary>
    /// this class support WPF 
    /// </summary>
    public class AFolderFilesWPF
    {
        /// <summary>
        /// Return Root Directory Where Dll Store\
        /// use to get WPF Root Directory Also
        /// </summary>
        /// <returns></returns>
        public static string StartupPath()
        {
            return System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        }

    }
}
