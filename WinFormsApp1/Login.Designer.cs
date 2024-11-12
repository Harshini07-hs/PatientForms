namespace WinFormsApp1
{
    partial class Login
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
            panel1 = new Panel();
            llbsignup = new Label();
            checkBox2 = new CheckBox();
            textBox2 = new TextBox();
            txtusername = new TextBox();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            label3 = new Label();
            lldusername = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(llbsignup);
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(txtusername);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lldusername);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(37, 26);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(802, 422);
            panel1.TabIndex = 0;
            // 
            // llbsignup
            // 
            llbsignup.AutoSize = true;
            llbsignup.Location = new Point(199, 320);
            llbsignup.Name = "llbsignup";
            llbsignup.Size = new Size(199, 25);
            llbsignup.TabIndex = 9;
            llbsignup.Text = "Not Yet Signup? please ";
            // 
            // checkBox2
            // 
            checkBox2.BackColor = SystemColors.Control;
            checkBox2.Location = new Point(665, 187);
            checkBox2.Margin = new Padding(3, 4, 3, 4);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(25, 28);
            checkBox2.TabIndex = 8;
            checkBox2.UseVisualStyleBackColor = false;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(368, 184);
            textBox2.Margin = new Padding(0, 0, 0, 0);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(322, 31);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // txtusername
            // 
            txtusername.Location = new Point(368, 127);
            txtusername.Margin = new Padding(3, 4, 3, 4);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(322, 31);
            txtusername.TabIndex = 5;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(412, 320);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(70, 25);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "SignUp";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(380, 235);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(134, 42);
            button1.TabIndex = 3;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(199, 187);
            label3.Name = "label3";
            label3.Size = new Size(117, 28);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // lldusername
            // 
            lldusername.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lldusername.Location = new Point(199, 127);
            lldusername.Name = "lldusername";
            lldusername.Size = new Size(117, 28);
            lldusername.TabIndex = 1;
            lldusername.Text = "Username";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("High Tower Text", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(341, 26);
            label1.Name = "label1";
            label1.Size = new Size(183, 43);
            label1.TabIndex = 0;
            label1.Text = "Welcome!";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.background1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(882, 485);
            Controls.Add(panel1);
            ForeColor = SystemColors.WindowText;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label lldusername;
        private Label label1;
        private TextBox textBox2;
        private TextBox txtusername;
        private LinkLabel linkLabel1;
        private Button button1;
        private CheckBox checkBox2;
        private Label llbsignup;
    }
}