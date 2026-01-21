namespace ConsoleApp1.stepGenerator;

public static class StepsGeneratorFactory
{
    public static IStepsGenerator Create(string mode)
        => mode == "R" ? new RecursiveStepsGenerator()
            : new IterativeStepsGenerator();
}}