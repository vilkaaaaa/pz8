using Xunit;
using pz8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace pz8.Tests
{
    public class CalculatorTests
    {

        [Fact()]
        public void SqrtTest()
        {
            Calculator calculator = new Calculator();
            double a = 25;
            double res = 5;
            double actualres = calculator.Sqrt(a);
            Xunit.Assert.Equal(res, actualres);
        }

        [Fact()]
        public void PowTest()
        {
            Calculator calculator = new Calculator();
            double a = 6;
            double b = 2;
            double res = 36;
            double actualres = calculator.Pow(a, b);
            Xunit.Assert.Equal(res, actualres);
        }
        [Fact()]
        public void AddTest()
        {
            Calculator calculator = new Calculator();
            double a = 54;
            double b = 6;
            double res = 60;
            double actualres = calculator.Add(a, b);
            Xunit.Assert.Equal(res, actualres);
        }
        [Fact()] public void AddTest2()
        {
            Calculator calculator = new Calculator();
            double a = 54;
            double b = -5;
            double res = 49;
            double actualres = calculator.Add(a, b);
            Xunit.Assert.Equal(res, actualres);
        }

        [Fact()]
        public void SubTest()
        {
            Calculator calculator = new Calculator();
            double a = 70;
            double b = 3;
            double res = 67;
            double actualres = calculator.Sub(a, b);
            Xunit.Assert.Equal(res, actualres);
        }

        [Fact()]
        public void MultiplyTest()
        {
            Calculator calculator = new Calculator();
            double a = 8;
            double b = 5;
            double res = 40;
            double actualres = calculator.Multiply(a, b);
            Xunit.Assert.Equal(res, actualres);
        }

        [Fact()]
        public void DivideTest()
        {
            Calculator calculator = new Calculator();
            double a = 98;
            double b = 2;
            double res = 49;
            double actualres = calculator.Divide(a, b);
            Xunit.Assert.Equal(res, actualres);
        }
        [Fact]
        public void DivideByZero()
        {
            Calculator calculator = new Calculator();
            Xunit.Assert.Throws<DivideByZeroException>(() => calculator.Divide(5,0));
        }
    }
}