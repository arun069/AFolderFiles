using System;
using System.IO;
using System.Security.AccessControl;

namespace AFolderFiles
{
    public class AFolderFilesPermission
    {
        /// <summary>
        /// All Read Write Permission will be Applied on this Folder
        /// created this library  on 24-02-2018 by arun kumar
        /// </summary>
        /// <param name="folderPath"></param>
        public static void AddFolderSecurity(string folderPath)
        {
            //Method to Bypass User Access Control (UAC) by assigning permissions.
            DirectorySecurity securityBDir = Directory.GetAccessControl(folderPath);
            FileSystemAccessRule accRuleBDir = new FileSystemAccessRule(Environment.UserDomainName + "\\" + Environment.UserName, FileSystemRights.FullControl, AccessControlType.Allow);
            securityBDir.AddAccessRule(accRuleBDir);
        }

        /// <summary>
        /// All Read Write Permission will be Applied on this files
        /// created this library  on 24-02-2018 by arun kumar
        /// </summary>
        /// <param name="fileName"></param>
        // Adds an ACL entry on the specified file for the specified account.
        public static void AddFileSecurity(string fileName)
        {
            // Get a FileSecurity object that represents the
            // current security settings.
            FileSecurity fSecurity = File.GetAccessControl(fileName);
            // Add the FileSystemAccessRule to the security settings.
            fSecurity.AddAccessRule(new FileSystemAccessRule(Environment.UserDomainName + "\\" + Environment.UserName, FileSystemRights.ReadData, AccessControlType.Allow));
            // Set the new access settings.
            File.SetAccessControl(fileName, fSecurity);
        }
    }
}
