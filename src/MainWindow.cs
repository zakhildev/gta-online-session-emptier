using GTA_Online_Session_Emptier.src.utils;
using System;
using System.Diagnostics;

namespace GTA_Online_Session_Emptier
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            bool foundFlag = false;
            foreach (var process in Process.GetProcesses())
            {
                procNameLabel.Text = process.ProcessName + ".exe";
                procPidLabel.Text = process.Id.ToString();

                if (process.ProcessName == "GTA5")
                {
                    foundFlag = true;
                    stateLabel.Text = "GTA 5 process found!";
                    emptyBtn.Enabled = true;
                    break;
                }
            }

            if (!foundFlag)
            {
                procNameLabel.Text = "N/A";
                procPidLabel.Text = "N/A";
                stateLabel.Text = "Process not found! Rescan using button below...";
            }

            scanBtn.Text = "Rescan";
            scanBtn.Enabled = true;
        }

        private async void EmptyBtn_Click(object sender, EventArgs e)
        {
            emptyBtn.Enabled = false;
            stateLabel.Text = "Emptying session... The game WILL lag for a bit!";
            var gamePid = int.Parse(procPidLabel.Text);
            await EmptySession.Empty(gamePid);
            stateLabel.Text = "Session has been emptied!";
            emptyBtn.Enabled = true;
        }

        private void ScanBtn_Click(object sender, EventArgs e)
        {
            stateLabel.Text = "Looking for GTA 5 process...";
            scanBtn.Enabled = false;
            emptyBtn.Enabled = false;
            procPidLabel.Text = "N/A";
            procNameLabel.Text = "N/A";
            scanBtn.Text = "Scanning...";
            MainWindow_Load(sender, e);
        }
    }
}
