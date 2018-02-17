using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public interface Vehicle
    {
       void getVType();
    }

    public interface VehicleF
    {
        void getFName();
    }

    class LCar : Vehicle
    {
        public void getVType()
        {
            Console.WriteLine("It's a car.");
        }
    }

    class Truck : Vehicle
    {
        public void getVType()
        {
            Console.WriteLine("It's a truck.");
        }
    }

    class Bus : Vehicle
    {
        public void getVType()
        {
            Console.WriteLine("It's a bus.");
        }
    }

    class LCarF : VehicleF
    {
        public void getFName()
        {
            Console.WriteLine("We make cars.");
        }
    }
    class TruckF : VehicleF
    {
        public void getFName()
        {
            Console.WriteLine("We make trucks.");
        }
    }
    class BusF : VehicleF
    {
        public void getFName()
        {
            Console.WriteLine("We make buses.");
        }
    }

    //Factory
    public interface VehicleFactory
    {
        Vehicle makeVeh();
        VehicleF makeVehF();
    }

    class CarVF : VehicleFactory
    {
       public Vehicle makeVeh()
        { return new LCar(); }

       public VehicleF makeVehF()
        { return new LCarF(); }

    }
    class TruckVF : VehicleFactory
    {
        public Vehicle makeVeh()
        { return new Truck(); }

        public VehicleF makeVehF()
        { return new TruckF(); }
    }

    class BusVF : VehicleFactory
    {
        public Vehicle makeVeh()
        { return new Bus(); }

        public VehicleF makeVehF()
        { return new BusF(); }
    }
}
