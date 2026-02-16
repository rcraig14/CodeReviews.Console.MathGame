using MathGame.rcraig14;
using MathGame.rcraig14.Controllers;

var game = new MathGameRunner(new UserInteractionsController(), new GameController());

game.start();
