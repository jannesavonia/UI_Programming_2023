namespace _10
{
    internal class Program
    {
        static List<string> AskList(string msg)
        {
            List<string> list = new List<string>();

            string s;
            do
            {
                Console.WriteLine(msg);
                s = Console.ReadLine();
                if (s != "")
                {
                    list.Add(s);
                }
            } while (s != "");

            return list;    
        }
        static void Main(string[] args)
        {
            List<string> firstNames = AskList("Give first name");
            List<string> lastNames = AskList("Give last name");
            List<string> allCombinations = new List<string>();

            foreach(string firstName in firstNames) {
                foreach (string lastName in lastNames)
                {
                    allCombinations.Add(firstName + " " + lastName);
                } 
            }

            foreach(string s in allCombinations)
            {
                Console.WriteLine(s);
            }
        }
    }
}