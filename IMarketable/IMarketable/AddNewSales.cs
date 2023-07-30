using IMarketable.Constructors;
using IMarketable.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMarketable.Constructors;
using IMarketable.CategoryOfProductEnum;

namespace IMarketable
{
    public class AddNewSales
    {
        public static void salesProduct()
        {
            Console.Write("Product id :");
            int productId = int.Parse(Console.ReadLine()!);
            Console.Write("Product number :");
            int productNumber = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < ProductsData.productsAll.Count; i++)
            {
                if (ProductsData.productsAll[i].Id == productId)
                {
                    string Name = ProductsData.productsAll[i].Name;
                    decimal Price  = ProductsData.productsAll[i].Price;
                    CategoryOfProduct Categ = ProductsData.productsAll[i].Category;
                    int Number = ProductsData.soldProducts[i].Number + productNumber;
                    int Id = ProductsData.productsAll[i].Id;

                    Sales soldProduct = new Sales(Name, Price, Categ, Number, Id);
                  
                    ProductsData.soldProducts.Add(soldProduct);
                    Console.WriteLine($"Sale added successfully   ID : {ProductsData.productsAll[i].Id}");
                    ProductsData.productsAll[i].Number = ProductsData.productsAll[i].Number - productNumber;
                }
            }
        }
    }
}