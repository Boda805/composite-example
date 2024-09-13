using composite_example;

var b1 = new Box("Box 1");
var b2 = new Box("Box 2");
var b3 = new Box("Box 3");
var b4 = new Box("Box 4");

var socks = new Product("Socks", 10);
var shirt = new Product("Shirt", 25);
var coat = new Product("Coat", 45);
var hat = new Product("Hat", 30);

b1.Add(socks);
b1.Add(shirt);
b1.Add(hat);
b1.Add(hat);
b3.Add(coat);
b4.Add(shirt);
b4.Add(hat);

b3.Add(b1);
b3.Add(b2);
b4.Add(b3);

Console.WriteLine($"Total box cost: {b4.ComputeTotal()}");
b4.Print();
