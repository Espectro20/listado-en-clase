using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listado._2
{
    internal class Program
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string[] Phones { get; set; }
        public bool IsActive { get; set; }
        static void Main(string[] args)
        {

            {

                using (var db = new LiteDatabase(@"MyData.db"))

                {// Get customer collection
                    var col = db.GetCollection<Customer>("customers");

                    // Create your new customer instance
                    var customer = new Customer
                    {
                        Name = "John Doe",
                        Phones = new string[] { "8000-0000", "9000-0000" },
                        Age = 39,
                        IsActive = true
                    };

                    // Create unique index in Name field
                    col.EnsureIndex(x => x.Name, true);

                    // Insert new customer document (Id will be auto-incremented)
                    col.Insert(customer);

                    // Update a document inside a collection
                    customer.Name = "Joana Doe";

                    col.Update(customer);

                    // Use LINQ to query documents (with no index)
                    var results = col.Find(x => x.Age > 20);
          public class Customer
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public string[] Phones { get; set; }
            public bool IsActive { get; set; }
        }

    }

}