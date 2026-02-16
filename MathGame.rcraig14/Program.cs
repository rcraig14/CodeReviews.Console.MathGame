using MathGame.rcraig14;
using MathGame.rcraig14.Controllers;

Console.WriteLine(@"Welcome to the Math Game!

Objective:
 - Solve as many math problems correctly as you can
");

var newProblem = true;
var controller = new GameControler();

while(newProblem)
{
    Console.WriteLine(@"
    Select a type of problem
        - Additon (a)
        - Subtraction (s)
        - Multipication (m)
        - Division (d)
    To quit type q"
    );

    var problemType = Console.ReadLine();

    if(problemType.ToLower() == "q" || problemType.ToLower() == "quit")
    {
        newProblem = false;
        continue;
    }

    try
    {
        var op = OperationConverter.StringToOperation(problemType);

        controller.GenerateProblem(op);
        controller.DisplayProblem();

        Console.Write($"Answer: ");
        var strAnswer = Console.ReadLine();
        
        if(int.TryParse(strAnswer, out int intOut))
        {
            var answer = controller.SubmitAnswer(intOut);
            Console.WriteLine(answer.ToString());
        } else
        {
            Console.WriteLine("Only integers can be submitted for answers");
            continue;
        }
        
    } catch(InvalidOperationException)
    {
        Console.WriteLine("Please enter a valid value");
    } catch (Exception e)
    {
        Console.WriteLine($"{e}");
    }
}