using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryExam
{
    internal class Group
    {
        public string Name;
        public string College;
        public List<Student> students;
        public void ShowAll()
        {
            Console.WriteLine($"Название группы {Name}, Колледж {College}\n Список студентов: ");
            foreach (Student student in students)
            {
                Console.WriteLine( student.Name );
            }
        }
    }
}
