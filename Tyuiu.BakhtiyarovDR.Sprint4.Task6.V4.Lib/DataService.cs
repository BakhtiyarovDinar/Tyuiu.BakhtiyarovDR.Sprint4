using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.BakhtiyarovDR.Sprint4.Task6.V4.Lib
{
    public class DataService : ISprint4Task6V4
    {
        public string[] Calculate(string[] array)
        {
            string[] mas = Array.FindAll(array, colors => colors.Length > 5);
            return mas;
        }
    }
}
