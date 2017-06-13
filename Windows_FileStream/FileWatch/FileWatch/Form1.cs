using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FileWatch
{
    public partial class Form1 : Form
    {
        private FileSystemWatcher watcher;
        private delegate void updateWatchTextDelegate(string newText);

        public Form1()
        {
            InitializeComponent();

            watcher = new System.IO.FileSystemWatcher();
            watcher.Deleted += new FileSystemEventHandler(this.OnDelete);  //为4个事件委托指定事件处理函数
            watcher.Renamed += new RenamedEventHandler(this.OnRenamed);
            watcher.Changed += new FileSystemEventHandler(this.OnChanged);
            watcher.Created += new FileSystemEventHandler(this.OnCreate);
        }

        public void UpdateWatchText(string newText)
        {
            lblWatch.Text = newText;
        }

        public void OnChanged(object source, FileSystemEventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter("../../../Log.txt", true);
                sw.WriteLine("File: {0} {1}", e.FullPath, e.ChangeType.ToString());
                sw.Close();
                this.BeginInvoke(new updateWatchTextDelegate(UpdateWatchText), "Wrote change event to log");
            }
            catch (IOException)
            {
                this.BeginInvoke(new updateWatchTextDelegate(UpdateWatchText), "Error Writing to log");
            }
        }

        public void OnRenamed(object source, RenamedEventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter("../../../Log.txt", true);
                sw.WriteLine("File renamed form {0} to {1}", e.OldName, e.FullPath);
                sw.Close();
                this.BeginInvoke(new updateWatchTextDelegate(UpdateWatchText), "Wrote renamed event to log");
            }
            catch (IOException)
            {
                this.BeginInvoke(new updateWatchTextDelegate(UpdateWatchText), "Error Writing to log");
            }
        }

        public void OnDelete(object source, FileSystemEventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter("../../../Log.txt", true);
                sw.WriteLine("File: {0} Delete", e.FullPath);
                sw.Close();
                this.BeginInvoke(new updateWatchTextDelegate(UpdateWatchText), "Wrote delete event to log");
            }
            catch (IOException)
            {
                this.BeginInvoke(new updateWatchTextDelegate(UpdateWatchText), "Error Writing to log");
            }
        }

        public void OnCreate(object source, FileSystemEventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter("../../../Log.txt", true);
                sw.WriteLine("File: {0} Created", e.FullPath);
                sw.Close();
                this.BeginInvoke(new updateWatchTextDelegate(UpdateWatchText), "Wrote create event to log");
            }
            catch (IOException)
            {
                this.BeginInvoke(new updateWatchTextDelegate(UpdateWatchText), "Error Writing to log");
            }
        }

        private void cmdBrowse_Click(object sender, EventArgs e)
        {
            if (FileDialog.ShowDialog() != DialogResult.Cancel)
            {
                txtLocation.Text = FileDialog.FileName;
                cmdWatch.Enabled = true;
            }
        }

        private void cmdWatch_Click(object sender, EventArgs e)
        {
            watcher.Path = Path.GetDirectoryName(txtLocation.Text);  //指定FileSystemWatcher的3个必要属性和EnableRaisingEvents属性
            watcher.Filter = Path.GetFileName(txtLocation.Text);
            watcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.Size;
            lblWatch.Text = "Watching " + txtLocation.Text;
            watcher.EnableRaisingEvents = true;
        }
    }
}
