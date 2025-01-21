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
            if (b == 0) throw new DivideByZeroException("Деление на 0 - ошибка");
            return a/b;
        }
    }
}
