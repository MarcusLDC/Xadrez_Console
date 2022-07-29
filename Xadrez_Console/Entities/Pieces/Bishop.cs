using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez_Console.Entities.ChessBoard;
using Xadrez_Console.Entities.Enums;

namespace Xadrez_Console.Entities.Pieces
{
    internal class Bishop : Piece
    {
        public Bishop(Color color) : base(color)
        {

        }

        public override void Move(Board board)
        {
            throw new NotImplementedException();
        }

        public override string Print()
        {
            return "B";
        }
    }
}
