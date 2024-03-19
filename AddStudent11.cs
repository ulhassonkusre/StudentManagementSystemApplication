using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagementSystem.Models;
namespace StudentManagementSystem
{
    public partial class AddStudent11 : Form
    {
        private List<Student11> studentList1 = new List<Student11>();

        public List<Student11> StudentList1
        {
            get { return studentList1; }
        }
        public AddStudent11()
        {
            InitializeComponent();

        }
        public AddStudent11(List<Student11> SList) : this()
        {

            this.studentList1 = SList;

        }

        private void AddStudent11_Load(object sender, EventArgs e)
        {

        }
        public bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(FirstName_textBox.Text) || string.IsNullOrWhiteSpace(LastName_textBox.Text)
                || string.IsNullOrWhiteSpace(Gender_comboBox.Text) || string.IsNullOrWhiteSpace(Age_textBox.Text))
            {
                if (string.IsNullOrWhiteSpace(FirstName_textBox.Text))
                {
                    label101.Text = "This Field is required";
                    label101.ForeColor = Color.Red;
                }
                else
                {

                    label101.Visible = false;
                }
                if (string.IsNullOrWhiteSpace(LastName_textBox.Text))
                {
                    label102.Text = "This Field is required";
                    label102.ForeColor = Color.Red;
                }
                else
                {

                    label102.Visible = false;
                }
                if (string.IsNullOrWhiteSpace(Gender_comboBox.Text))
                {
                    label103.Text = "This Field is required";
                    label103.ForeColor = Color.Red;

                }
                else
                {

                    label103.Visible = false;
                }

                if (string.IsNullOrWhiteSpace(Age_textBox.Text))
                {
                    label104.Text = "This Field is required";
                    label104.ForeColor = Color.Red;
                    label105.Text = "This Field is required";
                    label105.ForeColor = Color.Red;
                }
                else
                {

                    label104.Visible = false;
                    label105.Visible = false;

                }

            }

