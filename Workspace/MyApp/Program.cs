using System;
using Newtonsoft.Json;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crerate product object
            var product1 = new Product { ID = 101, Name = "Red Apple", Price = 1.99};

            //Serialize the product object to JSON string
            var jsonString = JsonConvert.SerializeObject(product1);
            Console.WriteLine(jsonString);

            //Deserialize the JSON string back to the product object
            var product2 = JsonConvert.DeserializeObject<Product>(jsonString);
            Console.WriteLine($"The product ID is {product2.ID}");
            Console.WriteLine($"The product Name is {product2.Name}");
            Console.WriteLine($"The product Price is {product2.Price}");

            Console.ReadLine();
        }
    }
    //Create model class
    class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
