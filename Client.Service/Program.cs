using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsumeEventSync mathoperations = new ConsumeEventSync();


            int caseSwitch = 0;
            while (caseSwitch < 7)
            {
                Console.Clear();
                Console.WriteLine("Select number of your math option");
                Console.WriteLine("*****1*Sum***********************");
                Console.WriteLine("*****2*Subtraction***************");
                Console.WriteLine("*****3*Multiplication************");
                Console.WriteLine("*****4*Division******************");
                Console.WriteLine("*****5*Square root***************");
                Console.WriteLine("*****6*Operations by Id**********");
                Console.WriteLine("*****7*Exit**********");

                caseSwitch = int.Parse(Console.ReadLine());

                switch (caseSwitch)
                {
                    case 1:
                        Console.WriteLine("type your numbers split by , to sum it ");
                        string value = Console.ReadLine();
                        Console.WriteLine("type xid or just enter ");
                        string xid = Console.ReadLine();
                        char[] array = value.Replace(",", "").ToArray();
                        double[] numbers = array.Select(x => double.Parse(x.ToString())).ToArray();
                        Console.WriteLine(mathoperations.PostSum(numbers, xid));
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("type Minuend ");
                        double Minuend = double.Parse(Console.ReadLine());
                        Console.WriteLine("type Subtrahend ");
                        double Subtrahend = double.Parse(Console.ReadLine());
                        Console.WriteLine("type xid or just enter ");
                        xid = Console.ReadLine();
                        Console.WriteLine(mathoperations.PosSub(Minuend, Subtrahend, xid));
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("type your numbers split by , to sum it ");
                        value = Console.ReadLine();
                        Console.WriteLine("type xid or just enter ");
                        xid = Console.ReadLine();
                        array = value.Replace(",", "").ToArray();
                        numbers = array.Select(x => double.Parse(x.ToString())).ToArray();
                        Console.WriteLine(mathoperations.PostMult(numbers, xid));
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("type Dividend ");
                        double Dividend = double.Parse(Console.ReadLine());
                        Console.WriteLine("type Divisor ");
                        double Divisor = double.Parse(Console.ReadLine());
                        Console.WriteLine("type xid or just enter ");
                        xid = Console.ReadLine();
                        Console.WriteLine(mathoperations.PosDiv(Dividend, Divisor, xid));
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("type Square root number ");
                        double Sqr = double.Parse(Console.ReadLine());
                        Console.WriteLine("type xid or just enter ");
                        xid = Console.ReadLine();
                        Console.WriteLine(mathoperations.PosSqr(Sqr, xid));
                        Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine("type xid");
                        xid = Console.ReadLine();
                        Console.WriteLine(mathoperations.Posidx(xid));
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("try new option");
                        break;
                }
            }
        }
    }
}
