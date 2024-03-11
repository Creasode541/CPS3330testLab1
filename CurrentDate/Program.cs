// Michael Banko - CPS3330 Midterm SP24
class Program {
    static void Main(string[] args) {
        DateTime currentDate = DateTime.Now;

        string dayOfWeek = currentDate.DayOfWeek 
        switch {
            DayOfWeek.Sunday => "Sunday",
            DayOfWeek.Monday => "Monday",
            DayOfWeek.Tuesday => "Tuesday",
            DayOfWeek.Wednesday => "Wednesday",
            DayOfWeek.Thursday => "Thursday",
            DayOfWeek.Friday => "Friday",
            DayOfWeek.Saturday => "Saturday",
            _ => throw new InvalidOperationException("Somehow you reached an invalid day."),
        };

        Console.WriteLine($"Today is {dayOfWeek}.");
        Console.WriteLine($"Current Date is {currentDate}.");
    }
}