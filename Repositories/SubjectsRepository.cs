using System.Collections.Generic;
using System.Linq;

namespace SPZLab5Var1.Repositories
{
    public class SubjectsRepository
    {
        public static List<Subject> Subjects = new List<Subject>
        {
            new Subject { Id = 1, Name = "Высшая Математика", Faculty = "Факультет Математики" },
            new Subject { Id = 2, Name = "Физическая Культура", Faculty = "Факультет Физической Культуры" },
            new Subject { Id = 3, Name = "Системное Програмное Обеспечение", Faculty = "Факультет Компьютерной Инженерии" },
        };

        public static void Add(Subject newSubject)
        {
            newSubject.Id = Subjects.OrderByDescending(subject => subject.Id).Select(subject => subject.Id).FirstOrDefault() + 1;
            Subjects.Add(newSubject);
        }

        public static void Update(Subject newSubject) =>
            Subjects = Subjects.Select(subject => subject.Id == newSubject.Id ? newSubject : subject).ToList();
    }
}

