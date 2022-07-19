namespace Exercise;

public class GameMenu
{
    private readonly Checkerboard _checkerboard;

    public GameMenu(Checkerboard checkerboard)
    {
        _checkerboard = checkerboard;
    }

    public void ShowStartMenu()
    {
        Console.WriteLine("Game starts!");
        var humanChoice = Chess.X;    // "X"
        var machineChoice = Chess.O;  // "O"

        Console.WriteLine("Which side do you want?\n");
        Console.WriteLine("1. X");
        Console.WriteLine("2. O\n");
        Console.Write("Please choose one: ");
        var input = Console.ReadLine();

        if (input is "2")
        {
            (humanChoice, machineChoice) = (machineChoice, humanChoice);    // swap values
        }
        else if (input is not "1")
        {
            Console.WriteLine("Wrong input, you will start as default: 'X'");
        }

        Console.WriteLine("Human: '{0}', Computer: '{1}'.", humanChoice, machineChoice);
        _checkerboard.ShowCheckerboard();

        while (true)
        {
            Console.Write("Human's move (e.g. 1,2): ");
            var move = Console.ReadLine();
            if (move is null or "" || move.Length != 3)
            {
                Console.WriteLine("Wrong input, enter again.");
                continue;
            }

            // user play first
            if (int.TryParse(move[..1], out var x) && int.TryParse(move[2..3], out var y))
            {
                if (x is > 2 or < 0 || y is > 2 or < 0)
                {
                    Console.WriteLine("Wrong input, enter again.");
                    continue;
                }

                if (_checkerboard.PlaceChess(x, y, humanChoice))
                {
                    _checkerboard.ShowCheckerboard();
                }
                else
                {
                    Console.WriteLine("You can not place your chess here. Choose again.");
                    continue;
                }
            }
            else
            {
                Console.WriteLine("Wrong input, enter again.");
                continue;
            }

            // check if the user wins
            var checkRes1 = _checkerboard.CheckWinner();
            if (checkRes1 == humanChoice)
            {
                Console.WriteLine("You win!");
                break;
            }
            // check draw
            if (checkRes1 == Chess.Draw)
            {
                Console.WriteLine("This is a draw");
                break;
            }

            // computer play next
            _checkerboard.BeatTheHuman(humanChoice);
            _checkerboard.ShowCheckerboard();
            // check wins
            var checkRes2 = _checkerboard.CheckWinner();
            if (checkRes2 == machineChoice)
            {
                Console.WriteLine("Computer win!");
                break;
            }
            // check draw
            if (checkRes2 != Chess.Draw) continue;
            Console.WriteLine("This is a draw");
            break;
        }

        Console.WriteLine("Game ends.");
    }

    // private static void Main(string[] args)
    // {
    //     var game = new GameMenu(new Checkerboard());
    //     game.ShowStartMenu();
    // }
}