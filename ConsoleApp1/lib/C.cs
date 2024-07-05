

namespace ConsoleApp1.lib
{
    class C
    {

        // Logs the given message to the console after clearing the console screen.
        public static void Log(object message)
        {
            Console.Clear();
            Console.WriteLine(message);
        }
    }
}
