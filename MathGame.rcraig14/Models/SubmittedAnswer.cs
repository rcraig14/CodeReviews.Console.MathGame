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

    public bool IsCorrect() => Problem.Answer() == UserAnswer;

    public override string ToString()
    {
        return IsCorrect() ? $"Correct the answer is {Problem.Answer()}" : $"Incorrect the answer is {Problem.Answer()}";
    }
}
