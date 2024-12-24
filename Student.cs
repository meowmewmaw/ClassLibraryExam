using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryExam
{
    public class Student
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private double ocenka;

        public Student(string name, double ocenka)
        {
            Name = name;
            Ocenka = ocenka;
        }

        public double Ocenka
        {
            get { return ocenka; }
            set { ocenka = value; }
        }
        public void Show()
        {
            Console.WriteLine($"Имя {Name}, Оценка {Ocenka}");
        }
    }
}
