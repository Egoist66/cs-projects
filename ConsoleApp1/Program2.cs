using ConsoleApp1.lib;
using System.Globalization;

namespace ConsoleApp1
{
    public class Program2
    {

        public static void Init()
        {
            /*string numeric = "5";
            int num = Convert.ToInt32(numeric);
            
           // C.Log(num);



            string floatNumberic = "5.5";
            NumberFormatInfo numberFormater = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };

            double a = Convert.ToDouble(floatNumberic, numberFormater);
            C.Log(a);*/

            string str = "5,9";

            double num;
            if (double.TryParse(str, out num))
            {
                C.Log("Successful");
            }
            else
            {

                C.Log("Unsuccessful");
            }




        }




    }
}

// https://www.youtube.com/watch?v=fNjVCSEXpDM&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=4&ab_channel=%23SimpleCode
/*

    Convert.ToInt32() (преобразует к типу int)

    Convert.ToDouble() (преобразует к типу double)

    Convert.ToDecimal() (преобразует к типу decimal)

 */