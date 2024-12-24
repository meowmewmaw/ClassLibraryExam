using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryExam
{
    public class Group
    {

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string college;
        public string College
        {
            get { return college; }
            set { college = value; }
        }

        public Group(string name, string college)
        {
            Name = name;
            College = college;
        }
        public List<Student> students = new List<Student>();
        public void ShowAll()
        {
            Console.WriteLine($"Название группы {Name}, Колледж {College}\n Список студентов: ");
            foreach (Student student in students)
            {
                Console.Write( student.Name );
                Console.WriteLine( student.Ocenka );
            }
        }
    }
}
