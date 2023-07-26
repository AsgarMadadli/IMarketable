using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMarketable.CategoryOfProductEnum;

namespace IMarketable.Constructors
{
    public class Products
    {
        public Products(string productName, decimal productPrice, CategoryOfProduct productCategory, int number, int id)
        {
            Name = productName;
            Price = productPrice;
            Category = productCategory;
            Number = number;
            Id = id;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public CategoryOfProduct Category { get; set; }
        public int Number { get; set; }
        public int Id { get; set; }
    }
}
