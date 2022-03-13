using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr4V
{
    public class Spring_session:Session
    {
        public string Practic_name;
        public int Practic_grade;
        public void SetPractic_grade(int Grade)
        {
            if (Grade>=1&&Grade>=5)
            {
                Practic_grade = Grade;
            }
        }
        public override void PrintSession()
        {
            Console.WriteLine("Семестр = " + Semester + " |" +
               " Зачётов = " + Test + " |" +
               " Екзаменов = " + Exam + " |"+
               " Практика = " + Practic_name + " |"+
               " Оценка = " + Practic_grade + " |"
               );
        }
    }
}
