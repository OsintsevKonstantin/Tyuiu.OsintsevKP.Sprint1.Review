using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.OsintsevKP.Sprint1.TaskReview.V12.Lib
{
    public class DataService : ISprint1Task1V12
    {
        public double Calculate(double x, double y)
        {
            if (x == 1) return -1;
            else return Math.Round(Math.Pow((x + 1) / (x - 1),x) + 18 * x * Math.Pow(y, 2), 3);
        }
    }
}
