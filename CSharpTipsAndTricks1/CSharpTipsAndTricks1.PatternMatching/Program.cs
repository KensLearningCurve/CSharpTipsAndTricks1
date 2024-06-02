using CSharpTipsAndTricks1.Logic;

object? something = ProductList.Products[0];

if (something is Product product)
{
    Console.WriteLine($"The type you are looking at is a {product.GetType()} and has the title {product.Title}");
}