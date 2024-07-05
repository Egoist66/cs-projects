namespace ConsoleApp1
{
    public class Program3
    {

        public static void Init()
        {

/*

            var name = "Peter";
            var numeric = "2";

            Console.WriteLine($"My name is {name}");

            var data = int.Parse(numeric);
            //Console.Beep(1000, 1000);
            var res = Console.Equals(name, 2);

            Console.WriteLine(name.GetType());

            var obj = new GenericClass<int>(3 * 10);
       
            Console.WriteLine(obj.GenericMethod());

            Console.Write("Enter your name: ");
            string? name2 = Console.ReadLine();
            Console.WriteLine($"Hello {name2}");

            Console.WriteLine("Press any key...");
            Console.ReadKey();*/

            //    ulong a = 17878103347812890000;
            //    byte b = 200;
        

            //ushort a2 = 65535; 256 * 256
        }
    }

    public class GenericClass<T>(T value)
    {
        private readonly T genericField = value;

        public T GenericMethod()
        {
            return genericField;
        }
    }

    // Использование обобщенного класса



}

// https://www.youtube.com/watch?v=fNjVCSEXpDM&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=4&ab_channel=%23SimpleCode
/*

    Convert.ToInt32() (преобразует к типу int)

    Convert.ToDouble() (преобразует к типу double)

    Convert.ToDecimal() (преобразует к типу decimal)

 */