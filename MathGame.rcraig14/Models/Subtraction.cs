namespace MathGame.rcraig14.Models;

public class Subtraction(int pLeft, int pRight) : Problem(pLeft, pRight, Operation.Subtraction, "-")
{
    public override int Answer()
    {
        return Left - Right;
    }

    public static Subtraction GenerateRandom()
    {
        var random = new Random();
        int left = 0, right = 0;

        while (left <= right)
        {
            left = random.Next(1, 100);
            right = random.Next(0, 100);
        }

        return new Subtraction(left, right);
    }
}
