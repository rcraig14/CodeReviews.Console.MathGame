namespace MathGame.rcraig14.Models;

public class Division(int pLeft, int pRight) : Problem(pLeft, pRight, Operation.Division, "/")
{

    public static Division GenerateRandom()
    {
        var random = new Random();
        int left = 1, right = 1;

        while(left <= right || (left % right) != 0)
        {
            left = random.Next(1,100);
            right = random.Next(1,99);
        }

        return new Division(left, right);
    }
    public override int Answer()
    {
        return Left / Right;
    }
}
