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

                    // �N�줸���ഫ����L���A�ҦpGB
                    double totalSizeInGB = ConvertBytesToGB(totalSizeInBytes);
                    double availableSpaceInGB = ConvertBytesToGB(availableSpaceInBytes);
                    double totalFreeSpaceInGB = ConvertBytesToGB(totalFreeSpaceInBytes);
                    TbConsole.AppendText($"�Ϻ�({driveInfo.Name}):" + Environment.NewLine);
                    TbConsole.AppendText($"�`�j�p: {totalSizeInGB} GB" + Environment.NewLine);
                    TbConsole.AppendText($"�i�ΪŶ�: {availableSpaceInGB} GB" + Environment.NewLine);
                    TbConsole.AppendText($"�`�Ѿl�Ŷ�: {totalFreeSpaceInGB} GB" + Environment.NewLine);
                    
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