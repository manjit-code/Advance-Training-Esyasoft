using LINQ;
using System.Runtime.CompilerServices;

var games = new List<Games>
{
    new Games { Title = "The Legend of Zelda: Breath of the Wild", Genre = "Action-adventure", ReleaseYear = 2017, Rating = 9.5, Price = 59 },
    new Games { Title = "God of War", Genre = "Action-adventure", ReleaseYear = 2018, Rating = 9.3, Price = 49 },
    new Games { Title = "Red Dead Redemption 2", Genre = "Action-adventure", ReleaseYear = 2018, Rating = 9.7, Price = 69 },
    new Games { Title = "The Witcher 3: Wild Hunt", Genre = "RPG", ReleaseYear = 2015, Rating = 9.4, Price = 39 },
    new Games { Title = "Minecraft", Genre = "Sandbox", ReleaseYear = 2011, Rating = 9.0, Price = 26 },
    new Games { Title = "Fortnite", Genre = "Battle Royale", ReleaseYear = 2017, Rating = 8.5, Price = 0 },
    new Games { Title = "Among Us", Genre = "Party", ReleaseYear = 2018, Rating = 8.0, Price = 5 },
    new Games { Title = "Cyberpunk 2077", Genre = "RPG", ReleaseYear = 2020, Rating = 7.5, Price = 59 },
    new Games { Title = "Hades", Genre = "Roguelike", ReleaseYear = 2020, Rating = 9.2, Price = 24 },
    new Games { Title = "Animal Crossing: New Horizons", Genre = "Simulation", ReleaseYear = 2020, Rating = 9.1, Price = 59 }
};


var allGames = new List<string>();

foreach (var game in games)
{
    allGames.Add(game.Title);
}

//foreach (var game in allGames)
//{
//    Console.WriteLine(game);
//}
Console.WriteLine(allGames);

// using Linq 'Select' method with 'Lambda' query
var allGames1 = games.Select(game => game.Title);
//foreach (var game in allGames1)
//{
//    Console.WriteLine(game);
//}
// This is a 'Enumerable' from Linq
Console.WriteLine(allGames1);

// This will aonly store the Games whose Genre is 'RPG'
var allGames2 = games.Where(game => game.Genre == "RPG" && game.Rating > 9);
//foreach (var game in allGames2)
//{
//    Console.WriteLine(game.Title);
//}

// This will check whether there exists atleast one is true or not
var allGames3 = games.Any(games => games.ReleaseYear >= 2020);
//Console.WriteLine(allGames3);

// Order by ReleaseYear in ascending order
var allGames4 = games.OrderBy(games => games.ReleaseYear);
//foreach (var game in allGames4)
//{
//    Console.WriteLine($"{game.ReleaseYear} : {game.Title}");
//}


// Order by ReleaseYear in descending order
var allGames5 = games.OrderByDescending(games => games.ReleaseYear);
//foreach (var game in allGames5)
//{
//    Console.WriteLine($"{game.ReleaseYear} : {game.Title}");
//}

//AggregateException Function 
var avgPrice = games.Average(game => game.Price);
Console.WriteLine(avgPrice);

var minPrice = games.Min(game => game.Price);
var maxPrice = games.Max(game => game.Price);
var totalPrice = games.Sum(game => game.Price);
Console.WriteLine($"Min: {minPrice} \nMax:{maxPrice}\nSum:{totalPrice}");


//first Record 
var first = games.First(game => game.Price == maxPrice);
Console.WriteLine(first.Title);


// Group By: stores as [key, List<value>]
var groupBy = games.GroupBy(game => game.Genre);
foreach (var group in groupBy)
{
    Console.WriteLine($"Genre: {group.Key}");
    foreach (var game in group)
    {
        Console.WriteLine(game.Title);
    }
    Console.WriteLine("\n");
}

// Multi Condition
var multiCondition = games.Where(n => n.Genre == "RPG" && n.ReleaseYear > 2015)
                            .OrderBy(n => n.ReleaseYear)
                            .Select(n => $"{n.Title} -- {n.Genre} -- {n.Rating}");

foreach(var game in multiCondition)
{
    Console.WriteLine(game);
}