namespace IMarketable
{
    public class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                Console.WriteLine("-1 Mehsullar uzerinde emeliyyat aparmaq");
                Console.WriteLine("-2 Satislar uzerinde emeliyyat aparmaq");
                Console.WriteLine("-3 Sistemden cixmaq");
                Console.WriteLine();

                Console.Write("Xais olunur secim edin:");
                string command = Console.ReadLine()!;
                Console.WriteLine();

                

                switch (command)
                {
                    case "1":
                        ProcessOverProduct.ProcessProduct();
                        break;
                    case "2":
                        ProcessOverSales.ProcessSales();
                        break;
                    case "3":
                        return;
                    
                }
            }
        }
    }
}