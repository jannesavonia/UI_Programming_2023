namespace _11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give strings (END ends)");

            List<string> list = new List<string>();
            string s = "";
            do
            {
                s=Console.ReadLine();
                if(s!="END")
                {
                    list.Add(s);
                }
            } while (s != "END");

            //assignment 11
            for (int i = 0; i < list.Count; i += 2)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine("----------");

            //assignment 12
            for (int i = list.Count-1; i >=0; i --)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(list[i]);
                }
            }
        }
    }
}