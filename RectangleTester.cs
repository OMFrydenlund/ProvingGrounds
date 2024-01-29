using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvingGrounds
{
    public class RectangleTester
    {
        public static void RunCalc()
        {
            Rectangle rectangle1 = new Rectangle(13.7, 19.5);
            double area = rectangle1.CalculateArea();
            Console.WriteLine("The rectangle's area is " + area);
        }
    }
}
