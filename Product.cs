namespace composite_example;

public class Product(string name, int cost) : Item
{
    public override int ComputeTotal()
    {
        return cost;
    }

    public override void Print(int count)
    {
        Console.WriteLine(string.Concat(Enumerable.Repeat("-", count)) + name + " - " + ComputeTotal());
    }
}