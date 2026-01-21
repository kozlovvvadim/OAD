namespace ConsoleApp1.Utlis;

public static class Input
{
    public static int ReadIntInRange(string prompt, int min, int max)
    {
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int value) && value >= min && value <= max)
                return value;

            Console.WriteLine($"Błąd: wpisz liczbę od {min} do {max}.");
        }
    }
}