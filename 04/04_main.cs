namespace _04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give 1st string");
            string s1 = Console.ReadLine();

            Console.WriteLine("Give 2nd string");
            string s2= Console.ReadLine();

            if(s1.Length > s2.Length)
            {
                Console.WriteLine(s1+" is longer one.");
            } 
            else if(s1.Length < s2.Length)
            {
                Console.WriteLine(s2+" is longer one.");
            }
            else
            {
                Console.WriteLine("Both strings are same length.");
            }
        }
    }
}