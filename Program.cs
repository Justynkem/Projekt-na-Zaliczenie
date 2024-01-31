using System;
using System.Data.Common;
using System.Reflection.Metadata;
using System.Threading;

internal class Program
{
    private static void Main(string[] args)
    
    {
        char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        int player = 1;
        int choice = 0;
        int flag = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Hello welcome in the game. Player 1 symbol is O, and player 2 symbol is X");
                Console.WriteLine("");
                Console.WriteLine("The board shows numbers beetween 1 and 9, enter number to mark place you want ");
                Console.WriteLine("");

                if (player % 2 == 0)
                {
                    Console.WriteLine("Player 2, it's your turn");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Player 1, it's your turn");
                    Console.WriteLine("");
                }
                Console.WriteLine("\n");
                Board();
                choice = int.Parse(Console.ReadLine());
                if (arr[choice] != 'X' && arr[choice] != 'O')
                {
                    if (player % 2 == 0)
                    {
                        arr[choice] = 'X';
                        player++;

                    }
                    else
                    {
                        arr[choice] = 'O';
                        player++;
                    }

                }

                else
                {
                    Console.WriteLine("Choose different row, this one is already marked");
                    Console.WriteLine("\n");
                    Console.WriteLine("Please, wait for a while, the board is reloading");
                    Thread.Sleep(2000);

                }

                flag = CheckWin();

            }
            while (flag != 1 && flag != -1);
            Console.Clear();
            Board();
            if (flag == 1)
            {
                Console.WriteLine("Player {0} has won the game", player % 2 + 1);
                Console.WriteLine("");
                Console.WriteLine("The game is over now");
                Console.WriteLine("");
                Console.WriteLine("Press enter to leave");
                
            }
            else
            {
                Console.WriteLine("It's a draw");
                Console.WriteLine("");
                Console.WriteLine("Maybe it's time for another round?");
                Console.WriteLine("");


            }
            Console.ReadLine();
            void Board()
            {
                Console.WriteLine("     |     |      ");
                Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
                Console.WriteLine("_____|_____|_____ ");
                Console.WriteLine("     |     |      ");
                Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
                Console.WriteLine("_____|_____|_____ ");
                Console.WriteLine("     |     |      ");
                Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
                Console.WriteLine("     |     |      ");
            }
            int CheckWin()
            {
                #region Horzontal Winning Condtion
                if (arr[1] == arr[2] && arr[2] == arr[3])
                {
                    return 1;
                }
                else if (arr[4] == arr[5] && arr[5] == arr[6])
                {
                    return 1;
                }
                else if (arr[7] == arr[8] && arr[8] == arr[9])
                {
                    return 1;
                }
                #endregion
                #region Veritical Winning Condition
                if (arr[1] == arr[4] && arr[4] == arr[7])
                {
                    return 1;
                }
                else if (arr[2] == arr[5] && arr[5] == arr[8])
                {
                    return 1;
                }
                else if (arr[3] == arr[6] && arr[6] == arr[9])
                {
                    return 1;
                }
                #endregion
                #region Diagonal Winning Condiditon
                if (arr[1] == arr[5] && arr[5] == arr[9])
                {
                    return 1;
                }
                else if (arr[3] == arr[5] && arr[5] == arr[7])
                {
                    return 1;
                }
                #endregion
                #region Checking For Draw
                else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
                {
                    return -1;
                }
                #endregion
                else
                {
                    return 0;
                }


            }
        }
 }
