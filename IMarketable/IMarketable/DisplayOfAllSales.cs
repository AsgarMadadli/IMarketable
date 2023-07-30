using IMarketable.Constructors;
using IMarketable.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMarketable
{
    public class DisplayOfAllSales
    {
        public static void DisplaySales()
        {
            Console.WriteLine();

            foreach (Products product in ProductsData.productsAll)
            {
                Console.WriteLine();
                Console.WriteLine($"Product name : {product.Name} -- Product number : {product.Number} -- " +
                    $"Product price : {product.Price} Product id : {product.Id} -- Product catogory : {product.Category}");
                Console.WriteLine();
            }
        }
    }
}