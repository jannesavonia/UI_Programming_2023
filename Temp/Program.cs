using System.Runtime.InteropServices;

namespace Temp
{
    internal class Program
    {
        static void print(string s)
        {
            foreach (var item in s)
            {
                Console.Write(item);
                System.Threading.Thread.Sleep(1000);
            }
        }

        static void Main(string[] args)
        {
            print("Hello World!");
        }
    }
}