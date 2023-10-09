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
        }

        static void Main(string[] args)
        {
            Product ball = new Product();
            ball.name = "Ronaldo's ball";
            ball.price = 14f;
            ball.weight = 1f;
            ball.brand = "Adidas";
        }
    }
}
