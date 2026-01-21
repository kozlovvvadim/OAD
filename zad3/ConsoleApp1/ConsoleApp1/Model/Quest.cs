namespace ConsoleApp1.Model;

public record Quest(string Npc, string Goal, string Place, int Difficulty)
{
    public int RewardGold => Difficulty * 100;
}