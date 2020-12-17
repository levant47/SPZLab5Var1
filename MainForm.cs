using System;
using System.Windows.Forms;

namespace SPZLab5Var1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            UpdateView();
        }

        private void UpdateView()
        {
            teachersDataGridView.Rows.Clear();
            TeachersRepository.Teachers.ForEach(teacher => teachersDataGridView.Rows.Add(teacher.Name, teacher.Age));
        }

        private void teacherCreateButton_Click(object sender, EventArgs e) => new DetailedTeacherForm
        (
            newTeacher =>
            {
                TeachersRepository.Add(newTeacher);
                UpdateView();
                return true;
            }
        ).Show();

        private void teachersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}

