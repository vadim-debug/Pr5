using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr4V
{
    public class Spring_session:Session
    {
        
        protected int Practic_grade;
        protected String Practic_name;

        public string _Practic_name
        {
            get { return Practic_name; }
            set { Practic_name = value; }
        }


        public int _Practic_grade
        {
            get { return Practic_grade; }
            set {
                if (value >= 1 && value >= 5)
                {
                    Practic_grade = value;
                }
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
