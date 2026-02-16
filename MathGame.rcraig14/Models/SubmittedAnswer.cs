using System.Runtime.CompilerServices;

namespace MathGame.rcraig14.Models;

public class SubmittedAnswer
{
    public Problem Problem { get; }
    public int UserAnswer { get; }
    public TimeSpan TimeToComplete { get; }


    public SubmittedAnswer(Problem problem, int answer, TimeSpan timeToComplete)
    {
        Problem = problem;
        UserAnswer = answer;
        TimeToComplete = timeToComplete;
    }

    public bool isCorrect() => Problem.Answer() == UserAnswer;

    public override string ToString()
    {
        return isCorrect() ? $"Correct the answer is {Problem.Answer()}" : $"Incorrect the answer is {Problem.Answer()}";
    }
}
