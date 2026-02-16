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

        if(int.TryParse(strAnswer, out int intOut))
        {
            return intOut;
        } else
        {
            Console.WriteLine("Only integers can be submitted for answers");
            return GetAnswer(problem);
        }
    }

    public NextStep GetNextStep()
    {
        while(true)
        {
            Console.WriteLine("Get next problem (n) or quit (q)");
            string? input = Console.ReadLine();

            switch(input?.ToLower() ?? "" )
            {
                case "q":
                    return NextStep.Quit;
                case "n":
                    return NextStep.NewProblem;
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

         if(problemType is null)
            return GetNextOperationType();

        return OperationConverter.StringToOperation(problemType);
    }
}
