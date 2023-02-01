namespace _09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give an expression");

            string expr=Console.ReadLine();
            var exptree = expr.Split();

            int left = Convert.ToInt32(exptree[0]);
            string op = exptree[1];
            int right = Convert.ToInt32(exptree[2]);

            if (op == "+")
            {
                Console.WriteLine("Value is " + (left + right).ToString());
            }
            else if (op == "-")
            {
                Console.WriteLine("Value is " + (left - right).ToString());
            } else
            {
                Console.WriteLine("Unknown operator");
            }


        }
    }
}