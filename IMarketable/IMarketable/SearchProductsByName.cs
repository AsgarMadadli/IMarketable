using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using IMarketable.Constructors;
using IMarketable.Data;


namespace IMarketable
{
    public class SearchProductsByName
    {
        public static void ProductsByName()
        {
            Console.Write("Add product name : ");

            string productName = Console.ReadLine()!;

            foreach (Products product in ProductsData.productsAll)
            {
                if (product.Name == productName)
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
