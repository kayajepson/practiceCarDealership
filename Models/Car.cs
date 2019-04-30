// using System;
//
// namespace Dealership {
//
//   class Car
//   {
//     private string MakeModel;
//     private int Price;
//     private int Miles;
//     private string Color;
//
//     public Car(string makeModel, int price, int miles, string color)
//     {
//       MakeModel = makeModel;
//       Price = price;
//       Miles = miles;
//       Color = color;
//     }
//


using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Car
  {
    private string _makeModel;
    private int _price;
    private int _mileage;
    private string _color;

    private static List<Car> _instances = new List<Car> {};

    public Car (string makeModel, int mileage, int price, string color)
    {
      _makeModel = makeModel;
      _price = price;
      _mileage = mileage;
      _color = color;
      _instances.Add(this);

    }

    public string makeModel { get => _makeModel; set => _makeModel = value;}
    public int price { get => _price; set => _price = value;}
    public int mileage { get => _mileage; set => _mileage = mileage;}
    public string color { get => _color; set => _color = color;}


    public static List<Car> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}
