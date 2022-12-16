using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    internal class StatisticalData
    {
        // private properties
        private int num1;
        private int num2;
        private int num3;

        // acceessor methods
        public int Num1 { get { return num1; } set { num1 = value; } }
        public int Num2 { get { return num2; } set { num2 = value; } }
        public int Num3 { get { return num3; } set { num3 = value; } }

        // no argument constructor
        public StatisticalData()
        {
            num1 = 0;
            num2 = 0;
            num3 = 0;
        }

        // argument constructor
        public StatisticalData(int n1, int n2,int n3)
        {
            num1 = n1;
            num2 = n2;
            num3 = n3;
        }

        // find largest method
        public int findLargestFunction()
        {
            int result;
            if(num1 > num2 && num1 > num3)
            {
                result = num1;
            }
            else if(num2 > num1 && num2 > num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }
            return result;
        }

        // find smallest method
        public int findSmallestFunction()
        {
            int result;
            if(num1 < num2 && num1 < num3)
            {
                result = num1;
            }
            else if(num2 < num1 && num2 < num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }

            return result;
        }

        // find average method
        public double findAverageFunction()
        {
            double result;
            result = num1 + num2 + num3;
            result = Convert.ToDouble(result);
            result = result / 3;

            return result;
        }
    }
}
