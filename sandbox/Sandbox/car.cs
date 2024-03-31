

public class Car
{
    public int mpg;
    public int gallons;
    public string make;
    public string model;
    public Owner owner;

    public int TotalRange()
    {
        return gallons * mpg;
    }

    public Car (string make, string model, int gallons, int mpg, Owner owner)
    {
        this.make = make;
        this.model = model;
        this.mpg = mpg;
        this.gallons = gallons;

    }

    public Car(string make, string model)
    {
        this.make = make;
        this.model = model;
    }
    public void Display()
    {
        //Note: we dont need to do c. to make this work since its in the class
        Console.WriteLine($"{make} {model} {owner.name}: Range= {gallons * mpg}");
    }
}