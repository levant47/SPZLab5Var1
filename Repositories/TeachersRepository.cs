using System.Collections.Generic;

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
    }
}

