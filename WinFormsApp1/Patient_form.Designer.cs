namespace WinFormsApp1
{
    partial class Patient_form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtfirstname = new TextBox();
            txtcontactnumber = new TextBox();
            txtheight = new TextBox();
            txtweight = new TextBox();
            txtaddress = new TextBox();
            txtemail = new TextBox();
            llbname = new Label();
            llbsex = new Label();
            llbheight = new Label();
            dtdob = new DateTimePicker();
            llbdob = new Label();
            llbweight = new Label();
            llbmaritalstatus = new Label();
            llbcontact = new Label();
            txtlastname = new TextBox();
            llbemail = new Label();
            llbaddress = new Label();
            cmbsex = new ComboBox();
            cmbmaritalstatus = new ComboBox();
            llbcity = new Label();
            llbstate = new Label();
            txtcity = new TextBox();
            txtstate = new TextBox();
            llbpostalcode = new Label();
            txtpostalcode = new TextBox();
            btnsave = new Button();
            menuStrip1 = new MenuStrip();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            llbPatientform = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtfirstname
            // 
            txtfirstname.Location = new Point(100, 157);
            txtfirstname.Name = "txtfirstname";
            txtfirstname.PlaceholderText = "First Name";
            txtfirstname.Size = new Size(346, 31);
            txtfirstname.TabIndex = 0;
            txtfirstname.TextChanged += textBox1_TextChanged;
            // 
            // txtcontactnumber
            // 
            txtcontactnumber.Location = new Point(561, 379);
            txtcontactnumber.MaxLength = 10;
            txtcontactnumber.Name = "txtcontactnumber";
            txtcontactnumber.Size = new Size(314, 31);
            txtcontactnumber.TabIndex = 1;
            txtcontactnumber.TextAlign = HorizontalAlignment.Right;
            // 
            // txtheight
            // 
            txtheight.Location = new Point(100, 512);
            txtheight.Name = "txtheight";
            txtheight.Size = new Size(324, 31);
            txtheight.TabIndex = 2;
            // 
            // txtweight
            // 
            txtweight.Location = new Point(564, 512);
            txtweight.Name = "txtweight";
            txtweight.Size = new Size(150, 31);
            txtweight.TabIndex = 3;
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(100, 773);
            txtaddress.Name = "txtaddress";
            txtaddress.PlaceholderText = "Street name,Locality,Area";
            txtaddress.Size = new Size(808, 31);
            txtaddress.TabIndex = 4;
            txtaddress.TextChanged += textBox5_TextChanged;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(100, 653);
            txtemail.Name = "txtemail";
            txtemail.PlaceholderText = "example@gmail.com";
            txtemail.Size = new Size(300, 31);
            txtemail.TabIndex = 5;
            // 
            // llbname
            // 
            llbname.BackColor = SystemColors.Control;
            llbname.FlatStyle = FlatStyle.Flat;
            llbname.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llbname.ForeColor = SystemColors.ActiveCaptionText;
            llbname.Location = new Point(100, 112);
            llbname.Name = "llbname";
            llbname.Size = new Size(59, 25);
            llbname.TabIndex = 7;
            llbname.Text = "Name";
            // 
            // llbsex
            // 
            llbsex.AutoSize = true;
            llbsex.BackColor = SystemColors.Control;
            llbsex.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llbsex.Location = new Point(564, 222);
            llbsex.Name = "llbsex";
            llbsex.Size = new Size(36, 20);
            llbsex.TabIndex = 8;
            llbsex.Text = "Sex";
            // 
            // llbheight
            // 
            llbheight.AutoSize = true;
            llbheight.BackColor = SystemColors.Control;
            llbheight.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llbheight.Location = new Point(100, 480);
            llbheight.Name = "llbheight";
            llbheight.Size = new Size(127, 20);
            llbheight.TabIndex = 10;
            llbheight.Text = "Height(inches)";
            // 
            // dtdob
            // 
            dtdob.CausesValidation = false;
            dtdob.Location = new Point(100, 258);
            dtdob.Name = "dtdob";
            dtdob.Size = new Size(324, 31);
            dtdob.TabIndex = 11;
            // 
            // llbdob
            // 
            llbdob.AutoSize = true;
            llbdob.BackColor = SystemColors.HighlightText;
            llbdob.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llbdob.Location = new Point(100, 222);
            llbdob.Name = "llbdob";
            llbdob.Size = new Size(44, 20);
            llbdob.TabIndex = 12;
            llbdob.Text = "DOB";
            // 
            // llbweight
            // 
            llbweight.AutoSize = true;
            llbweight.BackColor = SystemColors.Control;
            llbweight.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llbweight.Location = new Point(564, 480);
            llbweight.Name = "llbweight";
            llbweight.Size = new Size(136, 20);
            llbweight.TabIndex = 13;
            llbweight.Text = "Weight(pounds)";
            // 
            // llbmaritalstatus
            // 
            llbmaritalstatus.AutoSize = true;
            llbmaritalstatus.BackColor = SystemColors.Control;
            llbmaritalstatus.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llbmaritalstatus.Location = new Point(100, 336);
            llbmaritalstatus.Name = "llbmaritalstatus";
            llbmaritalstatus.Size = new Size(122, 20);
            llbmaritalstatus.TabIndex = 14;
            llbmaritalstatus.Text = "Marital Status";
            // 
            // llbcontact
            // 
            llbcontact.AutoSize = true;
            llbcontact.BackColor = SystemColors.Control;
            llbcontact.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llbcontact.Location = new Point(561, 336);
            llbcontact.Name = "llbcontact";
            llbcontact.Size = new Size(139, 20);
            llbcontact.TabIndex = 15;
            llbcontact.Text = "Contact Number";
            // 
            // txtlastname
            // 
            txtlastname.Location = new Point(547, 157);
            txtlastname.Name = "txtlastname";
            txtlastname.PlaceholderText = "Last Name";
            txtlastname.Size = new Size(314, 31);
            txtlastname.TabIndex = 16;
            // 
            // llbemail
            // 
            llbemail.AutoSize = true;
            llbemail.BackColor = SystemColors.Control;
            llbemail.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llbemail.Location = new Point(100, 610);
            llbemail.Name = "llbemail";
            llbemail.Size = new Size(54, 20);
            llbemail.TabIndex = 18;
            llbemail.Text = "Email";
            // 
            // llbaddress
            // 
            llbaddress.AutoSize = true;
            llbaddress.BackColor = SystemColors.Control;
            llbaddress.FlatStyle = FlatStyle.Popup;
            llbaddress.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llbaddress.Location = new Point(100, 732);
            llbaddress.Name = "llbaddress";
            llbaddress.Size = new Size(74, 20);
            llbaddress.TabIndex = 20;
            llbaddress.Text = "Address";
            // 
            // cmbsex
            // 
            cmbsex.FormattingEnabled = true;
            cmbsex.Items.AddRange(new object[] { "Male", "Female", "Others" });
            cmbsex.Location = new Point(561, 256);
            cmbsex.Name = "cmbsex";
            cmbsex.Size = new Size(314, 33);
            cmbsex.TabIndex = 21;
            cmbsex.Text = "Please select";
            // 
            // cmbmaritalstatus
            // 
            cmbmaritalstatus.FormattingEnabled = true;
            cmbmaritalstatus.Items.AddRange(new object[] { "Married", "Unmarried" });
            cmbmaritalstatus.Location = new Point(100, 377);
            cmbmaritalstatus.Name = "cmbmaritalstatus";
            cmbmaritalstatus.Size = new Size(324, 33);
            cmbmaritalstatus.TabIndex = 22;
            cmbmaritalstatus.Text = "Please select";
            // 
            // llbcity
            // 
            llbcity.AutoSize = true;
            llbcity.BackColor = SystemColors.Control;
            llbcity.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llbcity.Location = new Point(100, 882);
            llbcity.Name = "llbcity";
            llbcity.Size = new Size(39, 20);
            llbcity.TabIndex = 23;
            llbcity.Text = "City";
            // 
            // llbstate
            // 
            llbstate.AutoSize = true;
            llbstate.BackColor = SystemColors.Control;
            llbstate.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llbstate.Location = new Point(564, 882);
            llbstate.Name = "llbstate";
            llbstate.Size = new Size(50, 20);
            llbstate.TabIndex = 24;
            llbstate.Text = "State";
            // 
            // txtcity
            // 
            txtcity.Location = new Point(100, 918);
            txtcity.Name = "txtcity";
            txtcity.Size = new Size(300, 31);
            txtcity.TabIndex = 25;
            // 
            // txtstate
            // 
            txtstate.Location = new Point(561, 918);
            txtstate.Name = "txtstate";
            txtstate.Size = new Size(300, 31);
            txtstate.TabIndex = 26;
            txtstate.TextChanged += textBox9_TextChanged;
            // 
            // llbpostalcode
            // 
            llbpostalcode.AutoSize = true;
            llbpostalcode.BackColor = SystemColors.Control;
            llbpostalcode.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llbpostalcode.Location = new Point(564, 610);
            llbpostalcode.Name = "llbpostalcode";
            llbpostalcode.Size = new Size(105, 20);
            llbpostalcode.TabIndex = 27;
            llbpostalcode.Text = "Postal Code";
            // 
            // txtpostalcode
            // 
            txtpostalcode.Location = new Point(564, 653);
            txtpostalcode.Name = "txtpostalcode";
            txtpostalcode.Size = new Size(150, 31);
            txtpostalcode.TabIndex = 28;
            // 
            // btnsave
            // 
            btnsave.BackColor = SystemColors.InactiveCaption;
            btnsave.Location = new Point(404, 1004);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(170, 43);
            btnsave.TabIndex = 33;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += button2_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { optionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1059, 52);
            menuStrip1.TabIndex = 34;
            menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.BackColor = SystemColors.GrayText;
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem, logoutToolStripMenuItem });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(92, 48);
            optionsToolStripMenuItem.Text = "Options";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(171, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(171, 34);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // llbPatientform
            // 
            llbPatientform.BackColor = SystemColors.MenuHighlight;
            llbPatientform.Font = new Font("High Tower Text", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llbPatientform.Location = new Point(100, 0);
            llbPatientform.Name = "llbPatientform";
            llbPatientform.Size = new Size(959, 52);
            llbPatientform.TabIndex = 35;
            llbPatientform.Text = "Patient Form";
            // 
            // Patient_form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.InactiveBorder;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1059, 1170);
            Controls.Add(llbPatientform);
            Controls.Add(llbsex);
            Controls.Add(llbheight);
            Controls.Add(txtheight);
            Controls.Add(cmbsex);
            Controls.Add(dtdob);
            Controls.Add(llbdob);
            Controls.Add(txtlastname);
            Controls.Add(txtfirstname);
            Controls.Add(llbname);
            Controls.Add(btnsave);
            Controls.Add(txtpostalcode);
            Controls.Add(llbpostalcode);
            Controls.Add(txtstate);
            Controls.Add(txtcity);
            Controls.Add(llbstate);
            Controls.Add(llbcity);
            Controls.Add(cmbmaritalstatus);
            Controls.Add(llbaddress);
            Controls.Add(llbemail);
            Controls.Add(llbcontact);
            Controls.Add(llbmaritalstatus);
            Controls.Add(llbweight);
            Controls.Add(txtemail);
            Controls.Add(txtaddress);
            Controls.Add(txtweight);
            Controls.Add(txtcontactnumber);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Patient_form";
            Text = "Patient_Form";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtfirstname;
        private TextBox txtcontactnumber;
        private TextBox txtheight;
        private TextBox txtweight;
        private TextBox txtaddress;
        private TextBox txtemail;
        private Label llbname;
        private Label llbsex;
        private Label llbheight;
        private DateTimePicker dtdob;
        private Label llbdob;
        private Label llbweight;
        private Label llbmaritalstatus;
        private Label llbcontact;
        private TextBox txtlastname;
        private Label llbemail;
        private Label llbaddress;
        private ComboBox cmbsex;
        private ComboBox cmbmaritalstatus;
        private Label llbcity;
        private Label llbstate;
        private TextBox txtcity;
        private TextBox txtstate;
        private Label llbpostalcode;
        private TextBox txtpostalcode;
        private Button btnsave;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private Label llbPatientform;
        private Label label3;
        private Label label10;
        private Label label12;
        //  private DataGridView dataGridView2;
    }
}
