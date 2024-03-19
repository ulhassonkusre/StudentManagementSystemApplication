namespace StudentManagementSystem
{
    partial class EditStudent11
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
            groupBox1 = new GroupBox();
            label105 = new Label();
            Class_textBox = new TextBox();
            Age_textBox = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label16 = new Label();
            LastName_textBox = new TextBox();
            FirstName_textBox = new TextBox();
            Gender_comboBox = new ComboBox();
            Address_textBox = new TextBox();
            label104 = new Label();
            label103 = new Label();
            label102 = new Label();
            label101 = new Label();
            Cancel_btn = new Button();
            Save_btn = new Button();
            Delete_btn = new Button();
            label10 = new Label();
            label13 = new Label();
            label14 = new Label();
            label7 = new Label();
            label8 = new Label();
            label5 = new Label();
            label6 = new Label();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            label17 = new Label();
            label15 = new Label();
            label12 = new Label();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(label105);
            groupBox1.Controls.Add(Class_textBox);
            groupBox1.Controls.Add(Age_textBox);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(LastName_textBox);
            groupBox1.Controls.Add(FirstName_textBox);
            groupBox1.Controls.Add(Gender_comboBox);
            groupBox1.Controls.Add(Address_textBox);
            groupBox1.Controls.Add(label104);
            groupBox1.Controls.Add(label103);
            groupBox1.Controls.Add(label102);
            groupBox1.Controls.Add(label101);
            groupBox1.Controls.Add(Cancel_btn);
            groupBox1.Controls.Add(Save_btn);
            groupBox1.Controls.Add(Delete_btn);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label12);
            groupBox1.Location = new Point(14, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(770, 770);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // label105
            // 
            label105.AutoSize = true;
            label105.BackColor = Color.White;
            label105.FlatStyle = FlatStyle.Popup;
            label105.Font = new Font("Microsoft Sans Serif", 8F);
            label105.ForeColor = Color.White;
            label105.Location = new Point(522, 407);
            label105.Name = "label105";
            label105.Size = new Size(115, 20);
            label105.TabIndex = 27;
            label105.Text = "Age is required";
            // 
            // Class_textBox
            // 
            Class_textBox.BorderStyle = BorderStyle.FixedSingle;
            Class_textBox.Font = new Font("Segoe UI", 12F);
            Class_textBox.Location = new Point(177, 436);
            Class_textBox.Name = "Class_textBox";
            Class_textBox.PlaceholderText = " Please Enter  Class";
            Class_textBox.Size = new Size(265, 39);
            Class_textBox.TabIndex = 31;
            // 
            // Age_textBox
            // 
            Age_textBox.BorderStyle = BorderStyle.FixedSingle;
            Age_textBox.Font = new Font("Segoe UI", 12F);
            Age_textBox.Location = new Point(599, 360);
            Age_textBox.Name = "Age_textBox";
            Age_textBox.Size = new Size(70, 39);
            Age_textBox.TabIndex = 30;
            Age_textBox.TextChanged += Age_textBox_TextChanged_1;
            Age_textBox.VisibleChanged += Age_textBox_TextChanged;
            Age_textBox.KeyPress += Age_textBox_KeyPress;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 10F);
            dateTimePicker1.Checked = false;
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Font = new Font("Segoe UI", 12F);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.ImeMode = ImeMode.NoControl;
            dateTimePicker1.Location = new Point(177, 360);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(265, 39);
            dateTimePicker1.TabIndex = 29;
            dateTimePicker1.Value = new DateTime(2024, 1, 3, 0, 0, 0, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged_1;
            dateTimePicker1.VisibleChanged += dateTimePicker1_ValueChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 11F);
            label16.Location = new Point(683, 364);
            label16.Name = "label16";
            label16.Size = new Size(64, 30);
            label16.TabIndex = 28;
            label16.Text = "years";
            // 
            // LastName_textBox
            // 
            LastName_textBox.BorderStyle = BorderStyle.FixedSingle;
            LastName_textBox.Font = new Font("Segoe UI", 12F);
            LastName_textBox.Location = new Point(177, 199);
            LastName_textBox.Name = "LastName_textBox";
            LastName_textBox.PlaceholderText = " Please Enter Last Name";
            LastName_textBox.Size = new Size(570, 39);
            LastName_textBox.TabIndex = 27;
            LastName_textBox.TextChanged += LastName_textBox_TextChanged_1;
            LastName_textBox.KeyDown += LastName_textBox_KeyDown_1;
            LastName_textBox.KeyPress += LastName_textBox_KeyPress;
            // 
            // FirstName_textBox
            // 
            FirstName_textBox.BorderStyle = BorderStyle.FixedSingle;
            FirstName_textBox.Font = new Font("Segoe UI", 12F);
            FirstName_textBox.Location = new Point(177, 122);
            FirstName_textBox.Name = "FirstName_textBox";
            FirstName_textBox.PlaceholderText = " Please Enter First Name";
            FirstName_textBox.Size = new Size(570, 39);
            FirstName_textBox.TabIndex = 26;
            FirstName_textBox.TextChanged += FirstName_textBox_TextChanged;
            FirstName_textBox.KeyDown += FirstName_textBox_KeyDown;
            FirstName_textBox.KeyPress += FirstName_textBox_KeyPress;
            // 
            // Gender_comboBox
            // 
            Gender_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            Gender_comboBox.Font = new Font("Microsoft Sans Serif", 12F);
            Gender_comboBox.FormattingEnabled = true;
            Gender_comboBox.Items.AddRange(new object[] { "Male", "Female", "Other" });
            Gender_comboBox.Location = new Point(177, 281);
            Gender_comboBox.Name = "Gender_comboBox";
            Gender_comboBox.Size = new Size(265, 37);
            Gender_comboBox.TabIndex = 4;
            Gender_comboBox.SelectedIndexChanged += Gender_comboBox_SelectedIndexChanged;
            // 
            // Address_textBox
            // 
            Address_textBox.BorderStyle = BorderStyle.FixedSingle;
            Address_textBox.Font = new Font("Microsoft Sans Serif", 12F);
            Address_textBox.Location = new Point(177, 519);
            Address_textBox.Multiline = true;
            Address_textBox.Name = "Address_textBox";
            Address_textBox.Size = new Size(570, 118);
            Address_textBox.TabIndex = 8;
            // 
            // label104
            // 
            label104.AutoSize = true;
            label104.BackColor = Color.White;
            label104.FlatStyle = FlatStyle.Popup;
            label104.Font = new Font("Microsoft Sans Serif", 8F);
            label104.ForeColor = Color.White;
            label104.Location = new Point(177, 407);
            label104.Name = "label104";
            label104.Size = new Size(115, 20);
            label104.TabIndex = 25;
            label104.Text = "Age is required";
            // 
            // label103
            // 
            label103.AutoSize = true;
            label103.BackColor = Color.White;
            label103.FlatStyle = FlatStyle.Popup;
            label103.Font = new Font("Microsoft Sans Serif", 8F);
            label103.ForeColor = Color.White;
            label103.Location = new Point(177, 331);
            label103.Name = "label103";
            label103.Size = new Size(140, 20);
            label103.TabIndex = 24;
            label103.Text = "Gender is required";
            // 
            // label102
            // 
            label102.AutoSize = true;
            label102.BackColor = Color.White;
            label102.FlatStyle = FlatStyle.Popup;
            label102.Font = new Font("Microsoft Sans Serif", 8F);
            label102.ForeColor = Color.White;
            label102.Location = new Point(177, 251);
            label102.Name = "label102";
            label102.Size = new Size(163, 20);
            label102.TabIndex = 23;
            label102.Text = "Last Name is required";
            // 
            // label101
            // 
            label101.AutoSize = true;
            label101.BackColor = Color.White;
            label101.FlatStyle = FlatStyle.Popup;
            label101.Font = new Font("Microsoft Sans Serif", 8F);
            label101.ForeColor = Color.White;
            label101.Location = new Point(177, 169);
            label101.Name = "label101";
            label101.Size = new Size(163, 20);
            label101.TabIndex = 22;
            label101.Text = "First Name is required";
            // 
            // Cancel_btn
            // 
            Cancel_btn.BackColor = Color.DarkGray;
            Cancel_btn.FlatAppearance.BorderSize = 0;
            Cancel_btn.FlatStyle = FlatStyle.Flat;
            Cancel_btn.Font = new Font("Microsoft Sans Serif", 12F);
            Cancel_btn.ForeColor = Color.Black;
            Cancel_btn.Location = new Point(637, 690);
            Cancel_btn.Name = "Cancel_btn";
            Cancel_btn.Size = new Size(110, 45);
            Cancel_btn.TabIndex = 10;
            Cancel_btn.Text = "Cancel";
            Cancel_btn.UseVisualStyleBackColor = false;
            Cancel_btn.Click += Cancel_btn_Click;
            // 
            // Save_btn
            // 
            Save_btn.BackColor = Color.SteelBlue;
            Save_btn.FlatAppearance.BorderSize = 0;
            Save_btn.FlatStyle = FlatStyle.Flat;
            Save_btn.Font = new Font("Microsoft Sans Serif", 12F);
            Save_btn.ForeColor = Color.Black;
            Save_btn.Location = new Point(513, 690);
            Save_btn.Name = "Save_btn";
            Save_btn.Size = new Size(110, 45);
            Save_btn.TabIndex = 9;
            Save_btn.Text = "Save";
            Save_btn.UseVisualStyleBackColor = false;
            Save_btn.Click += Save_btn_Click;
            // 
            // Delete_btn
            // 
            Delete_btn.BackColor = Color.DarkGray;
            Delete_btn.FlatAppearance.BorderSize = 0;
            Delete_btn.FlatStyle = FlatStyle.Flat;
            Delete_btn.Font = new Font("Microsoft Sans Serif", 12F);
            Delete_btn.ForeColor = Color.Red;
            Delete_btn.Location = new Point(22, 690);
            Delete_btn.Name = "Delete_btn";
            Delete_btn.Size = new Size(110, 45);
            Delete_btn.TabIndex = 11;
            Delete_btn.Text = "Delete";
            Delete_btn.UseVisualStyleBackColor = false;
            Delete_btn.Click += Delete_btn_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F);
            label10.Location = new Point(16, 441);
            label10.Name = "label10";
            label10.Size = new Size(73, 29);
            label10.TabIndex = 16;
            label10.Text = "Class";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 15F);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(152, 365);
            label13.Name = "label13";
            label13.Size = new Size(27, 36);
            label13.TabIndex = 12;
            label13.Text = "*";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 12F);
            label14.Location = new Point(16, 365);
            label14.Name = "label14";
            label14.Size = new Size(144, 29);
            label14.TabIndex = 10;
            label14.Text = "Date of Birth";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 15F);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(135, 205);
            label7.Name = "label7";
            label7.Size = new Size(27, 36);
            label7.TabIndex = 9;
            label7.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F);
            label8.Location = new Point(16, 205);
            label8.Name = "label8";
            label8.Size = new Size(128, 29);
            label8.TabIndex = 7;
            label8.Text = "Last Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 15F);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(102, 285);
            label5.Name = "label5";
            label5.Size = new Size(27, 36);
            label5.TabIndex = 6;
            label5.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F);
            label6.Location = new Point(16, 285);
            label6.Name = "label6";
            label6.Size = new Size(94, 29);
            label6.TabIndex = 4;
            label6.Text = "Gender";
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(280, 12);
            label2.Name = "label2";
            label2.Size = new Size(270, 60);
            label2.TabIndex = 1;
            label2.Text = "Edit Student";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15F);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(137, 127);
            label4.Name = "label4";
            label4.Size = new Size(27, 36);
            label4.TabIndex = 3;
            label4.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.Location = new Point(16, 127);
            label3.Name = "label3";
            label3.Size = new Size(131, 29);
            label3.TabIndex = 1;
            label3.Text = "First Name";
            // 
            // label17
            // 
            label17.Font = new Font("Microsoft Sans Serif", 15F);
            label17.ForeColor = Color.Red;
            label17.Location = new Point(569, 359);
            label17.Name = "label17";
            label17.Size = new Size(31, 41);
            label17.TabIndex = 21;
            label17.Text = "*";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 12F);
            label15.Location = new Point(522, 364);
            label15.Name = "label15";
            label15.Size = new Size(56, 29);
            label15.TabIndex = 19;
            label15.Text = "Age";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F);
            label12.Location = new Point(16, 528);
            label12.Name = "label12";
            label12.Size = new Size(102, 29);
            label12.TabIndex = 13;
            label12.Text = "Address";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(150, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 800);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // EditStudent11
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1100, 850);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditStudent11";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditStudent11";
            Load += EditStudent11_Load;
            TextChanged += EditStudent11_TextChanged;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox Address_textBox;
        private Label label104;
        private Label label103;
        private Label label102;
        private Label label101;
        private Button Cancel_btn;
        private Button Save_btn;
        private Button Delete_btn;
        private Label label10;
        private Label label13;
        private Label label14;
        private Label label7;
        private Label label8;
        private Label label5;
        private Label label6;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label17;
        private Label label15;
        private Label label12;
        private Panel panel1;
        private ComboBox Gender_comboBox;
        private TextBox FirstName_textBox;
        private TextBox LastName_textBox;
        private Label label16;
        public DateTimePicker dateTimePicker1;
        private TextBox Age_textBox;
        private TextBox Class_textBox;
        private Label label105;
    }
}