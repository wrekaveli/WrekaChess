namespace WrekaChess.Lib.Models
{
    public class Pawn : Piece
    {
        public Pawn(bool isWhite, int x) : base(isWhite)
        {
            this.Y = this.IsWhite ? 2 : 7;
            this.X = x;
        }

        public override char Symbol => this.IsWhite ? '\u2659' : '\u265F';
        public override bool Move(int x, int y)
        {
            throw new System.NotImplementedException();
        }
    }
}
