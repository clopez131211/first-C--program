using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                inputConverter InputConverter = new inputConverter();
                Equation equation = new Equation();

                double firstnumber = InputConverter.ConvertInputToNumberic(Console.ReadLine());
                double secondnumber = InputConverter.ConvertInputToNumberic(Console.ReadLine());
                string operation = Console.ReadLine();

                double result = equation.Calculate(operation, firstnumber, secondnumber);

                Console.WriteLine(result);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
    }
    }
}