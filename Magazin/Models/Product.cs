using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazin.Models
{
    [Table("Product")]
    internal class Product
    {
        static DataContext context = new DataContext();

        public int? Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public string Unit { get; set; }
        public string Category { get; set; }

        public static List<Product> View()
        {
            return context.Products.ToList();
        }

        public static void Add(string name, decimal price, int count, string unit, string category)
        {
            Product product = new Product();
            product.Name = name;
            product.Price = price;
            product.Count = count;
            product.Unit = unit;
            product.Category = category;
            product.Id = null;

            context.Products.Add(product);
            context.SaveChanges();
        }

        public static void Delete(int id)
        {
            var paket = context.Products.FirstOrDefault(a => a.Id == id);
            context.Products.Remove(paket);
            context.SaveChanges();
        }

        public static void Update(int id, string name, decimal price, int count, string unit, string category)
        {
            var paket = context.Products.FirstOrDefault(a => a.Id == id);
            paket.Name = name;
            paket.Category = category;
            paket.Unit = unit;
            paket.Count = count;
            paket.Price = price;
            //
            context.Products.Update(paket);
            context.SaveChanges();
        }
    }

    enum Category
    {
        Elektronika,
        Sport,
        Detskiy,
        OqizOvqat
    }
}
