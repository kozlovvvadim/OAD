namespace ConsoleApp1.stepGenerator;

public class RecursiveStepsGenerator : IStepsGenerator
{
    public IEnumerable<string> GenerateSteps(Quest quest)
    {
        var list = new List<string>();
        Fill(list, 1, quest.Difficulty, quest.Place);
        return list;
    }

    private static void Fill(List<string> output, int current, int max, string place)
    {
        // TODO (NA 5/6): uczniowie mogą dostać to jako gotowe albo do uzupełnienia
        if (current > max) return;
        output.Add($"  Krok {current}: {StepText(current, place)}");
        Fill(output, current + 1, max, place);
    }

    private static string StepText(int stepNumber, string place)
        => stepNumber % 2 == 1 ? $"Idź {place} i rozejrzyj się."
            : "Zrób akcję: szukaj / walcz / zbierz.";
}