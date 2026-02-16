using MathGame.rcraig14.Controllers;
using MathGame.rcraig14.Models;

namespace MathGame.rcraig14;

public class MathGameRunner
{
    private UserInteractionsController _userInteractionController { get; }
    private GameController _gameController { get; }
    private bool _newProblem {get; set;}

    public MathGameRunner(
        UserInteractionsController userInteractionsController,
        GameController gameController)
    {
        _userInteractionController = userInteractionsController;
        _gameController = gameController;
        _newProblem = true;
    }

    private void NextProblem()
    {
        Operation op = _userInteractionController.GetNextOperationType();
        Problem problem = _gameController.GenerateProblem(op);
        int userAnswer = _userInteractionController.GetAnswer(problem);
        SubmittedAnswer submittedAnswer = _gameController.SubmitAnswer(userAnswer);
        _userInteractionController.DisplayResults(submittedAnswer);
    }

    public void start()
    {
        _userInteractionController.DisplayWelcome();

        while (_newProblem)
        {
            NextStep next = _userInteractionController.GetNextStep();

            switch(next)
            {
                case NextStep.Quit:
                    _newProblem = false;
                    break;
                default:
                    this.NextProblem();
                    break;
            }
            
        }
    }
}
