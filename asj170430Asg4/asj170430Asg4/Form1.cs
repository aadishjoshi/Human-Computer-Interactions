using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asj170430Asg4
{
    public partial class Form1 : Form
    {
        OpenFileDialog dialog = new OpenFileDialog();
        string filePath = "";
        string searchQuery = "";
        string labelMessage = "Select File to be evaluted";
        private BackgroundWorker worker;
        int totalLines = 0;
        double size;

        public Form1()
        {
            InitializeComponent();
            progressBar.Value = 0;
            progressBar.Step = 1;
            messageLabel.Text = labelMessage;
            searchBar.Enabled = false;
            cancelBtn.Enabled = false;
            cancelBtn.Visible = false;
        }
        private void InitBGWorker()
        {
            if(worker != null)
            {
                worker.Dispose();
            }
            worker = new BackgroundWorker {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };

            worker.DoWork += DoWork;
            worker.RunWorkerCompleted += RunWorkerCompleted;
            worker.ProgressChanged += ProgressChanged;
            worker.RunWorkerAsync();

        }

        private void DoWork(object sender,DoWorkEventArgs e)
        {
            try
            {
                using(StreamReader reader = new StreamReader(filePath))
                {
                    string record = reader.ReadLine();
                    while(record != null)
                    {
                        totalLines++;
                        if (record.Contains(searchQuery))
                        {
                            System.Threading.Thread.Sleep(1000);
                            worker.ReportProgress(totalLines, record);
                        }
                        record = reader.ReadLine();

                        if(worker.CancellationPending == true)
                        {
                            e.Cancel = true;
                            return;
                        }
                    }
                   
                }
            }
            catch (Exception e11)
            {
                MessageBox.Show("Error in searching!"+e11.ToString());
            }
        }

        private void RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            searchBtn.Visible = false;
            clearBtn.Enabled = true;
            cancelBtn.Visible = false;
            cancelBtn.Enabled = false;
            if (e.Cancelled)
            {
                messageLabel.ForeColor = Color.Red;
                messageLabel.Text = "Search cancelled!";

            }
            else
            {
                progressBar.Value = progressBar.Maximum;
                messageLabel.ForeColor = Color.Green;
                messageLabel.Text = "Search Completed!";
            }
            
        }

        private void ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.PerformStep();
            ListViewItem result = new ListViewItem(new string[] { e.ProgressPercentage.ToString(), e.UserState.ToString() });
            listView1.Items.Add(result);
            listView1.View = View.Details;
            this.listView1.AutoResizeColumns(System.Windows.Forms.ColumnHeaderAutoResizeStyle.ColumnContent);
            this.listView1.AutoResizeColumns(System.Windows.Forms.ColumnHeaderAutoResizeStyle.HeaderSize);
            this.Text = e.ProgressPercentage.ToString();
        }

        private void selectFile_Click(object sender, EventArgs e)
        {
            dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
                size = new FileInfo(dialog.FileName).Length;
                progressBar.Maximum = Convert.ToInt32(size);
                filePathBox.Text = filePath;
                messageLabel.Text = "Path set correctly. Try Evaluating";
                messageLabel.ForeColor = Color.Orange;
            }
            searchBar.Enabled = true;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            cancelBtn.Visible = false;
            cancelBtn.Enabled = false;
            searchBar.Visible = true;
            searchBtn.Visible = true;
            filePath = "";
            filePathBox.Text = "";
            searchBar.Text = "";
            listView1.Clear();
            messageLabel.Text = labelMessage;
            progressBar.Value = 0;
            messageLabel.ForeColor = Color.Black;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            searchQuery = searchBar.Text;
            if(searchQuery == "")
            {
                messageLabel.Text = "Please give a valid search query";
                messageLabel.ForeColor = Color.Red;
            }
            else
            {
                searchBar.Visible = false;
                cancelBtn.Visible = true;
                cancelBtn.Enabled = true;
                clearBtn.Enabled = false;
                messageLabel.Text = "Searching...!";
                messageLabel.ForeColor = Color.BlueViolet;
                InitBGWorker();
            }
            

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            searchBar.Visible = true;
            cancelBtn.Visible = false;
            clearBtn.Enabled = true;
            worker.CancelAsync();
            worker.Dispose();
            messageLabel.Text = "Cancelled!";
            messageLabel.ForeColor = Color.Red;

        }

       

    }
}
