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
    public class DeleteProduct
    {

        public static void DeleteProducts()
        {
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());

            foreach (Products product in ProductsData.productsAll)
            {
                if (product.Id == id)
                {
                    ProductsData.productsAll.Remove(product);
                }
            }

        }
    }
}
