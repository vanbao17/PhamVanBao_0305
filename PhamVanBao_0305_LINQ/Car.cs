using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamVanBao_0305_LINQ
{
    internal class Car:Vehicle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int YearOfManufacture { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", Id, Name, YearOfManufacture);
        }

        public static IList<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car {Id = 1, Name = "Ford", YearOfManufacture = 1995, Color = "Blue", Price = 100000},
                    new Car {Id = 2, Name = "Chevrolet", YearOfManufacture = 2000, Color = "Red", Price = 45000},
                    new Car {Id = 3, Name = "Dodge", YearOfManufacture = 1998, Color = "Silver", Price = 38000},
                    new Car {Id = 4, Name = "Toyota", YearOfManufacture = 2005, Color = "White", Price = 50000},
                    new Car {Id = 5, Name = "GMC", YearOfManufacture = 2008, Color = "Gray", Price = 55000},
                    new Car {Id = 6, Name = "Nissan", YearOfManufacture = 2010, Color = "Black", Price = 200000},
                    new Car {Id = 7, Name = "Ram", YearOfManufacture = 2012, Color = "Green", Price = 65000},
                    new Car {Id = 8, Name = "Isuzu", YearOfManufacture = 2015, Color = "Yellow", Price = 70000},
                    new Car {Id = 9, Name = "Volvo", YearOfManufacture = 2018, Color = "Orange", Price = 75000},
                    new Car {Id = 10, Name = "Mack", YearOfManufacture = 2020, Color = "Brown", Price = 80000}
                };
            }
        }
    }
}
