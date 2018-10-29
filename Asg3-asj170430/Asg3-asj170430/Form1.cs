using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asg3_asj170430
{
    public partial class Form1 : Form
    {
        //Openfiledialog to open file menu
        OpenFileDialog dialog = new OpenFileDialog();
        DataOperator dataOperate = new DataOperator();
        string filePath = "";
        string lableMessage = "Select File to be evaluted";

        //initialize form
        public Form1()
        {
            InitializeComponent();
            messageLabel.Text = lableMessage;
        }

        //open file button with txt file filter to select the file 
        private void openFileBtn_Click(object sender, EventArgs e)
        {
            dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
                filePathBox.Text = filePath;
                messageLabel.Text = "Path set correctly. Try Evaluating";
                messageLabel.ForeColor = Color.Orange;
                
            }
        }

        //evaluate button click 
        private void button1_Click(object sender, EventArgs e)
        {
            //evaluate btn
            if(filePathBox.Text == "")
            {
                MessageBox.Show("Please Select File and Proceed");
            }
            else
            {
                //evaluate data andwrite it into the data
                GetterSetterClass data = dataOperate.evaluateFile(filePath);
                bool isWritten = false;
                isWritten = dataOperate.writeFile("CS6326Asg3.txt", data);
                if (isWritten)
                {
                    string output = "The Number of records : " + data.totalRecords + "\n"
                      + "\n Minimum Entry Time: " + data.entryTimeMin.ToString(@"mm\:ss") + "\n"
                      + "\n Maximum Entry Time: " + data.entryTimeMax.ToString(@"mm\:ss") + "\n"
                      + "\n Average Entry Time: " + data.entryTimeAvg.ToString(@"mm\:ss") + "\n"
                      + "\n Minimum Between Time: " + data.betweenTimeMin.ToString(@"mm\:ss") + "\n"
                      + "\n Maximum Between Time: " + data.betweenTimeMax.ToString(@"mm\:ss") + "\n"
                      + "\n Average Between Time: " + data.betweenTimeAvg.ToString(@"mm\:ss") + "\n"
                      + "\n Total Time: " + data.timeTotal.ToString(@"mm\:ss") + "\n"
                      + "\n Total backspaces Count: " + data.backSpaceCount + "\n";

                    evaluationBox.Text = output;
                    messageLabel.Text = "data Evaluated successfully!";
                    messageLabel.ForeColor = Color.Green;
                }
                else
                {
                    messageLabel.Text = "Error writing data into File. Try again";
                    messageLabel.ForeColor = Color.Red;
                }
            }

        }

        //clear data button click
        private void button2_Click(object sender, EventArgs e)
        {
            //clear data btn
            messageLabel.Text = lableMessage;
            filePathBox.Text = "";
            evaluationBox.Text = "";
            messageLabel.ForeColor = Color.Black;
        }
    }
}
