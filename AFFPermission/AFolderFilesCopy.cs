using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFolderFiles
{
   public class AFolderFilesCopy
    {
        /// <summary>
        /// Copy FIle to another place
        /// </summary>
        /// <param name="source">Source file</param>
        /// <param name="destination">Destination file</param>
        /// <returns></returns>
        public static string CopyFile(string source,string destination)
        {
            if (File.Exists(source) == true)
            {
                if(new FileInfo(destination).Directory.Exists == true)
                {
                    AFolderFilesPermission.AddFileSecurity(source);
                    File.Copy(source, destination);
                    return "Copy Successfully!";
                }
                else { return "Destination Folder Not Found"; }
            }
            else { return "Source  File Missing"; }
        }



        /// <summary>
        /// Copy Shapefile to another place
        /// example ..  AFolderFiles.AFolderFilesCopy.CopyShapeFile(@"E:\Temp\ATemp\AI1.shp", @"E:\Temp\ATemp\T\AI1.shp");
        /// </summary>
        /// <param name="source">Source Shapefile</param>
        /// <param name="destination">Destination Shapefile</param>
        /// <returns></returns>
        public static string CopyShapeFile(string source, string destination)
        {
            if (File.Exists(source) == true)
            {
                string filename = Path.GetFileNameWithoutExtension(source);
                string[] files = System.IO.Directory.GetFiles(new FileInfo(source).Directory.ToString());
                foreach (string s in files)
                {
                    string fname = Path.GetFileNameWithoutExtension(s);
                    string fExt = new FileInfo(s).Extension;
                    if (fname.Equals(filename))
                    {
                        CopyFile(s,new FileInfo(destination).Directory + @"\" + fname + fExt);
                    }                   
                }
                return "Copy Successfully";
            }
            else { return "Source File Missing"; }
        }






        /// <summary>
        /// Overwrite file 
        /// </summary>
        /// <param name="source"> source file</param>
        /// <param name="destination">destination file</param>
        /// <returns></returns>
        public static string ReplaceFile(string source,string destination)
        {
            string s = "Replace file successfully";
            if (File.Exists(source) == true)
            {
                if (File.Exists(destination) == true)
                {
                    AFolderFilesPermission.AddFileSecurity(destination);
                    File.Delete(destination);                  
                }
                if (new FileInfo(destination).Directory.Exists == true)
                {
                    AFolderFilesPermission.AddFileSecurity(source);
                    File.Copy(source, destination,true);
                }
                else { s = "Missing Destination Directory";   }
                return s;
            }
            else { return "Source File Missing"; }
        }


        /// <summary>
        /// Replace file and take old file backup also
        /// </summary>
        /// <param name="source">source file</param>
        /// <param name="destination">Destinaion file</param>
        /// <returns></returns>
        public static string ReplaceFileWithFileBackupAndMoveSourcefile(string source, string destination)
        {
            if (File.Exists(source) == true)
            {
                if (File.Exists(destination) == true)
                {
                    AFolderFilesPermission.AddFileSecurity(source);
                    AFolderFilesPermission.AddFileSecurity(destination);                
                    File.Replace(source, destination, destination + ".bac",true);
                    return "Replace Successfully!";
                }
                else { return "Destination File Not Found"; }
            }
            else { return "Source  File Missing"; }
        }


        /// <summary>
        /// Move File to Another Place
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static string MoveFile(string source, string destination)
        {
            if (File.Exists(source) == true)
            {
                if (new FileInfo(destination).Directory.Exists == true)
                {
                    AFolderFilesPermission.AddFileSecurity(source);
                    File.Move(source, destination);
                    return "Move Successfully!";
                }
                else { return "Destination Folder Not Found"; }
            }
            else { return "Source  File Missing"; }
        }




    }
}
