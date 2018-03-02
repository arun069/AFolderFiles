using System;
using System.IO;

namespace AFolderFiles
{
    /// <summary>
    /// this class empty a folder 
    /// </summary>
    public class AFolderFilesDelete
    {
        /// <summary>
        /// Delete All folder and files with in a folder 
        /// </summary>
        /// <param name="destdir">folder path need empty</param>
        public static bool EmptyFolder(string destdir)
        {
            try
            {
                if(Directory.Exists(destdir) == true)
                {
                    //Method to Bypass User Access Control (UAC) by assigning permissions.
                    AFolderFilesPermission.AddFolderSecurity(destdir);
                    foreach (string ff in Directory.GetFiles(destdir))
                    {
                        AFolderFilesPermission.AddFileSecurity(ff);
                        File.Delete(ff);
                    }
                    foreach (string d in Directory.GetDirectories(destdir))
                    {
                        AFolderFilesPermission.AddFolderSecurity(d);
                        Directory.Delete(d, true);
                    }
                    return true;
                }
                else { return false; }               
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (IOException ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
                return false;
            }
        }

        /// <summary>
        /// Delete File 
        /// </summary>
        /// <param name="file">target file</param>
        /// <returns></returns>
        public static bool DeleteFile(string file)
        {
            try
            {
                if(File.Exists(file) == true)
                {
                    //Method to Bypass User Access Control (UAC) by assigning permissions.
                    AFolderFilesPermission.AddFileSecurity(file);
                    File.Delete(file);
                    return true;
                }
                else { return false; }
            }
#pragma warning disable CS0168 // The variable 'e' is declared but never used
            catch(Exception e)
#pragma warning restore CS0168 // The variable 'e' is declared but never used
            {
                return false;
            }
        }


        /// <summary>
        /// Delete Shapefile
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public static bool DeleteShapefile(string file)
        {
            if (File.Exists(file) == true)
            {
                string filename = Path.GetFileNameWithoutExtension(file);
                string[] files = System.IO.Directory.GetFiles(new FileInfo(file).Directory.ToString());
                foreach (string s in files)
                {
                    string fname = Path.GetFileNameWithoutExtension(s); 
                    if (fname.Equals(filename))
                    {
                        DeleteFile(s);
                    }
                }
                return true;
            }
            else { return false; }
        }

    }
}
