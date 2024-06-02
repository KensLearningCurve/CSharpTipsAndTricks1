using CSharpTipsAndTricks1.Logic;

Product apple = new("Green apple", 10, Status.Ordered);

public class Product
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int Stock { get; set; }
    public Status Status { get; set; }
    public bool Available { get; set; }

    public Product(string title, int stock, Status status) => (Title, Stock, Status) = (title, stock, status);
}