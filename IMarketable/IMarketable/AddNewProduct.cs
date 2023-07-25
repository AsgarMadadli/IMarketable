using IMarketable.CategoryOfProductEnum;
using IMarketable.Constructors;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IMarketable
{
    public class AddNewProduct
    {
        static void AddProduct()
        {
            Console.Write("Product name :");
            string productName = Console.ReadLine()!;
            Console.Write("Product price :");
            decimal productPrice = decimal.Parse(Console.ReadLine());
            Console.Write("Product cotegory :");
            int productCotegory = int.Parse(Console.ReadLine());
            Console.Write("Number :");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("ID :");
            int id = int.Parse(Console.ReadLine());


            //ConstructsOfProducts product = new ConstructsOfProducts(productName, productPrice, CategoryOfProduct.Smartphones, number, id);
           
        }
    }
}