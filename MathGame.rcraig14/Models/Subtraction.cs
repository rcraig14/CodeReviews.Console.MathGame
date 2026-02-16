namespace MathGame.rcraig14.Models;

public class Subtraction(int pLeft, int pRight) : Problem(pLeft, pRight, Operation.Subtraction, "-")
{
    public override int Answer()
    {
        return Left - Right;
    }
}
