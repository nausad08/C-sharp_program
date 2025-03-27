using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("enter the C# world");
            //String UserName = Console.ReadLine();
            //Console.WriteLine("enter the C# world");
            //String UserName2 = Console.ReadLine();
            ////Console.WriteLine("okk "+ UserName);
            //Console.WriteLine("Hello {0},{1}", UserName, UserName2);
            //int i = 4,j=9,k=11;
            //int ans = k * (j / i);
            //Console.WriteLine(ans);
            //Console.WriteLine("min = {0}", int.MinValue);
            //Console.WriteLine("min = {0}", int.MaxValue);
            //string name = "\"don\"one \n two djvbhfhvbfjv";
            //Console.WriteLine(name);
            ////tarnary operator
            //int num = 10;
            //bool isNum10 = num == 10 ? true : false;
            //Console.WriteLine(isNum10);

            //parse and tryparse
            string str = "100TY";
            // Using Parse()
            //try
            //{
            //    int i = int.Parse(str);
            //    Console.WriteLine(i);

            //}
            //catch (Exception)

            //{
            //    Console.WriteLine("invalid error");
            //}
            //int res;
            //bool isConvert = int.TryParse(str, out res);
            //if (isConvert)
            //{
            //    Console.WriteLine(res);
            //}
            //else
            //{
            //    Console.WriteLine("inval");
            //}

            Program p = new Program(); // static na lagale
            p.Evennum(20);

            int ans = add(10, 20);
            Console.WriteLine("this is ans od add fun"+ans);


            



        }
         void Evennum(int target)
        {
            int st = 0;
             while(st<= target)
            {
                Console.WriteLine(st);
                st += 2;
            }
        }
        public static int add(int x, int y)
        {
            return x + y;
        }
    }
}
