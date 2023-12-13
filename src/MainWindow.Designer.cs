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
            resources.ApplyResources(stateLabel, "stateLabel");
            stateLabel.Name = "stateLabel";
            // 
            // emptyBtn
            // 
            resources.ApplyResources(emptyBtn, "emptyBtn");
            emptyBtn.Name = "emptyBtn";
            emptyBtn.UseVisualStyleBackColor = true;
            emptyBtn.Click += EmptyBtn_Click;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // procNameLabel
            // 
            resources.ApplyResources(procNameLabel, "procNameLabel");
            procNameLabel.Name = "procNameLabel";
            // 
            // procPidLabel
            // 
            resources.ApplyResources(procPidLabel, "procPidLabel");
            procPidLabel.Name = "procPidLabel";
            // 
            // scanBtn
            // 
            resources.ApplyResources(scanBtn, "scanBtn");
            scanBtn.Name = "scanBtn";
            scanBtn.UseVisualStyleBackColor = true;
            scanBtn.Click += ScanBtn_Click;
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(scanBtn);
            Controls.Add(procPidLabel);
            Controls.Add(procNameLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(emptyBtn);
            Controls.Add(stateLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainWindow";
            SizeGripStyle = SizeGripStyle.Hide;
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
