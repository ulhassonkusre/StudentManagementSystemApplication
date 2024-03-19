namespace StudentManagementSystem
{
    partial class StudentDetails11
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            dataGridView = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Search_textBox = new TextBox();
            Add = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(50, 140);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 570);
            panel1.TabIndex = 15;
            panel1.Paint += panel1_Paint;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView);
            groupBox1.Controls.Add(Search_textBox);
            groupBox1.Controls.Add(Add);
            groupBox1.Controls.Add(label2);
            groupBox1.FlatStyle = FlatStyle.System;
            groupBox1.Location = new Point(3, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(992, 540);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeight = 40;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.SteelBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.Location = new Point(27, 234);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.SteelBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(937, 300);
            dataGridView.TabIndex = 12;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            dataGridView.CellContentDoubleClick += dataGridView_CellDoubleClick;
            dataGridView.CellDoubleClick += dataGridView_CellDoubleClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "First Name";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Last Name";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Gender";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Age";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Class";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Search_textBox
            // 
            Search_textBox.BorderStyle = BorderStyle.FixedSingle;
            Search_textBox.Font = new Font("Segoe UI", 12F);
            Search_textBox.Location = new Point(656, 164);
            Search_textBox.Name = "Search_textBox";
            Search_textBox.PlaceholderText = " Search...";
            Search_textBox.Size = new Size(200, 39);
            Search_textBox.TabIndex = 100;
            Search_textBox.TextChanged += Search_textBox_TextChanged;
            // 
            // Add
            // 
            Add.BackColor = Color.SteelBlue;
            Add.FlatStyle = FlatStyle.Flat;
            Add.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add.Location = new Point(879, 164);
            Add.Margin = new Padding(0);
            Add.Name = "Add";
            Add.Size = new Size(85, 40);
            Add.TabIndex = 1;
            Add.Text = "+Add";
            Add.TextAlign = ContentAlignment.MiddleCenter;
            Add.Click += Add_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(360, 27);
            label2.Name = "label2";
            label2.Size = new Size(278, 52);
            label2.TabIndex = 2;
            label2.Text = "Our Students";
            // 
            // StudentDetails11
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1100, 850);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentDetails11";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += StudentDetails11_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        public DataGridView dataGridView;
        private TextBox Search_textBox;
        private Label label2;
        private Label Add;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}
