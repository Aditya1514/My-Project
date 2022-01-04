using System;

namespace Parameter_Datatype
{
    class Truck
    {
        private string name;

        public Truck(string N)
        {
            name = N;
        }
    }

    class Dealer
    {
        private Truck[] trucks;
        private int truckCounutDown;

        public void AddTrucks(Truck[] trks)
        {
            trucks = trks;
             truckCounutDown += trks.Length;
        }
        public int TruckCount
        {
            get { return truckCounutDown; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dealer D = new Dealer();
            D.AddTrucks(new Truck[]{new Truck("Fortuner"),
                                     new Truck("Honda") ,
                                     new Truck ("Suarz") ,
                                       new Truck("Benz")                 });
            Console.WriteLine("TruckCount :" +D.TruckCount);
        }
    }
}
