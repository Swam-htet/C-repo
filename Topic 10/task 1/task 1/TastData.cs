using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    internal class TastData
    {
        private int powerNumber;
        private int baseNumber;

        // constructor
        public TastData(int b, int p)
        {
            powerNumber = p;
            baseNumber = b;
        }


        // getter setter
        public int PowerNumber { get => powerNumber; set => powerNumber = value; }
        public int BaseNumber { get => baseNumber; set => baseNumber = value; } 

        // calculate power method
        public double calculatePower()
        {
            double result = baseNumber;
            // for power = 0

           
            if(powerNumber == 0)
            {
                return 0;
            }
            // for base maximum and pwoer > 0
            if(baseNumber == Int32.MaxValue && powerNumber > 0)
            {
                return Int32.MaxValue;
            }
            // calculating result
            for(int i = 0; i < powerNumber -1; i++)
            {
                result *= baseNumber;
            }
            return result;
        }


    }
}
