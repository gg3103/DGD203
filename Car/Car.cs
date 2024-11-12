namespace Programing2;

public class Car
{
    public string Model { get; private set; }
    public int Year { get; private set; }
    public string Color { get; private set; }
    public double FuelLevel { get; private set; }
    
    public Car(string model, int year, string color, double fuelLevel)
    {
        Model = model;
        Year = year;
        Color = color;
        FuelLevel = fuelLevel;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Model: {Model}");
        Console.WriteLine("Year: {Year}");
        Console.WriteLine("Color: {Color}");
        Console.WriteLine("Fuel Level: {FuelLevel} units");
    }
    
    public void Drive(double distance)
    {
        double fuelConsumed = distance * 0.05; 
        if (FuelLevel >= fuelConsumed)
        {
            FuelLevel -= fuelConsumed;
            Console.WriteLine("Drove {distance} km. Fuel left: {FuelLevel} units.");
        }
        else
        {
            Console.WriteLine("Not enough fuel.");
        }
    }

    public void Refuel(double amount)
    {
        FuelLevel += amount;
        Console.WriteLine("Refueled {amount} units. Fuel level: {FuelLevel} units.");
    }
}