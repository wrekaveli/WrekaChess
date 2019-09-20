using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrekaChess.Lib.Models
{
    public abstract class Piece
    {
        public int X { get; set; }
        public int Y { get; set; }

        public bool IsWhite { get; set; }

        public abstract char Symbol { get; }

        public Piece(bool isWhite)
        {
            this.IsWhite = isWhite;
        }

        public abstract bool Move(int x, int y);
    }
}
