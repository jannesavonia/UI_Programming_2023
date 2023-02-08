using System;

namespace Strings
{
    class Program
    {
        /*       static void Main(string[] args)
               {
                   string userInput = Console.ReadLine();
                   int counter = 0;
                   string[] strings = new string[100];

                   while (userInput != "END")
                   {
                       strings[counter] = userInput;
                       userInput = Console.ReadLine();
                       counter++;
                   }

                   for (int i = 0; i < counter; i = i + 2)
                   {
                       Console.WriteLine(strings[i]);
                   }
               }*/

        public class Car
        {
            private decimal odometer;
            public decimal Odometer
            {
                get { return odometer; }
                private set { odometer = value; }
            }

            public void Drive(decimal kms)
            {
                if (kms <= 0)
                {
                    throw new ArgumentException("Distance must be greater than 0");
                }
                odometer += kms;
            }
        }


        static void Main(string[] args)
        {

            List<Car> carList = new List<Car>();
            for (int i = 0; i < 10; i++)
            {
                Car car = new Car();
                car.Drive(1000);
                carList.Add(car);
            }



        }

    }
}


