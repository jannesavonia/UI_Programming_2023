//Contains solution of 14...19

namespace _14
{
    class Car
    {
        public static List<Car> cars = new List<Car>();
        public static int counter = 0;
        public decimal odometer = 0;
        public void Drive(decimal kms)
        {
            if (kms <= 0)
            {
                throw new ArgumentOutOfRangeException("kms<0");
            }
            odometer += kms;
        }
        public Car()
        {
            counter++;
            cars.Add(this);
        }

        static public void DriveAll(decimal kms)
        {
            foreach (Car car in cars)
            {
                car.Drive(kms);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();

            Console.WriteLine(car.odometer);
            car.Drive(10);
            Console.WriteLine(car.odometer);

            try
            {
                car.Drive(-10);
            } catch {
                Console.WriteLine("Got an exception");
            }

            const int N = 10;

            var carlist=new List<Car>();

            for(int i=0; i<N; i++)
            {
                carlist.Add(new Car());
            }

            foreach(var c in carlist)
            {
                c.Drive(1000);
            }

            var rnd=new Random();   

            foreach (var c in carlist)
            {
                try
                {
                    c.Drive(rnd.Next(-10, 501));
                }
                catch
                {
                    Console.WriteLine("Got an exception here!");
                }
            }


            Console.WriteLine(Car.counter);

            Car.DriveAll(10);
        }
    }
}