using SPZLab5Var1.Repositories;
using System;
using System.Windows.Forms;

namespace SPZLab5Var1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            UpdateTeachersGrid();
            UpdateSubjectsGrid();
        }

        private void UpdateTeachersGrid()
        {
            teachersDataGridView.Rows.Clear();
            TeachersRepository.Teachers.ForEach(teacher => teachersDataGridView.Rows.Add(teacher.Name, teacher.Age));
        }

        private void UpdateSubjectsGrid()
        {
            subjectDataGridView.Rows.Clear();
            SubjectsRepository.Subjects.ForEach(subject => subjectDataGridView.Rows.Add(subject.Name, subject.Faculty));
        }

        private void teacherCreateButton_Click(object sender, EventArgs e) => new DetailedTeacherForm
        (
            null,
            newTeacher =>
            {
                TeachersRepository.Add(newTeacher);
                UpdateTeachersGrid();
                return true;
            }
        ).Show();

        private void teacherEditButton_Click(object sender, EventArgs e)
        {
            var selectedRowIndex = GetSelectedRowIndex();
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
                    UpdateTeachersGrid();
                    return true;
                }
            ).Show();
        }

        private void teacherDeleteButton_Click(object sender, EventArgs e)
        {
            var selectedRowIndex = GetSelectedRowIndex();
            if (selectedRowIndex == null)
            {
                return;
            }
            TeachersRepository.Delete(TeachersRepository.Teachers[(int)selectedRowIndex].Id);
            UpdateTeachersGrid();
        }

        private int? GetSelectedRowIndex() => teachersDataGridView.SelectedRows.Count == 1
            ? teachersDataGridView.SelectedRows[0].Index
            : teachersDataGridView.SelectedCells.Count == 1
            ? teachersDataGridView.SelectedCells[0].RowIndex
            : (int?)null;

        private void subjectCreateButton_Click(object sender, EventArgs e) => new DetailedSubjectForm
        (
            null,
            newSubject =>
            {
                SubjectsRepository.Add(newSubject);
                UpdateSubjectsGrid();
                return true;
            }
        ).Show();

        private void subjectEditButton_Click(object sender, EventArgs e)
        {
            var selectedRowIndex = GetSelectedRowIndex();
            if (selectedRowIndex == null)
            {
                return;
            }
            new DetailedSubjectForm
            (
                SubjectsRepository.Subjects[(int)selectedRowIndex],
                updatedSubject =>
                {
                    SubjectsRepository.Update(updatedSubject);
                    UpdateSubjectsGrid();
                    return true;
                }
            ).Show();
        }
    }
}

