using System;

namespace DesignPatters.StructuralDesignPattern.Proxy
{
    public class ProxyDesignPattern
    {
        public void Demo()
        {
            ICar car = new ProxyCar(new Driver(15));
            car.DriveCar();

            car = new ProxyCar(new Driver(25));
            car.DriveCar();
        }
    }
    interface ICar
    {
        void DriveCar();
    }

    // Real Object
    public class Car : ICar
    {
        public void DriveCar() => Console.WriteLine("Car has been driven!");
    }

    // Proxy Object
    public class ProxyCar : ICar
    {
        private readonly Driver _driver;
        private readonly ICar _realCar;

        public ProxyCar(Driver driver)
        {
            _driver = driver;
            _realCar = new Car();
        }

        public void DriveCar()
        {
            if (_driver.Age < 16)
                Console.WriteLine("Sorry, the driver is too young to drive.");
            else
                _realCar.DriveCar();
        }
    }

    public class Driver
    {
        public int Age { get; set; }

        public Driver(int age) => Age = age;
    }

}