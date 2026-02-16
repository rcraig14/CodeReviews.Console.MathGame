using System.Collections;

namespace MathGame.rcraig14;

public enum Operation
{
    Addition,
    Subtraction,
    Multiplication,
    Division
}



public static class OperationConverter {

    public static Operation StringToOperation(string input)
    {
        switch(input.ToLower()) {
            case "a":
                return Operation.Addition;
            case "s":
                return Operation.Subtraction;
            case "m":
                return Operation.Multiplication;
            case "d":
                return Operation.Division;
            default:
                throw new InvalidOperationException();
        };
    }
    
}

public class InvalidOperationString: Exception
{
    public InvalidOperationString()
    {
        
    }

    public InvalidOperationString(string message) : base(message)
    {
        
    }

}