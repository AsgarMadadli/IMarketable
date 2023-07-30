using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMarketable.Data;

namespace IMarketable
{
    public class ReturningBackOfSale
    {
        public static void ReturnBackSale()
        {
            Console.Write("Product id :");
            int productId = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < ProductsData.productsAll.Count; i++)
            {
                if (ProductsData.productsAll[i].Id == productId)
                {
                    ProductsData.productsAll.Add(ProductsData.productsAll[i]);
                    Console.WriteLine($"Sale retured back successfully    ID : {ProductsData.soldProducts[i].Id}");
                    ProductsData.soldProducts.Remove((Constructors.Sales)ProductsData.productsAll[i]);
                }
            }


        }

    }
}