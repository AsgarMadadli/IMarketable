using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace IMarketable
{
    public class ProcessOverProduct
    {

        public static void ProcessProduct()
        {
            Console.WriteLine(" - 1 Yeni mehsul elave et");
            Console.WriteLine(" - 2 Mehsul uzerinde duzelis et ");
            Console.WriteLine(" - 3 Mehsulu sil - mehsulun ID-si daxil edilmelidir");
            Console.WriteLine(" - 4 Butun mehsullari goster");
            Console.WriteLine(" - 5 Categoriyasina gore mehsullari goster ");
            Console.WriteLine(" - 6 Qiymet araligina gore mehsullari goster");
            Console.WriteLine(" - 7 Mehsullar arasinda ada gore axtaris et ");

            Console.Write("Xais olunur secim edin:");
            string command = Console.ReadLine()!;
            

            switch (command)
            {
                case "1":
                    AddNewProduct.AddProduct();
                    break;
                case "2":
                    EditProduct.EditProducts();
                    break;
                case "3":
                    DeleteProduct.DeleteProducts();
                    break;
                case "4":
                    ShowProducts.ShowProduct();
                    break;
                case "5":
                    ShowProductsForCategory.productWithCategory();
                    break;
                case "6":
                    ShowProductsByPriceRange.ProductsByPrice();
                    break;
                case "7":
                    SearchProductsByName.ProductsByName();
                    break;

            }
        }
    }
}
