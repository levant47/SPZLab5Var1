using System.Collections.Generic;

namespace SPZLab5Var1
{
    public static class TeachersRepository
    {
        public static List<Teacher> Teachers = new List<Teacher>()
        {
            new Teacher { Name = "Иван Иванов", Age = 20 },
            new Teacher { Name = "Петр Петров", Age = 30 },
            new Teacher { Name = "Василий Василев", Age = 40 },
        };
    }
}

