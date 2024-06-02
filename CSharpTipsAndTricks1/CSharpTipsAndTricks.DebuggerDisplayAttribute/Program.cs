using CSharpTipsAndTricks1.Logic;
using System.Diagnostics;

Product apple = null;
apple ??= new() { Title = "Green apple" };

Console.WriteLine(apple.Title);

[DebuggerDisplay("This is a {Title}, with a stock of {Stock}")]
public class Product
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int Stock { get; set; }
    public Status Status { get; set; }
    public bool Available { get; set; }
}