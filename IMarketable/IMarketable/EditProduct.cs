using IMarketable.CategoryOfProductEnum;
using IMarketable.Constructors;
using IMarketable.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMarketable
{
    public class EditProduct
    {
        public static void EditProducts()
        {
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Product name: ");
            string productName = Console.ReadLine()!;

            Console.Write("Product price: ");
            decimal productPrice = decimal.Parse(Console.ReadLine());

            Console.Write("Product category: ");
            string category = Console.ReadLine();
            Enum.TryParse(category, out CategoryOfProduct productCategory);

            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());


            foreach (Products product in ProductsData.productsAll)
            {
                if (product.Id == id)
                {
                    product.Name = productName;
                    product.Price = productPrice;
                    product.Category = productCategory;
                    product.Number = number;
                }

            }
            
           
        }
    }
}
