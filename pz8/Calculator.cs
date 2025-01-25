using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz8
{
    public class Calculator
    {
        public double Add(double a, double b)=>a+b;
        public double Sub(double a, double b) => a - b;
        public double Multiply(double a, double b) => a * b;
         public double Divide(double a, double b)
  {
      if (b == 0)
      {
          Console.WriteLine("Деление на 0 - ошибка");
            throw new DivideByZeroException("Деление на 0 - ошибка");
        
      }
      else{ return a / b; }
      
  }
        public double Sqrt(double a)=>Math.Sqrt(a);
        public double Pow(double a, double b) => Math.Pow(a,b);
    }
}
