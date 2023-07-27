using IMarketable.Constructors;
using IMarketable.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMarketable
{
    public class ShowProductsByPriceRange
    {
        public static void ProductsByPrice()
        {
            Console.Write("Add min price : ");
            int minPrice = int.Parse(Console.ReadLine()!);
            Console.Write("Add max price : ");
            int maxPrice = int.Parse(Console.ReadLine()!);

            foreach (Products product in ProductsData.productsAll)
            {
                if (minPrice <= product.Price && maxPrice >= product.Price)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Praduct name : {product.Name} -- Product number : {product.Number} -- " +
                        $"Product price : {product.Price} -- Product category : {product.Category} -- Product Id : {product.Id}");
                    Console.WriteLine();
                }
            }
        }
    }
}
