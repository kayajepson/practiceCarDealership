// using System;
// using System.Collections.Generic;
//
// namespace Dealership {
//
//   public class Program
//   {
//     public static void Main()
//     {
//       Car porsche = new Car("2014 Porsche 911", 114991, 7864, "The car is blue");
//       Car ford = new Car("2011 Ford F450", 55995, 14241, "Red");
//       Car lexus = new Car("2013 Lexus RX 350", 44700, 20000, "Black");
//       Car mercedes = new Car("Mercedes Benz CLS550", 39900, 37979, "Green");
//
//       List<Car> Cars = new List<Car>() { porsche, ford, lexus, mercedes };
//
//       Console.WriteLine("Enter maximum price: ");
//       string stringMaxPrice = Console.ReadLine();
//       int maxPrice = int.Parse(stringMaxPrice);
//
//       Console.WriteLine("Enter maximum miles: ");
//       string stringMaxMiles = Console.ReadLine();
//       int maxMiles = int.Parse(stringMaxMiles);
//
//       List<Car> CarsMatchingSearch = new List<Car>(0);
//
//       foreach (Car automobile in Cars)
//       {
//         if (automobile.WorthBuying(maxPrice) && automobile.WorthMiles(maxMiles))
//         {
//           CarsMatchingSearch.Add(automobile);
//         } else if (!automobile.WorthBuying(maxPrice) && !automobile.WorthMiles(maxMiles)) {
//           Console.WriteLine("Lower your standards");
//           break;
//         }
//       }
//
//       foreach(Car automobile in CarsMatchingSearch)
//       {
//         Console.WriteLine("----------------------");
//         Console.WriteLine(automobile.GetMakeModel());
//         Console.WriteLine(automobile.GetMiles() + " miles");
//         Console.WriteLine("$" + automobile.GetPrice());
//         Console.WriteLine(automobile.GetColor());
//       }
//     }
//   }
//
// }


using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace CarDealership
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var host = new WebHostBuilder()
        .UseKestrel()
        .UseContentRoot(Directory.GetCurrentDirectory())
        .UseIISIntegration()
        .UseStartup<Startup>()
        .Build();

      host.Run();
    }
  }
}
