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
            //Console.WriteLine("this is ans od add fun"+ans);
            int num = 10;
            refarancePara(ref num);
            Console.WriteLine("reafarance val " + num);
            int t = 0, pr = 0;
            calculateOut(10, 20, out t, out pr);
            Console.WriteLine("sum={0} product={1}", t, pr);
            SendEmail("rachel.appel@jetbrains.com", "maarten.balliauw@jetbrains.com",
    "khalid.abuhakmeh@jetbrains.com", "matt.ellis@jetbrains.com",
    "matthias.koch@jetbrains.com", "alexandra.kolesova@jetbrains.com",
    "sasha.ivanova@jetbrains.com");



        }

        public static void SendEmail(params string[] emails)
        {
            Console.WriteLine("Emails sent to:");
            foreach (var email in emails)
            {
                Console.WriteLine(email);
            }
        }

        public static void calculateOut(int fn, int sn,out int sum,out int product)
        {
            sum = fn + sn;
            product = fn * sn;
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
        public static void refarancePara(ref int j)
        {
            j += 10;
        }
    }
}
