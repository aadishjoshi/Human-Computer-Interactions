namespace asj170430Asg4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.filePathBox = new System.Windows.Forms.TextBox();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Line = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.selectFile = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "File Path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Search key";
            // 
            // filePathBox
            // 
            this.filePathBox.Location = new System.Drawing.Point(79, 40);
            this.filePathBox.Name = "filePathBox";
            this.filePathBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.filePathBox.Size = new System.Drawing.Size(383, 20);
            this.filePathBox.TabIndex = 3;
            // 
            // searchBar
            // 
            this.searchBar.Location = new System.Drawing.Point(79, 75);
            this.searchBar.Name = "searchBar";
            this.searchBar.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.searchBar.Size = new System.Drawing.Size(383, 20);
            this.searchBar.TabIndex = 4;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Num,
            this.Line});
            this.listView1.Location = new System.Drawing.Point(15, 137);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(528, 254);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Num
            // 
            this.Num.Text = "Number";
            this.Num.Width = 54;
            // 
            // Line
            // 
            this.Line.Text = "Lines";
            this.Line.Width = 468;
            // 
            // selectFile
            // 
            this.selectFile.Location = new System.Drawing.Point(468, 38);
            this.selectFile.Name = "selectFile";
            this.selectFile.Size = new System.Drawing.Size(75, 23);
            this.selectFile.TabIndex = 6;
            this.selectFile.Text = "Select File";
            this.selectFile.UseVisualStyleBackColor = true;
            this.selectFile.Click += new System.EventHandler(this.selectFile_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(468, 73);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 7;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(229, 9);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 13);
            this.messageLabel.TabIndex = 8;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(232, 397);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 9;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(468, 73);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 10;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.MediumOrchid;
            this.progressBar.Location = new System.Drawing.Point(15, 112);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(528, 10);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 427);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.selectFile);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.filePathBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Search Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox filePathBox;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button selectFile;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ColumnHeader Num;
        private System.Windows.Forms.ColumnHeader Line;
    }
}

