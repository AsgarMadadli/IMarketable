using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMarketable.CategoryOfProductEnum;

namespace IMarketable.Constructors
{
    public class ConstructsOfProducts
    {
        public ConstructsOfProducts(string name, decimal price, CategoryOfProduct category, int number, int id)
        {
            Name = name;
            Price = price;
            Category = category;
            Number = number;
            Id = id;
        }

        public string Name { get; set; }
        public decimal Price  { get; set; }
        public CategoryOfProduct Category { get; set; }
        public int Number { get; set; }
        public int Id { get; set; }
    }
}
