using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr4V
{
    public enum Practic_grade
    {
        Н_А = 1,
        НЕУД = 2,
        УД = 3,
        ХОР = 4,
        ОТЛ = 5

    };
    public class Spring_session : Session
    {

        Practic_grade Practic_grade;
        protected String Practic_name;

        public string _Practic_name
        {
            get { return Practic_name; }
            set { Practic_name = value; }
        }


        public Practic_grade _Practic_grade
        {
            get { return Practic_grade; }
            set
            {

                Practic_grade = value;

            }
        }


        public override void PrintSession()
        {
            Console.WriteLine("Семестр = " + Semester + " |" +
               " Зачётов = " + Test + " |" +
               " Екзаменов = " + Exam + " |" +
               " Практика = " + Practic_name + " |" +
               " Оценка = " + Practic_grade + " |"
               );
        }
    }
}
