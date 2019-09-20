namespace WrekaChess.Console
{
    using System.Collections.Generic;
    using Lib.Models;
    using Lib.Utils;
    using Console = System.Console;

    class Program
    {
        static void Main(string[] args)
        {
            var pieces = new List<Piece>();
            for (int i = 1; i <= 8; i++)
            {
                pieces.Add(new Pawn(true, i));
                pieces.Add(new Pawn(false, i));
            }
            Drawer.WriteBoard(pieces.ToArray());
            Console.ReadKey();
        }
    }
}
