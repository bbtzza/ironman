using System.Text;

namespace WF_FileClassification
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string GetFolderPath()
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    return folderBrowserDialog.SelectedPath;
                }
                return null;
            }
        }

        private void btnSelectSrcPath_Click(object sender, EventArgs e)
        {

            TxtSelectSourcePath.Text = GetFolderPath();
        }

        private void btnSelectDstPath_Click(object sender, EventArgs e)
        {

            TxtSelectDestinationPath.Text = GetFolderPath();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            consoleTextBox.Text = string.Empty;
            if (string.IsNullOrEmpty(TxtSelectSourcePath.Text))
            {
                consoleTextBox.AppendText("����ܨӷ����|�C" + Environment.NewLine);
                return;
            }
            if (string.IsNullOrEmpty(TxtSelectDestinationPath.Text))
            {
                consoleTextBox.AppendText("����ܥؼи��|�C" + Environment.NewLine);
                return;
            }

            // �P�_��ܪ��ﶵ�O�_����
            if (listBoxFileExtension.SelectedItems.Count == 0)
            {
                consoleTextBox.AppendText("����ܰ��ɦW�C" + Environment.NewLine);
                return;
            }

            // ��ܨӷ����|�G
            string sourcePath = TxtSelectSourcePath.Text;

            // ��ܥؼи��|�G
            string destPath = TxtSelectDestinationPath.Text;

            List<string> listFileExtension = new List<string>();
            foreach (var item in listBoxFileExtension.SelectedItems)
            {
                listFileExtension.Add(item.ToString());
            }

            // �O�_�n�R�����ɮ׸��|����ơG
            bool IsDeleteSource = chkRemove.Checked;

            if (!Directory.Exists(sourcePath))
            {
                consoleTextBox.AppendText("�ӷ����|���s�b�I" + Environment.NewLine);
                return;
            }

            if (!Directory.Exists(destPath))
            {
                Directory.CreateDirectory(destPath);
            }
            foreach (string fileExtension in listFileExtension)
            {
                string targetDir = Path.Combine(destPath, fileExtension.TrimStart('.'));
                Directory.CreateDirectory(targetDir);

                string[] filesToCopy = Directory.GetFiles(sourcePath, $"*{fileExtension}");
                int copiedCount = 0;

                foreach (string filePath in filesToCopy)
                {
                    string fileName = Path.GetFileName(filePath);
                    string destFilePath = Path.Combine(targetDir, fileName);

                    try
                    {
                        File.Copy(filePath, destFilePath, true);

                        if (File.Exists(destFilePath))
                        {
                            FileInfo sourceFileInfo = new FileInfo(filePath);
                            FileInfo destFileInfo = new FileInfo(destFilePath);

                            if (sourceFileInfo.Length == destFileInfo.Length)
                            {
                                copiedCount++;
                            }
                        }

                        if (IsDeleteSource)
                        {
                            File.Delete(filePath);
                        }
                    }
                    catch (Exception ex)
                    {
                        consoleTextBox.AppendText($"�ƻs�ɮ� {fileName} �ɥX���G{ex.Message}" + Environment.NewLine);
                    }
                }
                consoleTextBox.AppendText($"�w���\�ƻs {copiedCount} �� {fileExtension} �ɮצ� {targetDir}" + Environment.NewLine);
            }

        }
    }
}