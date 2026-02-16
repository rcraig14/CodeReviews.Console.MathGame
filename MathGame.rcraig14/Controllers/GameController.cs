using MathGame.rcraig14.Models;

namespace MathGame.rcraig14.Controllers;

public class GameController : IGameController
{

    private Problem? CurrentProblem { get; set; }
    private List<SubmittedAnswer> AnswerHistory { get; set; }

    public GameController()
    {
        AnswerHistory = new List<SubmittedAnswer>();
    }

    public Problem GenerateProblem(Operation operation)
    {
        CurrentProblem = operation switch
        {
            Operation.Addition => Addition.GenerateRandom(),
            Operation.Subtraction => Subtraction.GenerateRandom(),
            Operation.Multiplication => Multiplication.GenerateRandom(),
            Operation.Division => Division.GenerateRandom(),
            _ => throw new ArgumentOutOfRangeException(nameof(operation), $"Unexpected operation value: {operation}")
        };

        return CurrentProblem;
    }


    public SubmittedAnswer SubmitAnswer(int answer)
    {
        if (CurrentProblem is null)
        {
            throw new ArgumentNullException("Problem must be generated before submitting answer");
        }

        var submittedAnswer = new SubmittedAnswer(CurrentProblem, answer);
        AnswerHistory.Add(submittedAnswer);

        return submittedAnswer;
    }

    public void DisplayProblem()
    {
        Console.WriteLine(CurrentProblem?.ToString() ?? "Problem needs to be generated");
    }

    public List<SubmittedAnswer> GetAnswerHistory()
    {
        return AnswerHistory;
    }
}
