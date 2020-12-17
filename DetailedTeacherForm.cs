using SPZLab5Var1.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SPZLab5Var1
{
    public partial class DetailedTeacherForm : Form
    {
        private readonly Func<Teacher, bool> _onSubmit;
        private readonly Teacher _teacher;

        public DetailedTeacherForm(Teacher teacher, Func<Teacher, bool> onSubmit)
        {
            InitializeComponent();

            _teacher = teacher ?? new Teacher();
            _onSubmit = onSubmit;

            if (teacher != null)
            {
                nameTextBox.Text = teacher.Name;
                ageTextBox.Text = teacher.Age.ToString();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var errors = new List<(string, string)>();
            var name = Validation.AssertValidationPassed("Название", Validation.SafeGetNonEmptyString(nameTextBox.Text), errors);
            var age = Validation.AssertValidationPassed("Возраст", Validation.SafeGetPositiveInteger(ageTextBox.Text), errors);
            if (errors.Any())
            {
                var completeErrorMessage = errors.Aggregate("", (result, fieldErrorPair) =>
                {
                    var (field, error) = fieldErrorPair;
                    return result + field + ": " + error + "\n";
                });
                MessageBox.Show(completeErrorMessage);
                return;
            }

            _teacher.Name = name;
            _teacher.Age = (int)age;
            var wasSuccessful = _onSubmit(_teacher);
            if (wasSuccessful)
            {
                Close();
            }
        }
    }
}
