using System;
using Interfaces.Entities;
using Interfaces.Entities.Services;
using Interfaces.Services;

namespace Interfaces.Entities
{
    internal class CarRental
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Vehicle Vehicle { get; set; }
        public Invoice Invoice{ get; set; }

        public CarRental(Vehicle vehicle, DateTime start, DateTime finish)
        {
            Vehicle = vehicle;
            Start = start;
            Finish = finish;
            Invoice = null;
        }
    }
}
