using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    class CalResult
    {
        public double GetBMR(double age, double weight, double height, bool isMan)
        {
            double result = 0;
            int CalConst = 0;
            if (isMan)
            {
                CalConst = 5;
            }
            else
            {
                CalConst = -161;
            }
            result = 10 * weight + 6.25 * height - 5 * age + CalConst;
            return result;
        }
        public double GetTDEE(double bmr_result, string activate)
        {
            double tdee_result = 0;
            switch (activate)
            {
                case "久坐": tdee_result = bmr_result * 1.2; break;
                case "輕量活動": tdee_result = bmr_result * 1.375; break;
                case "中度活動量": tdee_result = bmr_result * 1.55; break;
                case "高度活動量": tdee_result = bmr_result * 1.725; break;
                case "非常高度活動量": tdee_result = bmr_result * 1.9; break;
                default: tdee_result = 0; break;
            }
            return tdee_result;
        }
    }
}
