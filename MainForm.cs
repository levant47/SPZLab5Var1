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
            null,
            newTeacher =>
            {
                TeachersRepository.Add(newTeacher);
                UpdateView();
                return true;
            }
        ).Show();

        private void teacherEditButton_Click(object sender, EventArgs e)
        {
            var selectedRowIndex = teachersDataGridView.SelectedRows.Count == 1
                ? teachersDataGridView.SelectedRows[0].Index
                : teachersDataGridView.SelectedCells.Count == 1
                ? teachersDataGridView.SelectedCells[0].RowIndex
                : (int?)null;
            if (selectedRowIndex == null)
            {
                return;
            }
            new DetailedTeacherForm
            (
                TeachersRepository.Teachers[(int)selectedRowIndex],
                updatedTeacher =>
                {
                    TeachersRepository.Update(updatedTeacher);
                    UpdateView();
                    return true;
                }
            ).Show();
        }
    }
}

