namespace Exercise;

public enum Chess
{
    X,      // chess "X"
    O,      // chess "O"
    Null,   // empty index "."
    Draw    // tie situation
}

public class Checkerboard
{
    // The board
    private Chess[,] Board { get; set; }
    // Current board status
    private List<string> Status { get; set; }

    // Constructor
    public Checkerboard()
    {
        Board = new Chess[3, 3];
        for (var i = 0; i < 3; i++)
        {
            for (var j = 0; j < 3; j++)
            {
                Board[i, j] = Chess.Null;
            }
        }
        Status = new List<string>();
    }

    /*
     * This function generates current status and save to the object.
     */
    private void GetCurrentSituation()
    {
        var horizontal0 = "" + Board[0, 0] + Board[0, 1] + Board[0, 2];
        var horizontal1 = "" + Board[1, 0] + Board[1, 1] + Board[1, 2];
        var horizontal2 = "" + Board[2, 0] + Board[2, 1] + Board[2, 2];
        var vertical0 = "" + Board[0, 0] + Board[1, 0] + Board[2, 0];
        var vertical1 = "" + Board[0, 1] + Board[1, 1] + Board[2, 1];
        var vertical2 = "" + Board[0, 2] + Board[1, 2] + Board[2, 2];
        var cross0 = "" + Board[0, 0] + Board[1, 1] + Board[2, 2];
        var cross1 = "" + Board[0, 2] + Board[1, 1] + Board[2, 0];

        var checkList = new List<string>
        {
            horizontal0,
            horizontal1,
            horizontal2,
            vertical0,
            vertical1,
            vertical2,
            cross0,
            cross1
        };
        Status = checkList;
    }

