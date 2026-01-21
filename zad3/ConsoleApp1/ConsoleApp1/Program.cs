using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // DANE
        var data = new QuestData(
            npc: new[] { "Wieśniak", "Rycerz", "Czarodziej" },
            goals: new[] { "zgubił miecz", "potrzebuje ziół", "szuka mapy" },
            places: new[] { "w lesie", "w jaskini", "na bagnach" }
        );

        int difficulty = Input.ReadIntInRange("Podaj trudność (1-5): ", 1, 5);

        Console.Write("Tryb kroków: I = iteracja, R = rekurencja: ");
        string mode = (Console.ReadLine() ?? "").Trim().ToUpper();
        if (mode != "I" && mode != "R") mode = "I";

        var rng = new Random();

        // TODO (NA 5): stwórz obiekt questa (Quest) i uzupełnij pola.
        // TODO (NA 6): zrób to przez Factory (QuestFactory.CreateRandom)
        Quest quest = QuestFactory.CreateRandom(rng, data, difficulty);

        // TODO (NA 5): możesz zrobić if(mode) i generować kroki w Main.
        // TODO (NA 6): użyj Strategy (IStepsGenerator) wybranej przez Factory.
        IStepsGenerator stepsGenerator = StepsGeneratorFactory.Create(mode);

        // WYJŚCIE
        Console.WriteLine();
        Console.WriteLine($"QUEST: {quest.Npc} {quest.Goal} {quest.Place}.");
        Console.WriteLine("Kroki:");

        foreach (var step in stepsGenerator.GenerateSteps(quest))
            Console.WriteLine(step);

        Console.WriteLine($"Nagroda: {quest.RewardGold} złota");
    }
}

// ===== MODELE =====




// ===== FACTORY (NA 6) =====


// ===== STRATEGY (NA 6) =====


// Iteracyjna strategia


// Rekurencyjna strategia


// Factory do wyboru strategii


// ===== INPUT =====
