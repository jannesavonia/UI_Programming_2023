namespace _08
{
    internal class Program
    {
        const int N = 4;
        static void Main(string[] args)
        {
            var list = new List<String>();

            for(int i=0; i < N; i++)
            {
                Console.WriteLine("Give string "+(i+1).ToString());
                string s=Console.ReadLine();
                list.Add(s);
            }

            //Here we have 10 strings
            //sort them
            list.Sort();

            foreach(var s in list)
            {
                Console.WriteLine(s);
            }
        }
    }
}