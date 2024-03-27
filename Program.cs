using System.Globalization;
using System.Threading.Channels;

namespace Objects
{
    class Car
    {
        public string model;
        public string color;
        public string speed;
        public int year;

        public Car(string modelName, string modelColor, string maxSpeed, int yearOfProdcution) //constructor
        {
            model = modelName;
            color = modelColor;
            speed = maxSpeed;
            year = yearOfProdcution;
        }

    }

    class Motorbike : Car
    {
        public Motorbike(string modelName, string modelColor, string maxSpeed, int yearOfProdcution) : base(modelName, modelColor, maxSpeed, yearOfProdcution) //constructor
        {
            model = modelName;
            color = modelColor;
            speed = maxSpeed;
            year = yearOfProdcution;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Car Ford = new Car("Mustang", "White", "220 MPH", 1969); // this call the constructor with parameteres
            Console.WriteLine(Ford.model + " - " + Ford.color + " - " + Ford.speed + " - " + Ford.year);

            Motorbike Junak = new Motorbike("Junak", "Black", "165 KM/H", 1981);
            Console.WriteLine(Junak.model + " - " + Junak.color + " - " + Junak.speed + " - " + Junak.year);


        }
    }
}