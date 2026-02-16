using System;
using System.Reflection.Metadata.Ecma335;
using MathGame.rcraig14.Models;

namespace MathGame.rcraig14.Controllers;

public class UserInteractionsController : IUserInteractionsController
{
    public void DisplayResults(SubmittedAnswer submittedAnswer)
    {
        Console.WriteLine(submittedAnswer.ToString());
    }

    public void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the new math game");
    }

    public int GetAnswer(Problem problem)
    {
        Console.WriteLine(problem.ToString());
        Console.Write("Answer: ");
        string? strAnswer = Console.ReadLine();

        if (int.TryParse(strAnswer, out int intOut))
        {
            return intOut;
        }
        else
        {
            Console.WriteLine("Only integers can be submitted for answers");
            return GetAnswer(problem);
        }
    }

    public NextStep GetNextStep()
    {
        while (true)
        {
            Console.WriteLine("Get next problem (n), history of problems (h), or quit (q)");
            string? input = Console.ReadLine();

            switch (input?.ToLower() ?? "")
            {
                case "q":
                    return NextStep.Quit;
                case "n":
                    return NextStep.NewProblem;
                case "h":
                    return NextStep.History;
                default:
                    continue;
            }
        }

    }

    public Operation GetNextOperationType()
    {
        Console.WriteLine(@"
        Select a type of problem
            - Additon (a)
            - Subtraction (s)
            - Multipication (m)
            - Division (d)");

        string? problemType = Console.ReadLine();

        if (problemType is null)
            return GetNextOperationType();

        return OperationConverter.StringToOperation(problemType);
    }

    public void DisplayAnswerHistory(List<SubmittedAnswer> submittedAnswers)
    {
        int correct = 0;
        submittedAnswers.ForEach(answer =>
        {
            Console.WriteLine($"{answer.Problem} {answer.UserAnswer} Correct: {answer.isCorrect()}");
            correct += answer.isCorrect() ? 1 : 0;
        });

        Console.WriteLine($"Total Correct {correct} / {submittedAnswers.Count()}");
    }
}
