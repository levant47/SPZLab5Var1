using System.Collections.Generic;

namespace SPZLab5Var1.Repositories
{
    public class SubjectsRepository
    {
        public static List<Subject> Subjects = new List<Subject>
        {
            new Subject { Id = 1, Name = "Высшая Математика", Faculty = "Факультет Математики" },
            new Subject { Id = 1, Name = "Физическая Культура", Faculty = "Факультет Физической Культуры" },
            new Subject { Id = 1, Name = "Системное Програмное Обеспечение", Faculty = "Факультет Компьютерной Инженерии" },
        };
    }
}

