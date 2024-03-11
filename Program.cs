using System;

public class ChineseZodiac {
    public static void Main(string[] args) {
        Console.Write("Enter a year: ");
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int year))
        {
            string chineseAnimal = ChineseAnimalFinder (year);
            Console.WriteLine(chineseAnimal);
        } else {
            Console.WriteLine("Invalid input. Please enter a valid year.");
        }
    }
    public static string ChineseAnimalFinder (int year) {
        return (year % 12) switch {
            0 => "Monkey",
            1 => "Rooster",
            2 => "Dog",
            3 => "Pig",
            4 => "Rat",
            5 => "Ox",
            6 => "Tiger",
            7 => "Rabbit",
            8 => "Dragon",
            9 => "Snake",
            10 => "Horse",
            11 => "Sheep",
            _ => throw new ArgumentException("Invalid year input"),
        };
    }
}
