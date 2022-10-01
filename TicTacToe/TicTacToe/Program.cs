namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] Board = new string[3, 3];
            int Columns = 3;
            int Rows = 3;
            string Player1 = ".";
            string Player2 = ".";
            SetupGame(Board, Rows, Columns, ref Player1, ref Player2);
            PrintBoard(Board, Rows, Columns);
            while(!GameOver(Board, ref Player1) && !GameOver(Board, ref Player2))
            {
                PlayGame(Board, Rows, Columns, ref Player1, ref Player2);
                PrintBoard(Board, Rows, Columns);
                

            }
        }

        public static void PlayGame(string[,] board, int rows, int columns, ref string player1, ref string player2)
        {
            SetPosition(board, player1);
            SetPosition(board, player2);

        }

        public static bool GameOver(string[,] board, ref string player)
        {
            string TopRow = board[0, 0] + board[0, 1] + board[0, 2];
            string MidRow = board[1, 0] + board[1, 1] + board[1, 2];
            string BotRow = board[2, 0] + board[2, 1] + board[2, 2];
            string LeftColumn = board[0, 0] + board[1, 0] + board[2, 0];
            string MidColumn = board[0, 1] + board[1, 1] + board[2, 1];
            string RightColumn = board[0, 2] + board[1, 2] + board[2, 2];
            string diagon = board[0, 0] + board[1, 1] + board[2, 2];
            string diagonRev = board[0, 2] + board[1, 1] + board[2, 0];
            string playerTriple = player + player + player;
            if (TopRow.Equals(playerTriple)
                || MidRow.Equals(playerTriple)
                || BotRow.Equals(playerTriple)
                || LeftColumn.Equals(playerTriple)
                || MidColumn.Equals(playerTriple)
                || RightColumn.Equals(playerTriple)
                || diagon.Equals(playerTriple)
                || diagonRev.Equals(playerTriple))
            {
                return true;
            }
            else return false;

        }

        public static void PrintBoard(string[,] board, int rows, int columns)
        {
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(board[i, j]);
                }
                Console.WriteLine();
            }
        }
        public static void SetPosition(string[,] board, string player)
        {
            Console.WriteLine($"Player {player} choose a row (0 - 2)");
            int playerRow = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Player {player} choose a column (0 - 2)");
            int playerColumn = Int32.Parse(Console.ReadLine());
            board[playerRow, playerColumn] = player;
        }

        public static void SetupGame(string[,] board, int rows, int columns, ref string player1, ref string player2)
        {
            for(var i = 0; i < rows; i++)
            {
                for(var j = 0; j < 3; j++)
                {
                    board[i, j] = ".";

                }

            }
                Console.WriteLine("Player 1: choose 'x' or 'o'");
                player1 = Console.ReadLine();
                Console.WriteLine("Player 2: choose 'x' or 'o'");
                player2 = Console.ReadLine();
        }
    }
}
