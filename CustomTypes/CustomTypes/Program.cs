using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomTypes
{
    internal class Program
    {

        struct Product
        {
            public string name;
            public float price;
            public float weight;
            public string brand;

            public Product (string name, float price, float weight, string brand)
            {
                this.name = name;
                this.price = price;
                this.weight = weight;
                this.brand = brand;
            }
        }

        static void Main(string[] args)
        {
            Product ball = new Product("Ronaldinho's ball", 12f, 1f, "Adidas");
            Product bucket = new Product("Pink bucket", 8f, 2f, "Tupperware");

            Console.WriteLine(ball.name);
            Console.WriteLine(bucket.name);
            Console.ReadLine();

            
        }
    }
}
