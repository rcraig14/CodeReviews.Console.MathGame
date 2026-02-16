namespace MathGame.rcraig14.Models;

public class Multiplication(int pLeft, int pRight) : Problem(pLeft, pRight, Operation.Multiplication, "*")
{
    public override int Answer()
    {
        return Left * Right;
    }

    public static Multiplication GenerateRandom() 
    {
        var random = new Random();
        return new Multiplication(random.Next(0,100), random.Next(0,100));
    }
}
