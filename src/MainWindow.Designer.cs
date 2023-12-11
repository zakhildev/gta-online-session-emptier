namespace GTA_Online_Session_Emptier
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            stateLabel = new Label();
            emptyBtn = new Button();
            label2 = new Label();
            label3 = new Label();
            procNameLabel = new Label();
            procPidLabel = new Label();
            scanBtn = new Button();
            SuspendLayout();
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new Point(12, 9);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new Size(153, 15);
            stateLabel.TabIndex = 0;
            stateLabel.Text = "Looking for GTA 5 process...\r\n";
            // 
            // emptyBtn
            // 
            emptyBtn.Enabled = false;
            emptyBtn.Location = new Point(12, 113);
            emptyBtn.Name = "emptyBtn";
            emptyBtn.Size = new Size(283, 23);
            emptyBtn.TabIndex = 1;
            emptyBtn.Text = "Empty session";
            emptyBtn.UseVisualStyleBackColor = true;
            emptyBtn.Click += EmptyBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 34);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 2;
            label2.Text = "Process name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 59);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 3;
            label3.Text = "PID:";
            // 
            // procNameLabel
            // 
            procNameLabel.AutoSize = true;
            procNameLabel.Location = new Point(101, 34);
            procNameLabel.Name = "procNameLabel";
            procNameLabel.Size = new Size(29, 15);
            procNameLabel.TabIndex = 4;
            procNameLabel.Text = "N/A";
            // 
            // procPidLabel
            // 
            procPidLabel.AutoSize = true;
            procPidLabel.Location = new Point(101, 59);
            procPidLabel.Name = "procPidLabel";
            procPidLabel.Size = new Size(29, 15);
            procPidLabel.TabIndex = 5;
            procPidLabel.Text = "N/A";
            // 
            // scanBtn
            // 
            scanBtn.Enabled = false;
            scanBtn.Location = new Point(13, 84);
            scanBtn.Name = "scanBtn";
            scanBtn.Size = new Size(282, 23);
            scanBtn.TabIndex = 6;
            scanBtn.Text = "Scanning...";
            scanBtn.UseVisualStyleBackColor = true;
            scanBtn.Click += ScanBtn_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 148);
            Controls.Add(scanBtn);
            Controls.Add(procPidLabel);
            Controls.Add(procNameLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(emptyBtn);
            Controls.Add(stateLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainWindow";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "GTA Online Session Emptier by Zakhil";
            Load += MainWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label stateLabel;
        private Button emptyBtn;
        private Label label2;
        private Label label3;
        private Label procNameLabel;
        private Label procPidLabel;
        private Button scanBtn;
    }
}
