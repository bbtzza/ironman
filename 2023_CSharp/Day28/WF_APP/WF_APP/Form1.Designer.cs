namespace WF_APP
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
            btnRun = new Button();
            TbConsole = new TextBox();
            SuspendLayout();
            // 
            // btnRun
            // 
            btnRun.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRun.Location = new Point(133, 341);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(103, 60);
            btnRun.TabIndex = 0;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // TbConsole
            // 
            TbConsole.BackColor = SystemColors.InfoText;
            TbConsole.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TbConsole.ForeColor = SystemColors.Window;
            TbConsole.Location = new Point(72, 69);
            TbConsole.Multiline = true;
            TbConsole.Name = "TbConsole";
            TbConsole.Size = new Size(288, 156);
            TbConsole.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TbConsole);
            Controls.Add(btnRun);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRun;
        private TextBox TbConsole;
    }
}