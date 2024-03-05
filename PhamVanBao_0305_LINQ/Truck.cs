using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PhamVanBao_0305_LINQ
{
    internal class Truck:Vehicle
    {
        public int Id { get; set; }
        public string NameManufacture { get; set; }
        public string OwnerName { get; set; }
        public int YearOfManufacture { get; set; }
        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3}", Id, NameManufacture, OwnerName, YearOfManufacture);
        }

        public static IList<Truck> Trucks
        {
            get
            {
                return new List<Truck>
                {
                    new Truck { Id = 1, NameManufacture = "Ford", OwnerName = "Ford Motor Company", YearOfManufacture = 1980, Color = "Blue", Price = 500000 },
                    new Truck { Id = 2, NameManufacture = "Chevrolet", OwnerName = "General Motors", YearOfManufacture = 1975, Color = "Red", Price = 450000 },
                    new Truck { Id = 3, NameManufacture = "Dodge", OwnerName = "Stellantis", YearOfManufacture = 1995, Color = "Silver", Price = 550000 },
                    new Truck { Id = 4, NameManufacture = "Toyota", OwnerName = "Toyota Motor Corporation", YearOfManufacture = 2000, Color = "Green", Price = 600000 },
                    new Truck { Id = 5, NameManufacture = "Isuzu", OwnerName = "Isuzu Motors", YearOfManufacture = 1988, Color = "White", Price = 480000 },
                    new Truck { Id = 6, NameManufacture = "Volvo", OwnerName = "Volvo Group", YearOfManufacture = 1998, Color = "Gray", Price = 700000 },
                    new Truck { Id = 7, NameManufacture = "Kenworth", OwnerName = "PACCAR", YearOfManufacture = 2005, Color = "Yellow", Price = 800000 },
                    new Truck { Id = 8, NameManufacture = "Mack", OwnerName = "Mack Trucks", YearOfManufacture = 1992, Color = "Brown", Price = 650000 },
                    new Truck { Id = 9, NameManufacture = "Freightliner", OwnerName = "Daimler Trucks North America", YearOfManufacture = 2010, Color = "Orange", Price = 750000 },
                    new Truck { Id = 10, NameManufacture = "Peterbilt", OwnerName = "PACCAR", YearOfManufacture = 2008, Color = "Black", Price = 900000 }
                };
                }
        }
    }
}
