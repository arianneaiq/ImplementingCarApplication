using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementingCarApplication
{
    internal class Car
    {
        private string licencePlate;
        private int maxFuelLevel;
        private int currentFuelLevel;
        private string carStatus;

        public Car(string newLicencePlate, int nwMAxFeulLevel)
        {
            this.licencePlate = newLicencePlate;
            this.maxFuelLevel = nwMAxFeulLevel;
        }

        public Car(string licencePlate, int maxFuelLevel, int currentFuelLevel, string carStatus) : this(licencePlate, maxFuelLevel)
        {
            this.currentFuelLevel = currentFuelLevel;
            this.carStatus = carStatus;
        }
        
        public Car()
        {

        }

        
        public void addFuel(int fuel)
        { if (carStatus == "Ok")
            {
                if (fuel > 0 && fuel < maxFuelLevel)
                {
                    currentFuelLevel += fuel;
                }
            } 
        }

        public void SetUnderMaintenance (bool isUnderMaintenance)
        {

           if (isUnderMaintenance == true)
            {
                carStatus = "Under Maintenance";
            }
            else if (isUnderMaintenance == false)
            {
                carStatus = "Ok";
            } 
        }

        public void SetSold()
        {
            if (carStatus == "Ok")
            {
                carStatus = "Sold";
            }
            
        }

        public string GetInfo()
        {
            return $"Licenceplate: {licencePlate} - Status: {carStatus}, fuel: {currentFuelLevel}/{maxFuelLevel}"; 
        }

        public string GetLicence()
        {
            return licencePlate;
        }
    }
}
