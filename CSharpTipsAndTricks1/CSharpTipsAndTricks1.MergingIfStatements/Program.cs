using CSharpTipsAndTricks1.Logic;

Product chips = ProductList.Products.Single(x => x.Id == 2);

if (chips is { Stock: 0, Status: Status.Ordered })
{
    chips.Available = false;
}

Console.WriteLine($"The product {chips.Title} is {(chips.Available ? "available" : "not available")}");
