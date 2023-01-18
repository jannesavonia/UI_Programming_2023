namespace _05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give a string");
            string s=Console.ReadLine();

            if(s.Contains("cat"))
            {
                Console.WriteLine("String contained 'cat'.");
            }
            else
            {
                Console.WriteLine("String did not contain 'cat'");
            }
        }
    }
}