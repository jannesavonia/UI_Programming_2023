using System.Security.Claims;

namespace _13
{
    internal class Program
    {
        static uint Next(uint n)
        {
            if(n%2==0)
            {
                return n / 2;
            }

            return 3 * n + 1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Give N0");
            uint n = Convert.ToUInt32(Console.ReadLine());

            List<uint> sequence = new List<uint>();

            do
            {
                sequence.Add(n);
                n = Next(n);
            } while (n != 1);
            sequence.Add(n);

            foreach(uint u in sequence)
            {
                Console.WriteLine(u);
            }

            Console.WriteLine("Length of the sequence was "+sequence.Count.ToString());

            Console.WriteLine("The largest item in the sequence is "+sequence.Max());

        }
    }
}