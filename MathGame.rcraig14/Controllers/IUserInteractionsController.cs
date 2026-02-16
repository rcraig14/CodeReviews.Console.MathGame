using System;
using System.Runtime.CompilerServices;
using MathGame.rcraig14.Models;

namespace MathGame.rcraig14.Controllers;


// User interations
    // Welcome screen -> void
    // Next Problem or Quit -> state
    // Select Problem Type -> Operation
    // Get Answer(Problem) -> int
    // Display results(SubmittedProblem) -> void
public interface IUserInteractionsController
{
    public void DisplayWelcome();
    public NextStep GetNextStep();
    public Operation GetNextOperationType();
    public int GetAnswer(Problem problem);
    public void DisplayResults(SubmittedAnswer submittedAnswer); 

}
