namespace FinalProject
{
    partial class studentRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentRegistration));
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox4 = new GroupBox();
            tbParentName = new TextBox();
            label14 = new Label();
            tbContactNo = new TextBox();
            tbNIC = new TextBox();
            label12 = new Label();
            label13 = new Label();
            groupBox3 = new GroupBox();
            tbHPhone = new TextBox();
            tbMPhone = new TextBox();
            tbEmail = new TextBox();
            tbAddress = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            groupBox2 = new GroupBox();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            dpDOB = new DateTimePicker();
            tbLName = new TextBox();
            tbFName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            cbRegNo = new ComboBox();
            label2 = new Label();
            linkLabel2 = new LinkLabel();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(12, 9);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(45, 15);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Logout";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(123, 17);
            label1.Name = "label1";
            label1.Size = new Size(278, 36);
            label1.TabIndex = 1;
            label1.Text = "Skills International";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(cbRegNo);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(491, 590);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Registration";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button4
            // 
            button4.Location = new Point(396, 551);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 12;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(314, 551);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 11;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(101, 552);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(17, 551);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tbParentName);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(tbContactNo);
            groupBox4.Controls.Add(tbNIC);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(label13);
            groupBox4.Location = new Point(17, 407);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(454, 130);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "Parent Details";
            // 
            // tbParentName
            // 
            tbParentName.Location = new Point(121, 31);
            tbParentName.Name = "tbParentName";
            tbParentName.Size = new Size(324, 23);
            tbParentName.TabIndex = 9;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(22, 34);
            label14.Name = "label14";
            label14.Size = new Size(76, 15);
            label14.TabIndex = 8;
            label14.Text = "Parent Name";
            // 
            // tbContactNo
            // 
            tbContactNo.Location = new Point(121, 89);
            tbContactNo.Name = "tbContactNo";
            tbContactNo.Size = new Size(146, 23);
            tbContactNo.TabIndex = 6;
            // 
            // tbNIC
            // 
            tbNIC.Location = new Point(121, 60);
            tbNIC.Name = "tbNIC";
            tbNIC.Size = new Size(146, 23);
            tbNIC.TabIndex = 5;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(22, 92);
            label12.Name = "label12";
            label12.Size = new Size(96, 15);
            label12.TabIndex = 2;
            label12.Text = "Contact Number";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(22, 63);
            label13.Name = "label13";
            label13.Size = new Size(27, 15);
            label13.TabIndex = 1;
            label13.Text = "NIC";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tbHPhone);
            groupBox3.Controls.Add(tbMPhone);
            groupBox3.Controls.Add(tbEmail);
            groupBox3.Controls.Add(tbAddress);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(17, 236);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(454, 164);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Contact Details";
            // 
            // tbHPhone
            // 
            tbHPhone.Location = new Point(331, 121);
            tbHPhone.Name = "tbHPhone";
            tbHPhone.Size = new Size(113, 23);
            tbHPhone.TabIndex = 7;
            // 
            // tbMPhone
            // 
            tbMPhone.Location = new Point(120, 121);
            tbMPhone.Name = "tbMPhone";
            tbMPhone.Size = new Size(113, 23);
            tbMPhone.TabIndex = 6;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(120, 92);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(324, 23);
            tbEmail.TabIndex = 5;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(120, 31);
            tbAddress.Multiline = true;
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(324, 55);
            tbAddress.TabIndex = 4;
            tbAddress.TextChanged += tbAddress_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(251, 124);
            label7.Name = "label7";
            label7.Size = new Size(77, 15);
            label7.TabIndex = 3;
            label7.Text = "Home Phone";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 124);
            label8.Name = "label8";
            label8.Size = new Size(81, 15);
            label8.TabIndex = 2;
            label8.Text = "Mobile Phone";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 95);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 1;
            label9.Text = "Email";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(21, 34);
            label10.Name = "label10";
            label10.Size = new Size(49, 15);
            label10.TabIndex = 0;
            label10.Text = "Address";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbFemale);
            groupBox2.Controls.Add(rbMale);
            groupBox2.Controls.Add(dpDOB);
            groupBox2.Controls.Add(tbLName);
            groupBox2.Controls.Add(tbFName);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(17, 64);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(454, 166);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Basic Details";
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(215, 133);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(63, 19);
            rbFemale.TabIndex = 8;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(121, 131);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(51, 19);
            rbMale.TabIndex = 7;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // dpDOB
            // 
            dpDOB.Format = DateTimePickerFormat.Short;
            dpDOB.Location = new Point(120, 96);
            dpDOB.Name = "dpDOB";
            dpDOB.Size = new Size(146, 23);
            dpDOB.TabIndex = 6;
            // 
            // tbLName
            // 
            tbLName.Location = new Point(120, 65);
            tbLName.Name = "tbLName";
            tbLName.Size = new Size(324, 23);
            tbLName.TabIndex = 5;
            // 
            // tbFName
            // 
            tbFName.Location = new Point(120, 31);
            tbFName.Name = "tbFName";
            tbFName.Size = new Size(324, 23);
            tbFName.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 133);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 3;
            label6.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 102);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 2;
            label5.Text = "Date of Birth";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 68);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 1;
            label4.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 34);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 0;
            label3.Text = "First Name";
            // 
            // cbRegNo
            // 
            cbRegNo.FormattingEnabled = true;
            cbRegNo.Location = new Point(138, 29);
            cbRegNo.Name = "cbRegNo";
            cbRegNo.Size = new Size(121, 23);
            cbRegNo.TabIndex = 1;
            cbRegNo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 32);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 0;
            label2.Text = "Reg No";
            // 
            // linkLabel2
            // 
            linkLabel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(477, 653);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(26, 15);
            linkLabel2.TabIndex = 0;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Exit";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // studentRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 678);
            Controls.Add(linkLabel2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(linkLabel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "studentRegistration";
            Text = "Student Registration - Skills International";
            Load += studentRegistration_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Label label1;
        private GroupBox groupBox1;
        private LinkLabel linkLabel2;
        private Label label2;
        private GroupBox groupBox2;
        private TextBox tbFName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox cbRegNo;
        private DateTimePicker dpDOB;
        private TextBox tbLName;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private GroupBox groupBox3;
        private TextBox tbHPhone;
        private TextBox tbMPhone;
        private TextBox tbEmail;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private GroupBox groupBox4;
        private TextBox tbParentName;
        private Label label14;
        private TextBox tbContactNo;
        private TextBox tbNIC;
        private Label label12;
        private Label label13;
        private TextBox tbAddress;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}