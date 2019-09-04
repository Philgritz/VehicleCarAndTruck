using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleCarTruckConsoleApp1 {
    class Truck : Vehicle {

        public bool Cap { get; set; }
        public bool Diesel { get; set; }
        public string Bedsize { get; set; }

        public override string Print() {
            return base.Print() + $", Cap: {Cap}, Diesel: {Diesel}, Bedsize: {Bedsize}";
        }

    public Truck(bool cap, bool diesel, string bedsize) {
        this.Cap = cap;
        this.Diesel = diesel;
        this.Bedsize = bedsize;
    }
