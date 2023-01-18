namespace _06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give 1st number");
            int x=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give 2nd number");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give operator");
            string op=Console.ReadLine();

            if(op=="+")
            {
                Console.WriteLine($"{x} + {y} = {x+y}");
            } else
            {
                Console.WriteLine($"{x} - {y} = {x-y}");

            }


        }
    }
}