
using System.Windows.Forms;
using StudentManagementSystem.Models;

namespace StudentManagementSystem
{
    public partial class StudentDetails11 : Form
    {
        private List<Student11> studentList = new List<Student11>();

        int Index;
        public StudentDetails11()
        {
            InitializeComponent();

            studentList.Add(new Student11 { FirstName = "Ulhas", LastName = "Sonkusre", Gender = "Male", Age = 28, Stu_Class = "Class - A", Address = "Navi Mumbai", BirthDate = new DateTime(1996, 1, 12) });
            studentList.Add(new Student11 { FirstName = "Navya", LastName = "Patel", Gender = "Female", Age = 26, Stu_Class = "Class - B", Address = "Banglore", BirthDate = new DateTime(1998, 1, 18) });



            foreach (var student in studentList)
            {
                dataGridView.Rows.Add(
                    student.FirstName,
                    student.LastName,
                    student.Gender,
                    student.Age,
                    student.Stu_Class,
                    student.Address);
            }
            if (dataGridView.Rows.Count > 2)
                dataGridView.Rows[2].Selected = true;

            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            if (dataGridView.Rows.Count > 0)
            {
                dataGridView.Rows[0].Selected = true;
                dataGridView.CurrentCell = dataGridView.Rows[0].Cells[0];
            }
        }
        

        public StudentDetails11(List<Student11> newStudentList)
        {

            InitializeComponent();
            dataGridView.Rows.Clear();

            studentList = newStudentList;
            foreach (var student in studentList)
            {
                dataGridView.Rows.Add(
                    student.FirstName,
                    student.LastName,
                    student.Gender,
                    student.Age,
                    student.Stu_Class,
                    student.Address);
            }
        }


        private void Search_textBox_TextChanged(object sender, EventArgs e)
        {
            

            string searchText = Search_textBox.Text.ToLower();

           
            List<Student11> filteredList = new List<Student11>();
            foreach (var student in studentList)
            {
                if (student.FirstName.ToLower().Contains(searchText) ||
                    student.LastName.ToLower().Contains(searchText) ||
                  student.Age.ToString().Contains(searchText))
                {
                    filteredList.Add(student);
                }
            }

            dataGridView.Rows.Clear();
            foreach (var student in filteredList)
            {
                dataGridView.Rows.Add(student.FirstName,
                    student.LastName,
                    student.Gender,
                    student.Age,
                    student.Stu_Class);
            }
        }
       
        private void EditForm(Student11 student,int index)
        {
            
            EditStudent11 editForm = new EditStudent11(student,index);
            editForm.StudentList.AddRange(studentList);
            editForm.Show();
        }
        private void Add_Click(object sender, EventArgs e)
        {
            AddStudent11 addStudent = new AddStudent11(studentList);
            addStudent.Show();
            this.Hide();
        }
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void StudentDetails11_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < studentList.Count && e.ColumnIndex >= 0)
            {
                EditStudent11 Edit = new EditStudent11();
                EditForm(studentList[e.RowIndex], e.RowIndex);
                this.Hide();
            }

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
        
           
        
    }
}
