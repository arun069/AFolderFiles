using System.IO;
namespace AFolderFiles
{
    public class AFolderFilesCreate
    {
        /// <summary>
        /// Create Folder (If Folder already exist delete old folder then create new folder)
        /// </summary>
        /// <param name="folderPath">folderpat</param>
        /// <returns></returns>
        public static bool CreateFolderDeleteOld(string folderPath)
        {
            try
            {
                // Delete Folder If Already Exist
                AFolderFilesDelete.EmptyFolder(folderPath);
                System.Threading.Thread.Sleep(200);
                Directory.CreateDirectory(folderPath);
                return true;
            }
            catch { return false; }
        }


        /// <summary>
        /// Create Folder If Not Exist.....
        /// </summary>
        /// <param name="folderPath"></param>
        /// <returns></returns>
        public static bool CreateIfNotExist(string folderPath)
        {
            try
            {
                if (!Directory.Exists(folderPath)== true)
                {
                    Directory.CreateDirectory(folderPath);
                    return true;
                }
                else { return true; }
            }
            catch { return false; }

        }
    }
}
