namespace WinFormsApp1
{
    partial class Form1
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            HI = new Label();
            Sex = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            DOB = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox8 = new TextBox();
            label9 = new Label();
            label11 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            textBox7 = new TextBox();
            textBox9 = new TextBox();
            label5 = new Label();
            textBox10 = new TextBox();
            button1 = new Button();
            Insert = new Button();
            label10 = new Label();
            textBox11 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(140, 106);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "First Name";
            textBox1.Size = new Size(287, 31);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(638, 297);
            textBox2.MaxLength = 10;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(300, 31);
            textBox2.TabIndex = 1;
            textBox2.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(202, 410);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(677, 404);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(162, 610);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Street name,Locality,Area";
            textBox5.Size = new Size(808, 31);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(192, 502);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "example@gmail.com";
            textBox6.Size = new Size(300, 31);
            textBox6.TabIndex = 5;
            // 
            // HI
            // 
            HI.BackColor = SystemColors.Control;
            HI.FlatStyle = FlatStyle.Flat;
            HI.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HI.ForeColor = SystemColors.ActiveCaptionText;
            HI.Location = new Point(24, 106);
            HI.Name = "HI";
            HI.Size = new Size(59, 25);
            HI.TabIndex = 7;
            HI.Text = "Name";
            // 
            // Sex
            // 
            Sex.AutoSize = true;
            Sex.BackColor = SystemColors.Control;
            Sex.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Sex.Location = new Point(561, 203);
            Sex.Name = "Sex";
            Sex.Size = new Size(36, 20);
            Sex.TabIndex = 8;
            Sex.Text = "Sex";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(35, 416);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 10;
            label4.Text = "Height(inches)";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CausesValidation = false;
            dateTimePicker1.Location = new Point(140, 208);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(287, 31);
            dateTimePicker1.TabIndex = 11;
            // 
            // DOB
            // 
            DOB.AutoSize = true;
            DOB.BackColor = SystemColors.HighlightText;
            DOB.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DOB.Location = new Point(52, 208);
            DOB.Name = "DOB";
            DOB.Size = new Size(44, 20);
            DOB.TabIndex = 12;
            DOB.Text = "DOB";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(504, 410);
            label6.Name = "label6";
            label6.Size = new Size(136, 20);
            label6.TabIndex = 13;
            label6.Text = "Weight(pounds)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Control;
            label7.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(10, 297);
            label7.Name = "label7";
            label7.Size = new Size(122, 20);
            label7.TabIndex = 14;
            label7.Text = "Marital Status";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(489, 305);
            label8.Name = "label8";
            label8.Size = new Size(139, 20);
            label8.TabIndex = 15;
            label8.Text = "Contact Number";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(627, 115);
            textBox8.Name = "textBox8";
            textBox8.PlaceholderText = "Last Name";
            textBox8.Size = new Size(300, 31);
            textBox8.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.Control;
            label9.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(53, 508);
            label9.Name = "label9";
            label9.Size = new Size(54, 20);
            label9.TabIndex = 18;
            label9.Text = "Email";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.Control;
            label11.FlatStyle = FlatStyle.Popup;
            label11.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(52, 610);
            label11.Name = "label11";
            label11.Size = new Size(74, 20);
            label11.TabIndex = 20;
            label11.Text = "Address";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female", "Others" });
            comboBox1.Location = new Point(627, 200);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(300, 33);
            comboBox1.TabIndex = 21;
            comboBox1.Text = "Please select";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Married", "Unmarried" });
            comboBox2.Location = new Point(140, 294);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(291, 33);
            comboBox2.TabIndex = 22;
            comboBox2.Text = "Please select";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(59, 719);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 23;
            label1.Text = "City";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(53, 804);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 24;
            label2.Text = "State";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(162, 716);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(300, 31);
            textBox7.TabIndex = 25;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(177, 798);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(300, 31);
            textBox9.TabIndex = 26;
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(53, 900);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 27;
            label5.Text = "Postal Code";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(192, 894);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(150, 31);
            textBox10.TabIndex = 28;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Location = new Point(380, 1066);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 32;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Insert
            // 
            Insert.BackColor = SystemColors.InactiveCaption;
            Insert.Location = new Point(177, 1066);
            Insert.Name = "Insert";
            Insert.Size = new Size(112, 34);
            Insert.TabIndex = 33;
            Insert.Text = "Save";
            Insert.UseVisualStyleBackColor = false;
            Insert.Click += button2_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(53, 18);
            label10.Name = "label10";
            label10.Size = new Size(30, 25);
            label10.TabIndex = 34;
            label10.Text = "ID";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(140, 18);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(200, 31);
            textBox11.TabIndex = 35;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.HotTrack;
            BackgroundImage = Properties.Resources.background1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1059, 1170);
            Controls.Add(Sex);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(DOB);
            Controls.Add(textBox8);
            Controls.Add(textBox1);
            Controls.Add(HI);
            Controls.Add(textBox11);
            Controls.Add(label10);
            Controls.Add(Insert);
            Controls.Add(button1);
            Controls.Add(textBox10);
            Controls.Add(label5);
            Controls.Add(textBox9);
            Controls.Add(textBox7);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label HI;
        private Label Sex;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label DOB;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox8;
        private Label label9;
        private Label label11;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label1;
        private Label label2;
        private TextBox textBox7;
        private TextBox textBox9;
        private Label label5;
        private TextBox textBox10;
        private Button button1;
        private Button Insert;
        private Label label10;
        private TextBox textBox11;
        //  private DataGridView dataGridView2;
    }
}
