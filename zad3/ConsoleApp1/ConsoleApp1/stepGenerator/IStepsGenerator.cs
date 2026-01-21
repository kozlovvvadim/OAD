namespace ConsoleApp1.stepGenerator;


public interface IStepsGenerator
{
    IEnumerable<string> GenerateSteps(Quest quest);
}