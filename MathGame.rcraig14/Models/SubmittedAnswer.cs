using System.Runtime.CompilerServices;

namespace MathGame.rcraig14.Models;

public class SubmittedAnswer
{
    public Problem Problem{ get; }
    public int UserAnswer { get; }


    public SubmittedAnswer(Problem problem, int answer)
    {
        Problem = problem;
        UserAnswer = answer;
    }

    public bool isCorrect() => Problem.Answer() == UserAnswer;

    public override string ToString()
    {
        return isCorrect() ? $"Correct the answer is {Problem.Answer()}" : $"Incorrect the answer is {Problem.Answer()}";
    }
}
