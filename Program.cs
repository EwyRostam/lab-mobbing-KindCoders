// See https://aka.ms/new-console-template for more information

Console.WriteLine("How old is your dog? And I will tell you how old it is in human years.");
var dogYear = Console.ReadLine();
var intDogYear = int.Parse(dogYear);
int resultAge = intDogYear * 7;
Console.WriteLine($"Your dog would be {resultAge} years old if he/she was a human");

