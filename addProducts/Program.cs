using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace addProducts
{
    internal class Program
    {
        static Entities db = new Entities();
        static void Main(string[] args)
        {
            var jsonFile = File.ReadAllText(@"data\products.json");
            var products = JsonConvert.DeserializeObject<List<Products>>(jsonFile);
            try
            {
                foreach (var item in products)
                {
                    db.Products.Add(item);
                    Console.WriteLine(JsonConvert.SerializeObject(item, Formatting.Indented));
                }
                db.SaveChanges();
                Console.WriteLine("Успешно!");
            }
            catch (DbEntityValidationException ex)
            {
                Console.WriteLine(ex);
            }
            Console.ReadLine();
        }

    }
}
