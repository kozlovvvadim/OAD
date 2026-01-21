namespace ConsoleApp1.Factory;

public static class QuestFactory
{
    public static Quest CreateRandom(Random rng, QuestData data, int difficulty)
    {
        // (Gotowe — uczniowie na 6 mają użyć tego zamiast losowania w Main)
        string npc = data.Npc[rng.Next(data.Npc.Length)];
        string goal = data.Goals[rng.Next(data.Goals.Length)];
        string place = data.Places[rng.Next(data.Places.Length)];
        return new Quest(npc, goal, place, difficulty);
    }
}