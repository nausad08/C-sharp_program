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

    public class Student
    {
        private int _id;
        private string _name;
        private int _pass = 55;
        private string _city;
        


        public string Email
        {
            get; set;
        }
        public string city
        {
            set
            {
                this._city = value;
            }
            get
            {
                return this._city;
            }
        }

        public int pass
        {
            get
            {
                return this._pass;
            }
            
        }

        //public void SetId(int id)
        //{
        //    if (id <= 0)
        //    {
        //        throw new Exception("Student id cannot be negative");
        //    }
        //    this.id = id; 
        //}
        public int Id
        {
            set {
                if ( value<= 0)
                {
                    throw new Exception("Student id cannot be negative");
                }

                this._id = value;
            }
            get
            {
                return this._id;
            }
          
        }

        //public int GetId()
        //{
        //    return this.id;
        //}
        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("name cannot be numm or empty");
                }
                this._name = value;

            }
            get
            {
                return string.IsNullOrEmpty(this._name) ? "noname" : this._name;


            }

        }
        



    }
    class Program
    {
        static void Main(string[] args)
        {
            //Employee[] emp = new Employee[4];

            //emp[0] = new Employee();
            //emp[1] = new PartTime();
            //emp[2] = new FullTime();
            //emp[3] = new TempTime();

            //foreach(Employee  e in emp)
            //{
            //    e.PrintFullName();
            //}

            Student s = new Student();
            s.Id = 3;
            s.Name ="montu";
            s.city = "burdwan";
            s.Email = "montu@gmail.com";

            Console.WriteLine("student id = {0}, name = {1}, pass={2}, email = {3}, city={4}", s.Id,s.Name,s.pass,s.Email,s.city);


        }
    }
}
