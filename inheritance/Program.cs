using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance

{
    public class Employee
    {

        public string fname;
        public string lname;
        public string email;
        public Employee()
        {
            //Console.WriteLine("parent constructor caalled...");
        }
        public Employee(string msg)
        {
            //Console.WriteLine(msg);
        }
        public void PrintName()
        {
            Console.WriteLine(fname + " " + lname);
        }
    }
     public class Fulltime : Employee
    {
        public float yrlysal;
        public Fulltime() :base("derived calass controlling parent class")
        {
            //Console.WriteLine("child constructor caalled...");
        }

        public new void PrintName()
        {
            base.PrintName();
            Console.WriteLine(fname + " " + lname+"  ..child...");
        }


    }
    public class PartTime : Employee
    {
       public float hourlysal;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fulltime ft = new Fulltime();
            ft.fname = "donn";
            ft.lname = "sanku";
            ft.email = "donsanku@gmail.com";
            ft.yrlysal = 3333333;
            ft.PrintName();
            //Console.WriteLine("sal  " + ft.yrlysal);
            //((Employee)ft).PrintName();

            //or
            Employee ram = new Fulltime();
            ram.fname = "rammm";
            ram.lname = "sammm";
            ram.PrintName();

        }
    }
}
