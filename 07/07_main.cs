namespace _07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum=0;

            for(int i=1; i<=10000; i++)
            {
                if(i%3==0 && i%7==0 && i%11==0)
                {
                    sum += i;
                }

            }

            Console.WriteLine(sum);
        }
    }
}