using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez_Console.Entities.ChessBoard;
using Xadrez_Console.Entities.Enums;

namespace Xadrez_Console.Entities.Pieces
{
    internal abstract class Piece
    {
        public Color Color { get; }
        protected Piece(Color color)
        {
            Color = color;
        }
        public abstract void Move(Board board);
        public abstract string Print();
    }
}
