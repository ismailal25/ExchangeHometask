using System.Security.Authentication;

namespace ExchangeHometask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] exchange = { 18.94, 0.59, 0.54 };
            string[] exchangeTypes = { "TL", "USD", "EUR" };

            while (true)
            {
                Console.WriteLine("Meblegi Daxil edin");
                double input = 0;
                
                while (true)
                {
                    input=double.Parse(Console.ReadLine());

                    if (input > 0)
                    {
                        break;

                    }
                    else
                    {
                        Console.WriteLine("Meblegi duzgun daxil edin");
                    }

                
                    Console.WriteLine("Valyuta secin");

                }
                    int index = 0;

                    while (index< exchangeTypes.Length)
                    {
                        Console.WriteLine($"{index + 1}.{exchangeTypes[index]}");
                        index++;
                    }



                int select = 0;
                while (true)
                {
                    select = Convert.ToInt32(Console.ReadLine());
                    if (select > 0 && select <= exchangeTypes.Length)
                    {
                        break;

                    }
                    else
                    {

                        Console.WriteLine("Duzgun secim edin");

                    }

                }

                double sum = 0;

                sum = input * exchange[select - 1];

                Console.WriteLine($"Valyuta cevirilmesi : {sum} {exchangeTypes[select - 1]}");

                Console.WriteLine(" Yeni valyuta daxil etmek istiyersiz ?  devam etme halinda Y/Yes veya eks halda Exit daxil edin");

                while (true)
                {
                    string userWrite = Console.ReadLine();
                    if (userWrite == "Exit") 
                    {

                        return;
                    
                    
                    }
                    else if (userWrite != "Yes" && userWrite != "Y")
                    {
                        Console.WriteLine("Duzgun daxil edin");

                    }
                    else
                    {
                        break;

                    }

                }



            }








        }




    }
}
