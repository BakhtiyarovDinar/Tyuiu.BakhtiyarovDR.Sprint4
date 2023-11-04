﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.BakhtiyarovDR.Sprint4.Task1.V26.Lib
{
    public class DataService : ISprint4Task1V26
    {
        public int Calculate(int[] array)
        {
            int res = 0;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 != 0)
                {
                    res = res + array[i];
                }
            }
            return res;
        }
    }
}
