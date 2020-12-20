using SPZLab5Var1.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SPZLab5Var1
{
    public partial class DetailedSubjectForm : Form
    {
        private readonly Subject _subject;
        private readonly Func<Subject, bool> _onSubmit;

        public DetailedSubjectForm(Subject subject, Func<Subject, bool> onSubmit)
        {
            InitializeComponent();

            _subject = subject ?? new Subject();
            _onSubmit = onSubmit;

            if (subject != null)
            {
                nameTextBox.Text = subject.Name;
                facultyTextBox.Text = subject.Faculty;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var errors = new List<(string, string)>();
            var name = Validation.AssertValidationPassed("Имя", Validation.SafeGetNonEmptyString(nameTextBox.Text), errors);
            var faculty = Validation.AssertValidationPassed("Факультет", Validation.SafeGetNonEmptyString(facultyTextBox.Text), errors);
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

            _subject.Name = name;
            _subject.Faculty = faculty;
            var wasSuccessful = _onSubmit(_subject);
            if (wasSuccessful)
            {
                Close();
            }
        }
    }
}
