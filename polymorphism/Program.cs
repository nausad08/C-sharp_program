using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    public class Employee
    {
        public string fname = "fn";
        public string lname = "ln";

        public virtual void PrintFullName()
        {
            Console.WriteLine(fname + " " + lname);
        }
    }
    public class PartTime : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(fname + " " + lname+"  part timee");
        }

    }
    public class FullTime : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(fname + " " + lname+ " full time...");
        }

    }
    public class TempTime : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(fname + " " + lname+ " tempp time ... ");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] emp = new Employee[4];

            emp[0] = new Employee();
            emp[1] = new PartTime();
            emp[2] = new FullTime();
            emp[3] = new TempTime();

            foreach(Employee  e in emp)
            {
                e.PrintFullName();
            }


        }
    }
}
