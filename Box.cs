namespace composite_example;

public class Box(string name) : Item
{
    private List<Item> BoxItems { get; } = [];

    public void Add(Item item)
    {
        BoxItems.Add(item);
    }
    
    public override int ComputeTotal()
    {
        return BoxItems.Sum(item => item.ComputeTotal());
    }

    public override void Print(int count = 0)
    {
        Console.WriteLine(string.Concat(Enumerable.Repeat("-", count++)) + name + " - " + ComputeTotal());
        BoxItems.ForEach(item => item.Print(count));
    }
}