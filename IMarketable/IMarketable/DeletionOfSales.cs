using IMarketable.Constructors;
using IMarketable.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMarketable
{
    public class DeletionOfSales
    {
        public static void DeleteSales()
        {
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine()!);

            foreach (Products product in ProductsData.soldProducts)
            {
                if (product.Id == id)
                {
                    ProductsData.soldProducts.Remove((Sales)product);
                }
            }
        }
    }
}
