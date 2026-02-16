using System.Runtime.CompilerServices;

namespace MathGame.rcraig14.Models;

public class SubmittedAnswer
{
    public Problem Problem{ get; }
    public int Answer { get; }


    public SubmittedAnswer(Problem problem, int answer)
    {
        Problem = problem;
        Answer = answer;
    }

    public bool isCorrect() => Problem.Answer() == Answer;

    public override string ToString()
    {
        return isCorrect() ? "Answer was correct" : "Answer is incorrect";
    }
}
