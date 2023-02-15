// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// List and loop through (Ashunti)

// Array and loop through (Katie)

// Dictionary and loop through (Joslyn)

Dictionary<string, string> favoriteFood = new Dictionary<string, string>();
favoriteFood.Add("Katie", "Sushi");
favoriteFood.Add("Ashunti", "Pizza");
favoriteFood.Add("Joslyn", "Pho");
Console.WriteLine("Everyone's favorite food");
foreach(KeyValuePair<string, string> food in favoriteFood) {
    Console.WriteLine($"{food.Key}'s favorite food is {food.Value}.");
}