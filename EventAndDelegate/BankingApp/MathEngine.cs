using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    public delegate void arthimaticOperations(int num1 , int num2);
    public class MathEngine
    {

        public int result {  get; set; }
        public void addition(int num1, int num2)
        {
            result = num1 + num2;
        }

        public void substraction(int num1, int num2)
        {
            result = num1 - num2;
        }

    }
}
