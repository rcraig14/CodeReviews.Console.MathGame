namespace MathGame.rcraig14.Models;

public class Division(int pLeft, int pRight) : Problem(pLeft, pRight, Operation.Division, "/")
{
    public override int Answer()
    {
        return Left / Right;
    }
}
