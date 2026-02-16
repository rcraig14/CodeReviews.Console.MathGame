namespace MathGame.rcraig14.Models;

public class Addition(int pLeft, int pRight) : Problem(pLeft, pRight, Operation.Addition, "+")
{

    public static Addition GenerateRandom() 
    {
        var random = new Random();
        return new Addition(random.Next(0,100), random.Next(0,100));
    }

    public override int Answer()
    {
        return Left + Right; 
    }
}
