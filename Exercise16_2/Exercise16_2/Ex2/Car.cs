using System;
using System.Collections.Generic;

public class Car
{
    public int PlatNumber { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
}

public class CarsDB
{
    private Dictionary<int, Car> cars = new Dictionary<int, Car>();

    public void AddCar(int platNumber, Car car)
    {
        cars[platNumber] = car;
    }

    public void RemoveCar(int platNumber)
    {
        if (cars.ContainsKey(platNumber))
        {
            cars.Remove(platNumber);
        }
    }

    public Car GetCar(int platNumber)
    {
        if (cars.TryGetValue(platNumber, out Car car))
        {
            return car;
        }
        else
        {
            return null;
        }
    }

    public void UpdateCar(int platNumber, Car car)
    {
        if (cars.ContainsKey(platNumber))
        {
            cars[platNumber] = car;
        }
    }
}
