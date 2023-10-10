namespace WF_FileClassification
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSelectSrc = new Button();
            TxtSelectSourcePath = new TextBox();
            TxtSelectDestinationPath = new TextBox();
            btnSelectDst = new Button();
            btnRun = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            consoleTextBox = new TextBox();
            chkRemove = new CheckBox();
            listBoxFileExtension = new ListBox();
            SuspendLayout();
            // 
            // btnSelectSrc
            // 
            btnSelectSrc.Location = new Point(445, 26);
            btnSelectSrc.Name = "btnSelectSrc";
            btnSelectSrc.Size = new Size(79, 33);
            btnSelectSrc.TabIndex = 0;
            btnSelectSrc.Text = "Src Select";
            btnSelectSrc.UseVisualStyleBackColor = true;
            btnSelectSrc.Click += btnSelectSrcPath_Click;
            // 
            // TxtSelectSourcePath
            // 
            TxtSelectSourcePath.Font = new Font("微軟正黑體", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtSelectSourcePath.Location = new Point(142, 26);
            TxtSelectSourcePath.Name = "TxtSelectSourcePath";
            TxtSelectSourcePath.ReadOnly = true;
            TxtSelectSourcePath.Size = new Size(273, 33);
            TxtSelectSourcePath.TabIndex = 2;
            // 
            // TxtSelectDestinationPath
            // 
            TxtSelectDestinationPath.Font = new Font("微軟正黑體", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtSelectDestinationPath.Location = new Point(142, 89);
            TxtSelectDestinationPath.Name = "TxtSelectDestinationPath";
            TxtSelectDestinationPath.ReadOnly = true;
            TxtSelectDestinationPath.Size = new Size(273, 33);
            TxtSelectDestinationPath.TabIndex = 3;
            // 
            // btnSelectDst
            // 
            btnSelectDst.Location = new Point(445, 89);
            btnSelectDst.Name = "btnSelectDst";
            btnSelectDst.Size = new Size(79, 33);
            btnSelectDst.TabIndex = 4;
            btnSelectDst.Text = "Dst Select";
            btnSelectDst.UseVisualStyleBackColor = true;
            btnSelectDst.Click += btnSelectDstPath_Click;
            // 
            // btnRun
            // 
            btnRun.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnRun.Location = new Point(214, 367);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(116, 76);
            btnRun.TabIndex = 5;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微軟正黑體", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(40, 29);
            label1.Name = "label1";
            label1.Size = new Size(86, 24);
            label1.TabIndex = 10;
            label1.Text = "來源路徑";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("微軟正黑體", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(40, 92);
            label2.Name = "label2";
            label2.Size = new Size(86, 24);
            label2.TabIndex = 11;
            label2.Text = "目標路徑";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("微軟正黑體", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(21, 185);
            label3.Name = "label3";
            label3.Size = new Size(105, 24);
            label3.TabIndex = 12;
            label3.Text = "選擇副檔名";
            // 
            // consoleTextBox
            // 
            consoleTextBox.BackColor = SystemColors.InfoText;
            consoleTextBox.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            consoleTextBox.ForeColor = SystemColors.Window;
            consoleTextBox.Location = new Point(242, 185);
            consoleTextBox.Multiline = true;
            consoleTextBox.Name = "consoleTextBox";
            consoleTextBox.Size = new Size(289, 170);
            consoleTextBox.TabIndex = 13;
            // 
            // chkRemove
            // 
            chkRemove.AutoSize = true;
            chkRemove.Font = new Font("微軟正黑體", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            chkRemove.Location = new Point(47, 139);
            chkRemove.Name = "chkRemove";
            chkRemove.Size = new Size(257, 28);
            chkRemove.TabIndex = 14;
            chkRemove.Text = "是否刪除原路徑的原始檔案";
            chkRemove.UseVisualStyleBackColor = true;
            // 
            // listBoxFileExtension
            // 
            listBoxFileExtension.FormattingEnabled = true;
            listBoxFileExtension.ItemHeight = 15;
            listBoxFileExtension.Items.AddRange(new object[] { ".mkv", ".xls", ".doc", ".txt" });
            listBoxFileExtension.Location = new Point(132, 185);
            listBoxFileExtension.MultiColumn = true;
            listBoxFileExtension.Name = "listBoxFileExtension";
            listBoxFileExtension.SelectionMode = SelectionMode.MultiSimple;
            listBoxFileExtension.Size = new Size(80, 79);
            listBoxFileExtension.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 455);
            Controls.Add(listBoxFileExtension);
            Controls.Add(chkRemove);
            Controls.Add(consoleTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRun);
            Controls.Add(btnSelectDst);
            Controls.Add(TxtSelectDestinationPath);
            Controls.Add(TxtSelectSourcePath);
            Controls.Add(btnSelectSrc);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelectSrc;
        private TextBox TxtSelectSourcePath;
        private TextBox TxtSelectDestinationPath;
        private Button btnSelectDst;
        private Button btnRun;
        private ComboBox cbFileExtension;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox consoleTextBox;
        private CheckBox chkRemove;
        private ListBox listBoxFileExtension;
    }
}