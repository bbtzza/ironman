namespace WF_APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showDisk()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo driveInfo in allDrives)
            {
                if (driveInfo.IsReady)
                {
                    long totalSizeInBytes = driveInfo.TotalSize;
                    long availableSpaceInBytes = driveInfo.AvailableFreeSpace;
                    long totalFreeSpaceInBytes = driveInfo.TotalFreeSpace;

                    // 將位元組轉換為其他單位，例如GB
                    double totalSizeInGB = ConvertBytesToGB(totalSizeInBytes);
                    double availableSpaceInGB = ConvertBytesToGB(availableSpaceInBytes);
                    double totalFreeSpaceInGB = ConvertBytesToGB(totalFreeSpaceInBytes);
                    TbConsole.AppendText($"磁碟({driveInfo.Name}):" + Environment.NewLine);
                    TbConsole.AppendText($"總大小: {totalSizeInGB} GB" + Environment.NewLine);
                    TbConsole.AppendText($"可用空間: {availableSpaceInGB} GB" + Environment.NewLine);
                    TbConsole.AppendText($"總剩餘空間: {totalFreeSpaceInGB} GB" + Environment.NewLine);
                    
                    Console.WriteLine();
                }
            }
        }
        double ConvertBytesToGB(long bytes)
        {
            return bytes / (1024.0 * 1024.0 * 1024.0);
        }


        private void btnRun_Click(object sender, EventArgs e)
        {
            showDisk();
        }
    }
}