using MathGame.rcraig14.Controllers;
using MathGame.rcraig14.Models;

namespace MathGame.rcraig14;

public class MathGameRunner
{
    private UserInteractionsController UserInteractionController { get; }
    private GameController GameController { get; }
    private bool NewProblem { get; set; }

    public MathGameRunner(
        UserInteractionsController userInteractionsController,
        GameController gameController)
    {
        UserInteractionController = userInteractionsController;
        GameController = gameController;
        NewProblem = true;
    }

    private void NextProblem()
    {
        Operation op = UserInteractionController.GetNextOperationType();
        Problem problem = GameController.GenerateProblem(op);

        DateTime startTime = DateTime.UtcNow;
        int userAnswer = UserInteractionController.GetAnswer(problem);
        DateTime endTime = DateTime.UtcNow;

        SubmittedAnswer submittedAnswer = GameController.SubmitAnswer(userAnswer, endTime - startTime);
        UserInteractionController.DisplayResults(submittedAnswer);
    }

    private void History()
    {
        var history = GameController.GetAnswerHistory();
        UserInteractionController.DisplayAnswerHistory(history);
    }

    public void Start()
    {
        UserInteractionController.DisplayWelcome();

        while (NewProblem)
        {
            NextStep next = UserInteractionController.GetNextStep();

            switch (next)
            {
                case NextStep.Quit:
                    NewProblem = false;
                    break;
                case NextStep.History:
                    this.History();
                    break;
                default:
                    this.NextProblem();
                    break;
            }

        }
    }
}
