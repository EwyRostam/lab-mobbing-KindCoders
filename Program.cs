// See https://aka.ms/new-console-template for more information

Console.WriteLine("How old is your dog? And I will tell you how old it is in human years.");
var dogYear = Console.ReadLine();
Console.WriteLine($"Your dog would be {int.Parse(dogYear) * 7} years old if he/she was a human");

Console.WriteLine("How old are you and I will give your age in dog years");
var humanYear = Console.ReadLine();
Console.WriteLine($"You are a dog that is {int.Parse(humanYear) / 7} years old");
Console.WriteLine("We are the best programmers salt has ever seen");

