using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr4V
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Session First = new Session(5, 6);
            First.CountExam();
            First.SetExams(2, 5);
            First.CountExam();
            First.PrintSession();
            Session second = new Session("первый");
            second.PrintSession();

            Spring_session third = new Spring_session();
            third._Practic_name = "MДК 01.01";
            third._Practic_grade = Practic_grade.Н_А;


        }
    }
}
