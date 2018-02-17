using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        //21 Вариант
        static void Main(string[] args)
        {
            CarVF newCarFactory = new CarVF();
            Vehicle car = newCarFactory.makeVeh();
            VehicleF Cfactory = newCarFactory.makeVehF();

            car.getVType();
            Cfactory.getFName();


            TruckVF newTruckFactory = new TruckVF();
            Vehicle truck = newTruckFactory.makeVeh();
            VehicleF Tfactory = newTruckFactory.makeVehF();

            truck.getVType();
            Tfactory.getFName();


            Console.ReadLine();

        }
    }
}
