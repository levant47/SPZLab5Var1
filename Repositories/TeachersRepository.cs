using System.Collections.Generic;
using System.Linq;

namespace SPZLab5Var1
{
    public static class TeachersRepository
    {
        public static List<Teacher> Teachers = new List<Teacher>()
        {
            new Teacher { Id = 1, Name = "Иван Иванов", Age = 20 },
            new Teacher { Id = 2, Name = "Петр Петров", Age = 30 },
            new Teacher { Id = 3, Name = "Василий Василев", Age = 40 },
        };

        public static void Add(Teacher newTeacher)
        {
            newTeacher.Id = Teachers.OrderByDescending(teacher => teacher.Id).Select(teacher => teacher.Id).FirstOrDefault() + 1;
            Teachers.Add(newTeacher);
        }

        public static void Update(Teacher newTeacher) =>
            Teachers = Teachers.Select(teacher => teacher.Id == newTeacher.Id ? newTeacher : teacher).ToList();
    }
}

