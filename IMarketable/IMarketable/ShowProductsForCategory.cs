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
    public class ShowProductsForCategory
    {
        public static void productWithCategory()
        {
            Console.WriteLine("Notebook - 0");
            Console.WriteLine("Television - 1");
            Console.WriteLine("Smartphones - 2");

            Console.WriteLine();

            Console.Write("Choose category :");
            string category = Console.ReadLine();
            Enum.TryParse(category, out CategoryOfProduct categoryEnum);
            foreach (Products product in ProductsData.productsAll)
            {
                if (product.Category == categoryEnum)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Product name : {product.Name} -- Product number : {product.Number} -- " +
                        $"Product category : {product.Category} -- Product price : {product.Price} -- Product id : {product.Id}");
                    Console.WriteLine();
                }

            }
        }
    }
}