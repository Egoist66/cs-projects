

namespace ConsoleApp1
{

    class Program
    {
        static void Main()
        {
            string[] arr = ["farid", "jack", "peter"];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].ToUpper());
            }

            string[] arr2 = ["farid", "jack", "peter"];

            //Console.Write(arr2.GetType());

            string str = "Это строка\nкоторую нужно\nразделить";
            char[] separators = ['\n']; // Массив символов-разделителей

            string[] parts = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach (string part in parts)
            {
                Console.WriteLine(part);
            }

            Program2.Init();
        }
    }
}

