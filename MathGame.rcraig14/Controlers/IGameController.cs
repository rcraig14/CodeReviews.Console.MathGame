using MathGame.rcraig14.Models;

namespace MathGame.rcraig14.Controllers;

public interface IGameController
{
    public Problem GenerateProblem(Operation operation);
    public void DisplayProblem();
    public SubmittedAnswer SubmitAnswer(int answer);

}
