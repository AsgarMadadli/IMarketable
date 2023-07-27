using IMarketable.CategoryOfProductEnum;
using IMarketable.Constructors;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using IMarketable.Data;

namespace IMarketable
{


    public class AddNewProduct
    {
       public static void AddProduct()
       {
            Console.Write("Product name :");
            string productName = Console.ReadLine()!;

            Console.Write("Product price :");
            int productPrice = int.Parse(Console.ReadLine()!);

            Console.Write("Product category :");
            string category = Console.ReadLine()!;
            Enum.TryParse(category, out CategoryOfProduct productCategory);

            Console.Write("Product number :");
            int productNumber = int.Parse(Console.ReadLine()!);

            Console.Write("Product Id :");
            int productId = int.Parse(Console.ReadLine()!);

            Products product = new Products(productName, productPrice, productCategory, productNumber, productId);
            ProductsData.productsAll.Add(product);
       }
    }

}