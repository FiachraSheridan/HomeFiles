using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57_Leaf_Clover_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double clover = 1 - 0.40;
            
            
            Console.WriteLine("What is the base proc chance of the item?(As a decimal)");
            double proc1 = double.Parse(Console.ReadLine());
            Console.WriteLine("How many clovers do you have?");
            double cloverAmount = double.Parse(Console.ReadLine());
            Console.WriteLine("What is the Proc Coefficient of your character(as a decimal)?");
            double procCo = double.Parse(Console.ReadLine());
            double endProc = 1 - proc1;
            double endClover = cloverAmount + 1;
            double power = Math.Pow(endProc, endClover);
            double end = 1 - power;
            double endAfterProc = end * procCo;
            Console.WriteLine("The chance for your item to proc before the proc Coefficient is {0}", end);
            Console.WriteLine("THe chance for your item to proc afterthe proc Coefficient is {0}", endAfterProc);
            Console.ReadLine();
        }
    }
}
