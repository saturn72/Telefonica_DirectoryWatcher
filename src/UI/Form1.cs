using System;
using System.Windows.Forms;
using Common.Services;
using Core.DependencyManagement;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWatchedDir_Click(object sender, EventArgs e)
        {
            SetDirectory(txtBoxWatchedDir);
        }
        private void btnDestDir_Click(object sender, EventArgs e)
        {
            SetDirectory(txtDestDir);
        }

        private void SetDirectory(TextBox textBox)
        {
            var fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() != DialogResult.OK)
            {
                btnStartWatch.Enabled = false;
                btnStopWatch.Enabled = false;
                return;
            }

            textBox.Text = fbd.SelectedPath;
            if (!string.IsNullOrEmpty(txtBoxWatchedDir.Text) && !string.IsNullOrEmpty(txtDestDir.Text))
                SetButtons(true);
        }

        private void btnStartWatch_Click(object sender, EventArgs e)
        {
            var watchService = Ioc.Resolve<IWatchService>();
            watchService.StartWatch(txtBoxWatchedDir.Text, txtDestDir.Text);

            SetButtons(false);
        }

      

        private void btnStopWatch_Click(object sender, EventArgs e)
        {
            var watchService = Ioc.Resolve<IWatchService>();
            watchService.StopWatch();

            SetButtons(true);
        }

        private void SetButtons(bool isWatching)
        {
            btnWatchedDir.Enabled = isWatching;
            btnDestDir.Enabled = isWatching;
            btnStartWatch.Enabled = isWatching;
            btnStopWatch.Enabled = !isWatching;
        }

    
    }
}