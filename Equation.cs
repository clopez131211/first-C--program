using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    public class Equation
    {
        public double Calculate(string argOperation, double argfirstnumber, double argsecondnumber)
        {
        double result; 
        switch(argOperation.ToLower())
            {
                case "add":
                case "+":
                    result = argfirstnumber + argsecondnumber;
                    break;
         

                case "subtract":
                case "-":
                    result = argfirstnumber - argsecondnumber;
                    break;

                case "multiply":
                case "*":
                    result = argfirstnumber * argsecondnumber;
                    break;

                case "divide":
                case "/":
                    result = argfirstnumber / argsecondnumber;
                    break;
                default:
                    throw new InvalidOperationException("Specified action is not recognized");
            }
            return result; 
        }
    }
}
