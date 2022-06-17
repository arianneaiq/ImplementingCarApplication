using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementingCarApplication
{
    class Garage
    {
        private Car[] cars;
        private int carCounter;
        public string name;

        public Garage()
        {
            
        }

        public Garage(string nwName)
        {
            this.name = nwName;
        }

        public Garage( string nwName, Car[] carsList)
        {
             this.name = nwName;
             carCounter = 5;
             Car[] carList = new Car[carCounter];
 
        }

        public void AddCar (Car c)
        {
            Car[] cars = new Car[carCounter * 2];
            for (int i = 0; i < carCounter; i++)
            {
                cars[i] = c;
            }
        }

        public Car GetCar (int index)
        {

        }
    }
}
