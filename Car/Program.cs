public class Program
{
    public static void Main()
    {
        Car myCar = new Car("DGD", 2024, "Red", 50);
        
        myCar.DisplayInfo();
        
        myCar.Drive(100);
        myCar.Refuel(20);
    }
}