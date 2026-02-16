using MathGame.rcraig14.Models;

namespace MathGame.rcraig14.Controllers;

public class GameControler : IGameController
{

    private Problem? CurrentProblem {get; set;}
    private List<SubmittedAnswer> AnswerHistory {get; set;}
    private Random _random {
        get => _random ?? new Random();
        set => _random = value;
    }

    public GameControler(Random random)
    {
        _random = random;
        AnswerHistory = new List<SubmittedAnswer>();
    }

    public GameControler()
    {
        AnswerHistory = new List<SubmittedAnswer>();
    }

    public Problem GenerateProblem(Operation operation) {
        CurrentProblem = operation switch
        {
            Operation.Addition => new Addition(1, 2),
            Operation.Subtraction => new Subtraction(2, 1),
            Operation.Multiplication => new Multiplication(2, 5),
            Operation.Division => new Division(4, 2),
            _ => throw new ArgumentOutOfRangeException(nameof(operation), $"Unexpected operation value: {operation}")
        };

        return CurrentProblem;
    }
    

    public SubmittedAnswer SubmitAnswer(int answer)
    {
        if(CurrentProblem is null)
        {
            throw new ArgumentNullException("Problem must be generated before submitting answer");
        }
        
        var submittedAnswer = new SubmittedAnswer(CurrentProblem, answer);
        AnswerHistory.Append(submittedAnswer);

        return submittedAnswer;
    }

    public void DisplayProblem()
    {
        Console.WriteLine(CurrentProblem?.ToString() ?? "Problem needs to be generated");
    }
}
