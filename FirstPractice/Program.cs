// List and loop through (Ashunti)

// Array and loop through (Katie)
double[] probabilities = {0.7645, 0.67, 0.882, 0.42, 0.95, 0.23, 0.366};

foreach(double statistic in probabilities){
    Console.WriteLine($"The likely hood of this happening is: {statistic} or {statistic*100}%");
}

// Dictionary and loop through (Joslyn)

Dictionary<string, string> favoriteFood = new Dictionary<string, string>();
favoriteFood.Add("Katie", "Sushi");
favoriteFood.Add("Ashunti", "Pizza");
favoriteFood.Add("Joslyn", "Pho");
Console.WriteLine("Everyone's favorite food");
foreach(KeyValuePair<string, string> food in favoriteFood) {
    Console.WriteLine($"{food.Key}'s favorite food is {food.Value}.");
}