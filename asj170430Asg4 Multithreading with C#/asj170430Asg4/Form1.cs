/*********************************************************************************************************************
 * 
 * MULTI-THREADED TEXT SEARCH PROGRAM
 * ASSIGNMENT 04
 * 
 * The purpose of this program was to write a multithreaded program that searches a text file for a string. 
 * Also it must find all occurrences of the string and show them in a list.
 * 
 * 
 * Netid: asj170430
 * First Name:  Aadish
 * Middle Name: Santosh
 * Last Name:   Joshi
 * 
 * Additional feature:
 * Clear button is provided to wipe out all the search content.
 * 
 * Instructions:
 * 1) Select the file using select file button. By default it is set to filter out any files other than text or .txt
 * 2) Give a search query in query box. if remained empty, it will display empty message. else proceeds the search.
 * 3) You can terminate the search inbetween.
 * 4) Progressbar is provided to display search progress as per the line evaluation.
 * 
 * Written by Aadish Joshi (asj170430) at The University of Texas at Dallas
 * Starting Aug'21, 2018
**********************************************************************************************************************/

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
        // Global varibles are set so could be accessed from different functions as well. 
        OpenFileDialog dialog = new OpenFileDialog();
        private BackgroundWorker worker;
        int totalLines;
        double size;
        int pbMaxiumum;
        string filePath;
        string searchQuery;
        string labelMessage = "Select File to be evaluted";

        /**************************************************************************
         * Form1 is a main constructor
        **************************************************************************/
        public Form1()
        {
            InitializeComponent();
            reload();
        }

        /**************************************************************************
         * Reload function clears the data field and sets all values to defaults;
        **************************************************************************/
        public void reload()
        {
            totalLines = 0;
            pbMaxiumum = 0;
            filePath = "";
            searchQuery = "";
            messageLabel.Text = labelMessage;
            searchBar.Enabled = false;
            cancelBtn.Enabled = false;
            cancelBtn.Visible = false;
        }

        /**************************************************************************
         * BackgroundWorker constuctor. for multithreading purpose
         * BackgroundWorker worker = new BackgroundWorker (true [for reporing process],true[for cancellation support])
         * backgroundWorker methods are redeclaired such as dowork, runworkcompleted, progresschanged, and runworkerAsync();
        **************************************************************************/
        private void BGConstructor()
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

        /**************************************************************************
        * DoWork method of the backgroundworker class.
        * searches the string result and if found match reports progress to Progresschanged.
        * I am returning linenumber and string data through ReportProgress method of the worker
        * 1000 ms delay is provided
        **************************************************************************/
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

        /**************************************************************************
        * RunWorkerCompleted(sender, e)
        * when the execution is completed or cancelled this method is triggered.
        **************************************************************************/
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
                messageLabel.ForeColor = Color.Green;
                progressBar.Value = pbMaxiumum;
                if (listView1.Items.Count == 0)
                {
                    messageLabel.Text = "Match not found!";
                }
                else
                {
                    messageLabel.Text = "Search Completed!";
                }
                
            }
            
        }
        /**************************************************************************
        * ProgressChanged(sender,e) catches worker.ReportProgress method call.
        * Listview adds item.
        * ProgressBar value grows with 1 step.
        * ListView columns and headers are made autoadjustable
        **************************************************************************/
        private void ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
            ListViewItem result = new ListViewItem(new string[] { e.ProgressPercentage.ToString(), e.UserState.ToString() });
            listView1.Items.Add(result);
            listView1.View = View.Details;
            if (progressBar.Value != progressBar.Maximum)
            {
                progressBar.PerformStep();
            }
            this.listView1.AutoResizeColumns(System.Windows.Forms.ColumnHeaderAutoResizeStyle.ColumnContent);
            this.listView1.AutoResizeColumns(System.Windows.Forms.ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        /**************************************************************************
        * SelectFile btn click class 
        * filters all the files except txt files
        * Progressbar size is allocated to maximum with the help of size of the file
        **************************************************************************/
        private void selectFile_Click(object sender, EventArgs e)
        {
            dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
                size = new FileInfo(dialog.FileName).Length;
                pbMaxiumum = (Convert.ToInt32(size) / 1000);
                filePathBox.Text = filePath;
                messageLabel.Text = "Path set correctly. Try Evaluating";
                messageLabel.ForeColor = Color.Orange;
            }
            searchBar.Enabled = true;
        }

        /**************************************************************************
        * ClearBtn is a clearbutton click handler
        * reload function iscalled again to set it to default
        **************************************************************************/
        private void clearBtn_Click(object sender, EventArgs e)
        {
            filePath = "";
            filePathBox.Text = "";
            searchBar.Text = "";
            progressBar.Value = 0;
            listView1.Clear();
            cancelBtn.Visible = false;
            cancelBtn.Enabled = false;
            searchBar.Visible = true;
            searchBtn.Visible = true;
            messageLabel.Text = labelMessage;
            messageLabel.ForeColor = Color.Black;
            reload();
        }

        /**************************************************************************
        * searchBtn is a searchBtn click handler
        * Validates if the search query is null if so, displays error message
        * else BackgroundWorker constructor is called
        **************************************************************************/
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
                messageLabel.Text = "Searching...";
                messageLabel.ForeColor = Color.BlueViolet;
                progressBar.Maximum = pbMaxiumum;
                progressBar.Value = 0;
                progressBar.Step = 1;
                BGConstructor();

            }
            

        }

        /**************************************************************************
        * cancelBtn is a cancelButton click handler
        * worker.CancelAsync() trigger the cancels event handle
        * The current backgroundworker is disposed.
        **************************************************************************/
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
