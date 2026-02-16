using MathGame.rcraig14;
using MathGame.rcraig14.Controllers;
using MathGame.rcraig14.Models;

var newProblem = true;
var controller = new GameController();
var userInteraction = new UserInteractionsController();

userInteraction.DisplayWelcome();

while(newProblem)
{
    NextStep next = userInteraction.GetNextStep();

    if(next == NextStep.Quit)
    {
        newProblem = false;
        break;
    }

    Operation op =  userInteraction.GetNextOperationType();
    Problem problem = controller.GenerateProblem(op);
    int userAnswer = userInteraction.GetAnswer(problem);
    SubmittedAnswer submittedAnswer = controller.SubmitAnswer(userAnswer);
    userInteraction.DisplayResults(submittedAnswer);
}



    