namespace MathGame.rcraig14.Models;

public class Multiplication(int pLeft, int pRight) : Problem(pLeft, pRight, Operation.Multiplication, "*")
{
    public override int Answer()
    {
        return Left * Right;
    }
}
