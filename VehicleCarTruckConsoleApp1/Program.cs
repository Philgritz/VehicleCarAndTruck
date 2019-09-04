using System;

namespace VehicleCarTruckConsoleApp1 {
    class Program {
        static void Main(string[] args) {

            var car1 = new Car("12345", "Toyota", "Camry", "Red", 30000, true, true, true);
            var car2 = new Car("24680", "Honda", "Civic", "Blue",  50000, false, false, false);
            var car3 = new Car("13579", "Porsche", "Cayenne", "Black", 60000, true, false, true);

            var truck1 = new Truck("00000", "Ford",  80000, "F150", "Grey", true, true, "6 feet");
            var truck2 = new Truck("99999", "Chevy", 40000, "Silverado", "Silver", true, true, "7 feet");
            var truck3 = new Truck("11111", "Dodge", "Durango", "White", 70000, true, true, "8 feet");
        }
    }
}
