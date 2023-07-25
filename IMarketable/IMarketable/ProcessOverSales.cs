using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace IMarketable
{
    public class ProcessOverSales
    {
        public static void ProcessSales()
        {
            Console.WriteLine(" - 1 Yeni satis elave etmek");
            Console.WriteLine(" - 2 Satisdaki hansisa mehsulun geri qaytarilmasi");
            Console.WriteLine(" - 3 Satisin silinmesi");
            Console.WriteLine(" - 4 Butun satislarin ekrana cixarilmasi");
            Console.WriteLine(" - 5 Verilen tarix araligina gore satislarin gosterilmesi");
            Console.WriteLine(" - 6 Verilen mebleg araligina gore satislarin gosterilmesi");
            Console.WriteLine(" - 7 Verilmis bir tarixde olan satislarin gosterilmesi");
            Console.WriteLine("  - 8 Verilmis ID-ya esasen hemin ID-li satisin melumatlarinin gosterilmesi");

            Console.Write("Xais olunur secim edin:");
            string command = Console.ReadLine()!;

        }
    }
}