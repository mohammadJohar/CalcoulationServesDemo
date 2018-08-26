using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalcoulationServesDemo.Serveses
{
    public class Operation
    {
        CalcolationServiceReference.CalculatorSoapClient clint ;

        public Operation()
        {
            clint = new CalcolationServiceReference.CalculatorSoapClient();
        }
        public int Add(int firstNum, int secNum)
        {
            return clint.Add(firstNum, secNum);
        }
        public int Divide(int firstNum, int secNum)
        {
            return clint.Divide(firstNum, secNum);
        }
        public int Multiply(int firstNum, int secNum)
        {
            return clint.Multiply(firstNum, secNum);
        }
        public int Subtract(int firstNum, int secNum)
        {
            return clint.Subtract(firstNum, secNum);
        }
    }
}