using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieOrganizer_2Leggo.Folder
{
    class FolderDestination
    {

        public List<string> GetFolderNames()
        {
            List<string> folderList = new List<string>();
           var folders =  Directory.GetDirectories(Properties.Settings.Default.BaseFolder, "*", SearchOption.TopDirectoryOnly);
            foreach (var folder in folders)
            {
              folderList.Add(Path.GetFileName(folder));
            }
            
            return folderList;
        }

        public void ChooseBaseFolder()
        {
            FolderBrowserDialog Dialog = new FolderBrowserDialog();
            DialogResult Result = Dialog.ShowDialog();
            if (Result == DialogResult.OK)
            {
                Properties.Settings.Default.BaseFolder = Dialog.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

    }
}
