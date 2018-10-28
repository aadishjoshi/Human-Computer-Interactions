namespace Asg2_asj170430
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
            this.fnameText = new System.Windows.Forms.TextBox();
            this.minitText = new System.Windows.Forms.TextBox();
            this.lnameText = new System.Windows.Forms.TextBox();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.address1Text = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.genderText = new System.Windows.Forms.TextBox();
            this.zipcodeText = new System.Windows.Forms.TextBox();
            this.cityText = new System.Windows.Forms.TextBox();
            this.listView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.address2Text = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.stateText = new System.Windows.Forms.TextBox();
            this.dateText = new System.Windows.Forms.TextBox();
            this.proofText = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.entireName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // fnameText
            // 
            this.fnameText.Location = new System.Drawing.Point(95, 23);
            this.fnameText.MaxLength = 20;
            this.fnameText.Name = "fnameText";
            this.fnameText.Size = new System.Drawing.Size(120, 20);
            this.fnameText.TabIndex = 0;
            this.fnameText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.fnameText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fnameText_KeyPress);
            // 
            // minitText
            // 
            this.minitText.Location = new System.Drawing.Point(279, 23);
            this.minitText.MaxLength = 1;
            this.minitText.Name = "minitText";
            this.minitText.Size = new System.Drawing.Size(32, 20);
            this.minitText.TabIndex = 1;
            this.minitText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.minitText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minitText_KeyPress);
            // 
            // lnameText
            // 
            this.lnameText.Location = new System.Drawing.Point(95, 62);
            this.lnameText.MaxLength = 20;
            this.lnameText.Name = "lnameText";
            this.lnameText.Size = new System.Drawing.Size(120, 20);
            this.lnameText.TabIndex = 2;
            this.lnameText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lnameText_KeyPress);
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(95, 140);
            this.phoneText.MaxLength = 21;
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(120, 20);
            this.phoneText.TabIndex = 5;
            this.phoneText.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.phoneText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneText_KeyPress);
            // 
            // address1Text
            // 
            this.address1Text.Location = new System.Drawing.Point(95, 180);
            this.address1Text.MaxLength = 35;
            this.address1Text.Name = "address1Text";
            this.address1Text.Size = new System.Drawing.Size(216, 20);
            this.address1Text.TabIndex = 6;
            this.address1Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.address1Text_KeyPress);
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(95, 105);
            this.emailText.MaxLength = 60;
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(216, 20);
            this.emailText.TabIndex = 4;
            this.emailText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.emailText_KeyPress);
            // 
            // genderText
            // 
            this.genderText.Location = new System.Drawing.Point(279, 62);
            this.genderText.MaxLength = 1;
            this.genderText.Name = "genderText";
            this.genderText.Size = new System.Drawing.Size(32, 20);
            this.genderText.TabIndex = 3;
            this.genderText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.genderText_KeyPress);
            // 
            // zipcodeText
            // 
            this.zipcodeText.Location = new System.Drawing.Point(95, 289);
            this.zipcodeText.MaxLength = 9;
            this.zipcodeText.Name = "zipcodeText";
            this.zipcodeText.Size = new System.Drawing.Size(100, 20);
            this.zipcodeText.TabIndex = 10;
            this.zipcodeText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.zipcodeText_KeyPress);
            // 
            // cityText
            // 
            this.cityText.Location = new System.Drawing.Point(95, 257);
            this.cityText.MaxLength = 25;
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(120, 20);
            this.cityText.TabIndex = 8;
            this.cityText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cityText_KeyPress);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.entireName,
            this.phoneNumber});
            this.listView.Location = new System.Drawing.Point(336, 62);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(259, 320);
            this.listView.TabIndex = 12;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.Click += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "First name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "M. Initial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 65);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Last name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Address Line 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Address line 2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "City";
            // 
            // address2Text
            // 
            this.address2Text.Location = new System.Drawing.Point(95, 220);
            this.address2Text.MaxLength = 35;
            this.address2Text.Name = "address2Text";
            this.address2Text.Size = new System.Drawing.Size(216, 20);
            this.address2Text.TabIndex = 7;
            this.address2Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.address2Text_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(237, 259);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "State";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 292);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Zipcode";
            // 
            // stateText
            // 
            this.stateText.Location = new System.Drawing.Point(279, 256);
            this.stateText.MaxLength = 2;
            this.stateText.Name = "stateText";
            this.stateText.Size = new System.Drawing.Size(32, 20);
            this.stateText.TabIndex = 9;
            this.stateText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stateText_KeyPress);
            // 
            // dateText
            // 
            this.dateText.Location = new System.Drawing.Point(95, 362);
            this.dateText.MaxLength = 10;
            this.dateText.Name = "dateText";
            this.dateText.Size = new System.Drawing.Size(100, 20);
            this.dateText.TabIndex = 12;
            this.dateText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateText_KeyPress);
            // 
            // proofText
            // 
            this.proofText.Location = new System.Drawing.Point(167, 324);
            this.proofText.MaxLength = 3;
            this.proofText.Name = "proofText";
            this.proofText.Size = new System.Drawing.Size(28, 20);
            this.proofText.TabIndex = 11;
            this.proofText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.proofText_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 327);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Is proof of purchase attached?";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 362);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Date received";
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.SystemColors.Control;
            this.deleteBtn.Location = new System.Drawing.Point(210, 395);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(63, 23);
            this.deleteBtn.TabIndex = 31;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // modifyBtn
            // 
            this.modifyBtn.BackColor = System.Drawing.SystemColors.Control;
            this.modifyBtn.Location = new System.Drawing.Point(129, 395);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(75, 23);
            this.modifyBtn.TabIndex = 32;
            this.modifyBtn.Text = "Modify";
            this.modifyBtn.UseVisualStyleBackColor = false;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(440, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "Data List";
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.SystemColors.Control;
            this.clearBtn.Location = new System.Drawing.Point(279, 395);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(63, 23);
            this.clearBtn.TabIndex = 34;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(48, 395);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 35;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // entireName
            // 
            this.entireName.Text = "entireName";
            this.entireName.Width = 88;
            // 
            // phoneNumber
            // 
            this.phoneNumber.Text = "PhoneNumber";
            this.phoneNumber.Width = 94;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 430);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.modifyBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.proofText);
            this.Controls.Add(this.dateText);
            this.Controls.Add(this.stateText);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.address2Text);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.cityText);
            this.Controls.Add(this.zipcodeText);
            this.Controls.Add(this.genderText);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.address1Text);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.lnameText);
            this.Controls.Add(this.minitText);
            this.Controls.Add(this.fnameText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fnameText;
        private System.Windows.Forms.TextBox minitText;
        private System.Windows.Forms.TextBox lnameText;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.TextBox address1Text;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox genderText;
        private System.Windows.Forms.TextBox zipcodeText;
        private System.Windows.Forms.TextBox cityText;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox address2Text;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox stateText;
        private System.Windows.Forms.TextBox dateText;
        private System.Windows.Forms.TextBox proofText;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ColumnHeader entireName;
        private System.Windows.Forms.ColumnHeader phoneNumber;
    }
}

