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
                consoleTextBox.AppendText("未選擇來源路徑。" + Environment.NewLine);
                return;
            }
            if (string.IsNullOrEmpty(TxtSelectDestinationPath.Text))
            {
                consoleTextBox.AppendText("未選擇目標路徑。" + Environment.NewLine);
                return;
            }

            // 判斷選擇的選項是否為空
            if (listBoxFileExtension.SelectedItems.Count == 0)
            {
                consoleTextBox.AppendText("未選擇副檔名。" + Environment.NewLine);
                return;
            }

            // 選擇來源路徑：
            string sourcePath = TxtSelectSourcePath.Text;

            // 選擇目標路徑：
            string destPath = TxtSelectDestinationPath.Text;

            List<string> listFileExtension = new List<string>();
            foreach (var item in listBoxFileExtension.SelectedItems)
            {
                listFileExtension.Add(item.ToString());
            }

            // 是否要刪除原檔案路徑的資料：
            bool IsDeleteSource = chkRemove.Checked;

            if (!Directory.Exists(sourcePath))
            {
                consoleTextBox.AppendText("來源路徑不存在！" + Environment.NewLine);
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
                        consoleTextBox.AppendText($"複製檔案 {fileName} 時出錯：{ex.Message}" + Environment.NewLine);
                    }
                }
                consoleTextBox.AppendText($"已成功複製 {copiedCount} 個 {fileExtension} 檔案至 {targetDir}" + Environment.NewLine);
            }

        }
    }
}