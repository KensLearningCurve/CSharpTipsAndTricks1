using CSharpTipsAndTricks1.Logic;

Product apple = null;
apple ??= new() { Title = "Green apple" };

Console.WriteLine(apple.Title);