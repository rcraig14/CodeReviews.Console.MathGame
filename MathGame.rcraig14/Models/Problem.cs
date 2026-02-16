namespace MathGame.rcraig14.Models;

public abstract class Problem
{
    protected int Left { get; }
    protected int Right { get; }
    public Operation Operation { get; }
    string OperationString { get; }

    public Problem(int pLeft, int pRight, Operation pOperation, string pOperationString)
    {
        Left = pLeft;
        Right = pRight;
        Operation = pOperation;
        OperationString = pOperationString;
    }

    public abstract int Answer();

    public override string ToString()
    {
        return $"{Left} {OperationString} {Right} =";
    }
}
