using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionFile
{
    public class Global
    {
     public void HelloyWorld(string name)
        {
            Console.WriteLine($"привет, {name}") ;
        }
        public void sum(int a, int b)
        {
            a += b;
        }
        public int AgeToSix(int age)
        {
            return age +6;
        }
        public double d_sqrt(double a)
        {
            return Math.Sqrt(Math.Sqrt(a));
        }


    }
}
