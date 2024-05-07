namespace ConsoleApp1
{
    public class Program2
    {



        public static void Init()
        {



            var name = "Peter";
            var numeric = "2";

            Console.WriteLine($"My name is {name}");

            var data = int.Parse(numeric);
            //Console.Beep(1000, 1000);
            var res = Console.Equals(name, 2);

            Console.WriteLine(name.GetType());

            var obj = new GenericClass<int>(3 * 10);

            Console.WriteLine(obj.GenericMethod());


            Console.Write("Введите свое имя: ");
            string? name2 = Console.ReadLine();
            Console.WriteLine($"Привет {name2}");

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


/*

    Convert.ToInt32() (преобразует к типу int)

    Convert.ToDouble() (преобразует к типу double)

    Convert.ToDecimal() (преобразует к типу decimal)

 */