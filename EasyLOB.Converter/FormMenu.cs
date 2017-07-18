using System;
using System.IO;
using System.Windows.Forms;

namespace EasyLOB_Converter
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonModel_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                // Directory
                //     CollectionsModels
                //     ItemModels
                //     ViewModels

                string root = folderBrowserDialog.SelectedPath;
                Convert(root, "CollectionModel");
                Convert(root, "ItemModel");
                Convert(root, "ViewModel");
            }
        }

        private void Convert(string root, string pattern)
        {
            string source = Path.Combine(root, pattern + "s");
            if (Directory.Exists(source))
            {
                pattern = pattern + ".cs";
                foreach (string files in Directory.GetFiles(source, "*" + pattern))
                {
                    FileInfo fileInfo = new FileInfo(files);
                    string entity = fileInfo.Name.Replace(pattern, "");
                    string destination = Path.Combine(root, entity);
                    if (!Directory.Exists(destination))
                    {
                        Directory.CreateDirectory(destination);
                    }
                    fileInfo.MoveTo(string.Format(@"{0}\{1}", destination, fileInfo.Name));
                }
            }
        }
    }
}
