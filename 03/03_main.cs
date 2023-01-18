namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give first string : ");
            string firstString = Console.ReadLine();

            Console.Write("Give second string : ");
            string secondString = Console.ReadLine();

            if (String.Compare(firstString, secondString) == 0)
            {
                Console.WriteLine("The strings are equal : " + firstString);
            }
            else if (String.Compare(firstString, secondString) < 0)
            {
                Console.WriteLine("The first in alhabetical order is " + firstString);
            }
            else
            {
                Console.WriteLine("The first string in alphabetical order is "
                    + secondString);
            }
        }
    }
}