namespace MathGame.rcraig14.Models;

public class Addition(int pLeft, int pRight) : Problem(pLeft, pRight, Operation.Addition, "+")
{

    public override int Answer()
    {
        return Left + Right; 
    }
}