            string FirstNameTreamed = FirstName_textBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(FirstNameTreamed) || !FirstNameTreamed.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)) || FirstNameTreamed.Length < 3 || FirstNameTreamed.Length > 15
                || FirstNameTreamed.Contains("  ") || FirstNameTreamed.Replace(" ", "").Length < 3)
            {
                label101.Visible = true;

                if (string.IsNullOrWhiteSpace(FirstNameTreamed))
                {
                    label101.Text = "This Field is required";
                    label101.ForeColor = Color.Red;
                }
                else if (!FirstNameTreamed.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                {
                    label101.Text = "This Field is required";
                    // label101.Text = "Length should be between 3 and 15.";
                    // label101.Text = "Only characters are allowed";
                    // FirstName_textBox.Text = string.Empty;
                    label101.ForeColor = Color.Red;

                }

                else if (FirstNameTreamed.Contains("  "))
                {
                    label101.Text = "Consecutive spaces are not allowed";
                    //label101.Text = "Length should be between 3 and 15.";
                    // FirstName_textBox.Text = string.Empty;

                    label101.ForeColor = Color.Red;
                    //label101.Visible = false;
                }

                else
                {
                    label101.Text = "Length should be between 3 and 15.";
                    label101.ForeColor = Color.Red;
                }
                return false;
            }

            string LastNameTreamed = LastName_textBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(LastNameTreamed) || !LastNameTreamed.All(c => char.IsLetter(c) || LastNameTreamed.Contains(" ") || char.IsWhiteSpace(c)) || LastNameTreamed.Contains("  ") || LastNameTreamed.Length < 2 || LastNameTreamed.Length > 18
                    || LastNameTreamed.Contains("  ") || LastNameTreamed.Replace(" ", "").Length < 2)
            {
                label102.Visible = true;

                if (string.IsNullOrWhiteSpace(LastNameTreamed))
                {
                    label102.Text = "This Field is required";
                    label102.ForeColor = Color.Red;
                }
                if (!LastNameTreamed.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                {
                    // label102.Text = "Only characters are allowed";
                    //LastName_textBox.Text = string.Empty;
                    label102.ForeColor = Color.Red;
                }

                if (LastNameTreamed.Contains("  "))
                {
                    label102.Text = "Consecutive spaces are not allowed";
                    ////LastName_textBox.Text = string.Empty;
                    label102.ForeColor = Color.Red;
                    ////label102.Visible = false;
                }

                else
                {
                    label102.Text = "Length should be between 2 and 18.";
                    label102.ForeColor = Color.Red;
                }
                return false;
            }


            if (string.IsNullOrWhiteSpace(Gender_comboBox.Text) || (Gender_comboBox.Text != "Male" && Gender_comboBox.Text != "Female" && Gender_comboBox.Text != "Other"))
            {
                label103.Visible = true;

                if (string.IsNullOrWhiteSpace(Gender_comboBox.Text))
                {
                    label103.Text = "This Field is required";
                    label103.ForeColor = Color.Red;
                }
                else
                {
                    label103.Text = "Invalid Gender";
                    Gender_comboBox.Text = string.Empty;
                    label103.ForeColor = Color.Red;
                }
                return false;
            }


            DateTime Time1 = dateTimePicker1.Value.Date;
            if (!int.TryParse(Age_textBox.Text, out int age) || (age < 5 || age > 99) || age == 0 && dateTimePicker1.Value.Date >= Time1)
            {
                // label104.Visible = true;
                label105.Visible = true;
                if (age == 0 && dateTimePicker1.Value.Date >= Time1)
                {

                    label104.Text = "This Field is required";
                    label104.ForeColor = Color.Red;
                }
                else
                {
                    //label104.Text = "Age should be between 5 and 99";
                    //label104.ForeColor = Color.Red;

                    label105.Text = "Age should be between 5 and 99";
                    label105.ForeColor = Color.Red;
                }
                return false;
            }


            return true;
        }
        private void Save_btn_Click(object sender, EventArgs e)
        {
            try
            {

                if (ValidateForm())
                {

                    DateTime birthDate = dateTimePicker1.Value.Date;

                    Student11 stu = new Student11
                    {
                        FirstName = FirstName_textBox.Text.Trim(),
                        LastName = LastName_textBox.Text.Trim(),
                        Gender = Gender_comboBox.Text.Trim(),
                        Age = int.Parse(Age_textBox.Text.Trim()),
                        Stu_Class = Class_textBox.Text.Trim(),
                        Address = Address_textBox.Text.Trim(),
                        BirthDate = birthDate,
                    };

                    studentList1.Add(stu);


                    StudentDetails11 sd = new StudentDetails11(studentList1);

                    // MessageBox.Show("Student Details are Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    sd.Show();
                    Clearform();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Clearform()
        {
            FirstName_textBox.Text = "";
            LastName_textBox.Text = "";
            Gender_comboBox.SelectedIndex = -1;
            Class_textBox.Text = "";
            Age_textBox.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            Address_textBox.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Panel p = sender as Panel;
            int borderWidth = 3;

            ControlPaint.DrawBorder(e.Graphics, p.DisplayRectangle,
                Color.DarkBlue, borderWidth, ButtonBorderStyle.Solid,
                Color.DarkBlue, borderWidth, ButtonBorderStyle.Solid,
                Color.DarkBlue, borderWidth, ButtonBorderStyle.Solid,
                Color.DarkBlue, borderWidth, ButtonBorderStyle.Solid);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int age = DateTime.Now.Year - dateTimePicker1.Value.Year;

            DateTime Time1 = dateTimePicker1.Value.Date;
            if (age == 0 && dateTimePicker1.Value.Date >= Time1)
            {

                label104.Text = "This Field is required";
                label104.ForeColor = Color.Red;
            }
            if (DateTime.Now.Month < dateTimePicker1.Value.Month || (DateTime.Now.Month == dateTimePicker1.Value.Month && DateTime.Now.Day < dateTimePicker1.Value.Day))
            {
                age--;
            }


            Age_textBox.Text = age.ToString();
            DateTime currentDate = DateTime.Now;

        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            StudentDetails11 sd = new StudentDetails11(studentList1);

            sd.Show();
            this.Hide();
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            StudentDetails11 sd = new StudentDetails11();
            AddStudent11 addStudent = new AddStudent11();
            try
            {

                if (sd.dataGridView.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = sd.dataGridView.SelectedRows[0];

                    // Get the index of the selected row
                    int selectedIndex = sd.dataGridView.Rows.IndexOf(selectedRow);

                    DialogResult result = MessageBox.Show("Are you sure you want to delete this student record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {

                        studentList1.RemoveAt(selectedIndex);
                        MessageBox.Show("Record is removed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.Hide();
                    StudentDetails11 OS1 = new StudentDetails11(studentList1);
                    OS1.Show();
                }
                else
                {
                    MessageBox.Show("No student selected for deletion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LastName_textBox_Load(object sender, EventArgs e)
        {

        }

        private void Age_textBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Age_textBox.Text))
            {
                label104.Text = "This Field is required";
                label104.ForeColor = Color.Red;
                label105.Text = "This Field is required";
                label105.ForeColor = Color.Red;
                label104.Visible = true;
                label105.Visible = true;
            }
            else
            {

                label104.Visible = false;
                label105.Visible = false;
                //if(label105.Visible ) label104.Visible = false;
            }
            if (string.IsNullOrWhiteSpace(Age_textBox.Text))
            {

                dateTimePicker1.ValueChanged -= dateTimePicker1_ValueChanged;
                dateTimePicker1.Value = DateTime.Now;
                dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            }
            else
            {

                if (int.TryParse(Age_textBox.Text, out int age))
                {

                    DateTime birthDate = DateTime.Now.AddYears(-age);


                    dateTimePicker1.ValueChanged -= dateTimePicker1_ValueChanged;
                    dateTimePicker1.Value = birthDate;
                    dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
                }

                if (!Regex.IsMatch(Age_textBox.Text, "^[0-9]*$"))
                {
                    //label104.Text = "Only numbers are allowed";
                    label104.ForeColor = Color.Red;
                    Age_textBox.Text = string.Empty;
                }
            }
        }

        private void LastName_textBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LastName_textBox.Text))
            {
                label102.Text = "This Field is required";
                label102.ForeColor = Color.Red;
            }
            else
            {

                label102.Visible = false;
            }
            string LastNameTreamed = LastName_textBox.Text;

            // Remove any spaces from the input
            LastNameTreamed = LastNameTreamed.Replace(" ", "");

            if (string.IsNullOrWhiteSpace(LastNameTreamed) || !LastNameTreamed.All(c => char.IsLetter(c)) ||
                LastNameTreamed.Length < 2 || LastNameTreamed.Length > 18)
            {
                label102.Visible = true;

                if (string.IsNullOrWhiteSpace(LastNameTreamed))
                {
                    label102.Text = "This Field is required";
                    label102.ForeColor = Color.Red;
                }
                else if (!LastNameTreamed.All(c => char.IsLetter(c) || c == ' '))
                {
                    //label101.Text = "Only characters are allowed";
                    label102.ForeColor = Color.Red;
                }
                if (LastNameTreamed.Length < 2 || LastNameTreamed.Length > 18)
                {
                    label102.Text = "Length should be between 2 and 18.";
                    label102.ForeColor = Color.Red;

                }

                else { label101.Visible = false; }


                return;
            }
            else { label102.Visible = false; }
        }

        private void FirstName_textBox_TextChanged(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(FirstName_textBox.Text))
            {
                label101.Text = "This Field is required";
                label101.ForeColor = Color.Red;

            }
            else
            {

                label101.Visible = false;
            }
            string FirstNameTreamed = FirstName_textBox.Text;

            // Remove any spaces from the input
            FirstNameTreamed = FirstNameTreamed.Replace(" ", "");

            if (string.IsNullOrWhiteSpace(FirstNameTreamed) || !FirstNameTreamed.All(c => char.IsLetter(c)) || FirstNameTreamed.Length < 3 || FirstNameTreamed.Length > 15)
            {
                label101.Visible = true;

                if (string.IsNullOrWhiteSpace(FirstNameTreamed))
                {
                    label101.Text = "This Field is required";
                    label101.ForeColor = Color.Red;
                }

                else if (!FirstNameTreamed.All(c => char.IsLetter(c) || c == ' '))
                {
                    //label101.Text = "Only characters are allowed";
                    label101.ForeColor = Color.Red;
                }
                if (FirstNameTreamed.Length < 3 || FirstNameTreamed.Length > 15)
                {
                    label101.Text = "Length should be between 3 and 15.";
                    label101.ForeColor = Color.Red;
                }

                else { label101.Visible = false; }


                return;


            }
            else
                label101.Visible = false;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label105_Click(object sender, EventArgs e)
        {

        }

        private void Gender_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Gender_comboBox.Text))
            {
                label103.Text = "This Field is required";
                label103.ForeColor = Color.Red;

            }
            else
            {

                label103.Visible = false;
            }
        }

        private void FirstName_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                // Check if the current text already ends with a space
                if (FirstName_textBox.Text.EndsWith(" "))
                {
                    // Prevent the input of another space
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void LastName_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                // Check if the current text already ends with a space
                if (LastName_textBox.Text.EndsWith(" "))
                {
                    // Prevent the input of another space
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void FirstName_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((FirstName_textBox.Text.Length + 1) >= 15 && e.KeyChar != (char)Keys.Back)
            {
                label101.Visible = true;
                e.Handled = true;
                label101.Text = "Length should be between 3 and 15.";
                label101.ForeColor = Color.Red;
            }
            else
                label101.Visible = false;
        }

        private void LastName_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((LastName_textBox.Text.Length + 1) >= 18 && e.KeyChar != (char)Keys.Back)
            {
                label102.Visible = true;
                e.Handled = true;
                label102.Text = "Length should be between 2 and 18.";
                label102.ForeColor = Color.Red;
            }
            else label102.Visible = false;
        }

        private void Age_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Age_textBox.Text.Length + 1) > 2 && e.KeyChar != (char)Keys.Back)
            {
                label105.Visible = true;
                e.Handled = true;
                label105.Text = "Age should be between 5 and 99.";
                label105.ForeColor = Color.Red;
            }
            else label105.Visible = false;
        }

        private void Class_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
