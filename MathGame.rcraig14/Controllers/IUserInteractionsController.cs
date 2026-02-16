using System;
using System.Runtime.CompilerServices;
using MathGame.rcraig14.Models;

namespace MathGame.rcraig14.Controllers;

public interface IUserInteractionsController
{
    public void DisplayWelcome();
    public NextStep GetNextStep();
    public Operation GetNextOperationType();
    public int GetAnswer(Problem problem);
    public void DisplayResults(SubmittedAnswer submittedAnswer);

}
