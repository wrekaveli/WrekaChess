using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrekaChess.Lib.Utils
{
    using Models;

    public class Drawer
    {
        public static void WriteBoard(Piece[] pieces)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            WriteAt(0, 0, ' ');

            Console.Clear();
            Console.OutputEncoding = Encoding.UTF8;

            int boardLength = 8;
            for (int i = 0; i < boardLength; i++)
            {
                WriteAt(0, i, (char)(boardLength - i + 48));
                WriteAt(i + 1, boardLength, (char)(65 + i));
            }

            for (int i = 0; i < boardLength; i++)
            {
                for (int j = 0; j < boardLength; j++)
                {
                    if ((i % 2 == 0 && j % 2 == 0) || (i % 2 == 1 && j % 2 == 1))
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                    }

                    var piece = pieces?.FirstOrDefault(x => x.X == i + 1 && x.Y == j + 1);
                    if (piece != null)
                    {
                        if (piece.IsWhite)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                        }
                        WriteAt(i + 1, boardLength - j - 1, piece.Symbol);
                    }
                    else
                    {
                        WriteAt(i + 1, boardLength - j - 1, ' ');
                    }
                }
            }

            Console.BackgroundColor = ConsoleColor.Black;
            WriteAt(0, 8, ' ');
        }

        private static void WriteAt(int left, int top, char character)
        {
            Console.SetCursorPosition(left * 2, top);
            if (character < 128)
            {
                Console.Write(character + " ");
            }
            else
            {
                Console.Write(character);
            }
            
        }
    }
}
