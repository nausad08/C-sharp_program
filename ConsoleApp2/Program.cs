using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2

{
    class car
    {
        string coler;
        int speed;

        public car() 
            //: this("no first name providerd")
        {
            Console.WriteLine("default call....");
        }
        public car(string color,int speed)
        {
            this.coler = color;
            this.speed = speed;
            Console.WriteLine("constructor called ...");

        }
        public void print()
        {
            Console.WriteLine("Full name = {0} ", this.coler + " " + this.speed);
        }

        //destructor has same name as class it does not have parameter
        ~car()
        {
              //clean up code goes here
        }
    }

    class circle {
        public static float pi = 3.14F; // static
        int red;  //instance 

        public circle(int rad)
        {
            this.red = rad;
        }
        static circle()
        {
            Console.WriteLine("static called"); 
        }
        public float calArea()
        {
            return circle.pi * this.red * this.red;
        }
         //static method
         public static void print()
        {
            Console.WriteLine("priented ... ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //car jep = new car("blue",20);
            //car thar = new
            //car();
            //jep.print();
            //circle c1 = new circle(6);
            //float area =c1.calArea();
            //Console.WriteLine(area);
            //circle.print();

            //circle c2 = new circle(9);
            //float area2 = c2.calArea();
            //Console.WriteLine(area2);
            Console.WriteLine(circle.pi);
        }
    }
}
