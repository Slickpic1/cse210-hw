using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
    }
}

class Vehicle
{
    private string make;
    private string model;
    private int miles;

    public Vehicle(strine make, string model, int miles)
    {
        this.make = make;
        this.model = model;
        this.miles = miles;
    }
}

class Car : Vehicle
{
    //Thats it, but could make empty constructor if it complains.
}

class Truck : Vehicle
{
    private int towing;
    public Truck(string make, string model, int miles, int towing) : base(make, model, miles)
    {
        this.towing = towing;
    }
}