    /*
     * This function prints the current checkerboard to user.
     */
    public void ShowCheckerboard()
    {
        for (var i = 0; i < 3; i++)
        {
            for (var j = 0; j < 3; j++)
            {
                if (Board[i, j] != Chess.Null)
                {
                    Console.Write(Board[i, j]);
                }
                else
                {
                    Console.Write(".");
                }

                Console.Write(" ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
    }

    /*
     * This function place a new chess for the user.
     *
     * If the index user indicates are available, place it and return true;
     * if not, return false
     */
    public bool PlaceChess(int x, int y, Chess who)
    {
        if (Board[x, y] != Chess.Null) return false;

        Board[x, y] = who;
        return true;
    }

    /*
     * This function checks if we have a winner already.
     *
     * If there is a winner, return will be its symbol.
     * If there's a tie, return will be Chess.Draw.
     * If there's no endgame situation, return will be Chess.Null
     */
    public Chess CheckWinner()
    {
        if (CheckStatus(Chess.X))
        {
            return Chess.X;
        }
        if (CheckStatus(Chess.O))
        {
            return Chess.O;
        }

        // if all places are full, this makes a draw
        var isDraw = Board.Cast<Chess>().All(chess => chess != Chess.Null);

        return isDraw ? Chess.Draw : Chess.Null;
    }

    // Check if the player wins
    private bool CheckStatus(Chess who)
    {
        var aWin = "" + who + who + who;
        GetCurrentSituation();

        return Status.Any(check => check == aWin);
    }

    /* This function does moves to counter the human */
    public void BeatTheHuman(Chess human)
    {
        var humanChess = "" + human;
        var computerChess = human == Chess.X ? Chess.O : Chess.X;

        var possibleCompWins = FindPossibleWins("" + computerChess);
        // computer instant wins
        if (possibleCompWins.Count >= 1)
        {
            BlockOrPlace(possibleCompWins, computerChess);
        }
        // not so, block the user
        else
        {
            // we should stop the user first
            var possibleWins = FindPossibleWins(humanChess);

            // Opponent is going to win, so the computer block this
            if (possibleWins.Count >= 1)
            {
                BlockOrPlace(possibleWins, computerChess);
            }
            // if not, computer tries to win
            else
            {
                RandomChess(computerChess);
            }
        }

    }

    // Find possible wins for 'who'
    private List<int> FindPossibleWins(string who)
    {
        var possibleWins = new List<int>();
        foreach (var line in Status)
        {
            // If there's a "XX. / .XX / X.X" situation, this records as a winning situation for X.
            // But if the situation is like "XOX / XXO / OXX", then this is not a winning situation.
            if (!line.Contains(who + who) && !line.Equals(who + Chess.Null + who)) continue;
            
            var other = who.Equals("X") ? "O" : "X";
            if (!line.Contains(other))
                possibleWins.Add(Status.IndexOf(line));
        }
        return possibleWins;
    }

    // Block user or form a win
    private void BlockOrPlace(List<int> possibleWins, Chess computerChess)
    {
        var method = possibleWins.First();
        switch (method)
        {
            case 0:
                ComputerPlaceChess(0, 0, computerChess);
                break;
            case 1:
                ComputerPlaceChess(0, 1, computerChess);
                break;
            case 2:
                ComputerPlaceChess(0, 2, computerChess);
                break;
            case 3:
                ComputerPlaceChess(1, 0, computerChess);
                break;
            case 4:
                ComputerPlaceChess(1, 1, computerChess);
                break;
            case 5:
                ComputerPlaceChess(1, 2, computerChess);
                break;
            case 6:
                ComputerPlaceChess(2, 0, computerChess);
                break;
            case 7:
                ComputerPlaceChess(2, 1, computerChess);
                break;
        }
    }

    /*
     * This function place a chess for the computer to a designated index.
     *
     * The ultimate meaning for this function is to
     * block any possible 3-line-up of the human player,
     * or fill a computer's 2-line-up
     */
    private void ComputerPlaceChess(int method, int line, Chess chess)
    {
        switch (method)
        {
            // horizontal
            case 0:
                {
                    for (var i = 0; i < 3; i++)
                    {
                        if (Board[line, i] != Chess.Null) continue;
                        Board[line, i] = chess;
                        Console.WriteLine("Computer's move: {0},{1}", line, i);
                        break;
                    }
                    break;
                }
            // vertical
            case 1:
                for (var i = 0; i < 3; i++)
                {
                    if (Board[i, line] != Chess.Null) continue;
                    Board[i, line] = chess;
                    Console.WriteLine("Computer's move: {0},{1}", i, line);
                    break;
                }
                break;
            // cross
            default:
                if (line == 0)
                {
                    for (var i = 0; i < 3; i++)
                    {
                        if (Board[i, i] != Chess.Null) continue;
                        Board[i, i] = chess;
                        Console.WriteLine("Computer's move: {0},{1}", i, i);
                        break;
                    }
                }
                else
                {
                    for (var i = 0; i < 3; i++)
                    {
                        if (Board[i, 2 - i] != Chess.Null) continue;
                        Board[i, 2 - i] = chess;
                        Console.WriteLine("Computer's move: {0},{1}", i, 2 - i);
                        break;
                    }
                }
                break;
        }
    }

    /*
     * Chess to get the ultimate advantage.
     *
     * Its actually not completely random.
     */
    public void RandomChess(Chess computerChess)
    {
        // check middle
        if (Board[1, 1] == Chess.Null)
        {
            Board[1, 1] = computerChess;
            Console.WriteLine("Computer's move: 1,1");
            return;
        }
        // check corners
        if (Board[0, 0] == Chess.Null)
        {
            Board[0, 0] = computerChess;
            Console.WriteLine("Computer's move: 0,0");
            return;
        }
        if (Board[0, 2] == Chess.Null)
        {
            Board[0, 2] = computerChess;
            Console.WriteLine("Computer's move: 0,2");
            return;
        }
        if (Board[2, 0] == Chess.Null)
        {
            Board[2, 0] = computerChess;
            Console.WriteLine("Computer's move: 2,0");
            return;
        }
        if (Board[2, 2] == Chess.Null)
        {
            Board[2, 2] = computerChess;
            Console.WriteLine("Computer's move: 2,2");
            return;
        }
        // if these places are all full, do random
        for (var i = 0; i < 3; i++)
        {
            for (var j = 0; j < 3; j++)
            {
                if (Board[i, j] != Chess.Null) continue;
                Board[i, j] = computerChess;
                Console.WriteLine("Computer's move: {0},{1}", i, j);
                break;
            }
        }
    }

}