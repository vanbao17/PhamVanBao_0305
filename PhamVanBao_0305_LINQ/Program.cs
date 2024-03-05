using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamVanBao_0305_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = 0;
            do
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("Nhap lua chon cua ban: ");
                Console.WriteLine("1: Hien thi cac xe co gia trong khoang 100.000 đen 250.000: ");
                Console.WriteLine("2: Cac xe co nam san xuat > 1990: ");
                Console.WriteLine("3: Gom cac xe theo hang san xuat, tinh tong gia tri theo nhom: ");
                Console.WriteLine("4: Hien thi danh sach Truck theo thu tu nam san xuat moi nhat: ");
                Console.WriteLine("5: Hien thi ten cty chu quan cua Truck: ");
                Console.WriteLine("6: Exit  ");
                
                num = Convert.ToInt32(Console.ReadLine());
                var cars = Car.Cars.ToList();
                var trucks = Truck.Trucks.ToList();
                switch (num)
                {
                    case 1:
                        var listPriceCar = cars.Where(f => f.Price >= 100000 && f.Price <= 250000).ToList();
                        Console.WriteLine("------------------------");
                        Console.WriteLine("Result : ");
                        foreach (var car in listPriceCar)
                        {
                            Console.WriteLine($"Car: {car.Name} - {car.Color} - {car.Price} - {car.YearOfManufacture}");
                        }
                        break;
                    case 2:
                        var listYearManufacturerCar = cars.Where(f => f.YearOfManufacture > 1990).ToList();
                        Console.WriteLine("------------------------");
                        Console.WriteLine("Result : ");
                        foreach (var car in listYearManufacturerCar)
                        {
                            Console.WriteLine($"Car: {car.Name} - {car.YearOfManufacture}");
                        }
                        break;
                    case 3:
                        var groupedByBrand = trucks
                           .GroupBy(truck => truck.NameManufacture)
                           .Select(group => new
                           {
                               Brand = group.Key,
                               TotalPrice = group.Sum(truck => truck.Price)
                           })
                           .ToList();
                        Console.WriteLine("------------------------");
                        Console.WriteLine("Result : ");
                        foreach (var group in groupedByBrand)
                        {
                            Console.WriteLine($"Hãng: {group.Brand}, Tổng giá trị: {group.TotalPrice}");
                        }
                        break;
                    case 4:
                        var listYearManufacturerTruck = trucks.OrderByDescending(truck => truck.YearOfManufacture).ToList();
                        Console.WriteLine("------------------------");
                        Console.WriteLine("Result : ");
                        foreach (var truck in listYearManufacturerTruck)
                        {
                            Console.WriteLine($"Truck: {truck.NameManufacture} - {truck.OwnerName} - {truck.YearOfManufacture}");
                        }
                        break;
                    case 5:
                        var listOwnerNameTruck = trucks.Where(f => f.OwnerName.Equals("") == false).ToList();
                        Console.WriteLine("------------------------");
                        Console.WriteLine("Result : ");
                        foreach (var truck in listOwnerNameTruck)
                        {
                            Console.WriteLine($"Truck: {truck.NameManufacture} - {truck.OwnerName}");
                        }
                        break;

                }
            }
            while (num != 6);
            Console.ReadKey();
        }
    }
}
