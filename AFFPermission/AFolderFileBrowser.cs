namespace AFolderFiles
{
    /// <summary>
    /// this Class help to open folder and file browser 
    /// </summary>
    public class AFolderFileBrowser
    {
        /// <summary>
        /// Open File Browser and return folder path
        /// </summary>
        /// <returns></returns>
        public static string AFolderBrowser()
        {
            System.Windows.Forms.FolderBrowserDialog saveFileDialog = new System.Windows.Forms.FolderBrowserDialog();
            saveFileDialog.ShowNewFolderButton = true;
            //saveFileDialog.Filter = "Excel File|*.xlsx";
            //saveFileDialog.FileName = filename;
            System.Windows.Forms.DialogResult dialogResult = saveFileDialog.ShowDialog();
            if (dialogResult == System.Windows.Forms.DialogResult.OK)
            {
                return saveFileDialog.SelectedPath;
            }
            else return null;
        }

        /// <summary>
        /// Open File Browser And Return Selected Path
        /// </summary>
        /// <param name="FileType"></param>
        /// <returns></returns>
        public static string AOpenFileBrowser(string FileType)
        {
            System.Windows.Forms.OpenFileDialog OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            OpenFileDialog.Filter = FileType + " File|*." + FileType + "";
            //saveFileDialog.FileName = filename;
            System.Windows.Forms.DialogResult dialogResult = OpenFileDialog.ShowDialog();
            if (dialogResult == System.Windows.Forms.DialogResult.OK)
            {
                return OpenFileDialog.FileName;
            }
            else return null;
        }
    }
}
