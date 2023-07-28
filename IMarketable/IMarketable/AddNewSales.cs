using IMarketable.Constructors;
using IMarketable.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMarketable
{
    public class AddNewSales
    {
        public static void salesProduct()
        {
            Console.Write("Product id :");
            int productId = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < ProductsData.productsAll.Count; i++)
            {
                if (ProductsData.productsAll[i].Id == productId)
                {
                    ProductsData.soldProducts.Add(ProductsData.productsAll[i]);
                    Console.WriteLine($"Satis ugurla elave edildi    ID : {ProductsData.productsAll[i].Id}");
                    ProductsData.productsAll.Remove(ProductsData.productsAll[i]);
                }               
            }
        }
    }
}