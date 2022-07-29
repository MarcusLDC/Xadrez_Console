using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez_Console.Entities.Enums;

namespace Xadrez_Console.Entities.ChessBoard
{
    internal class Board
    {
        public Slot[,] slots = new Slot[8, 8];
        public static Board CreateEmptyBoard()
        {
            Board board = new Board();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    board.slots[i, j] = new Slot();
                }
            }
            return board;
        }
        public void Print()
        {
            for (int i = 0; i < slots.GetLength(0); i++)
            {
                for (int j = 0; j < slots.GetLength(1); j++)
                {
                    var slot = slots[i, j];

                    ChangeColor(slot.Piece?.Color);

                    Console.Write(slot.Piece?.Print() ?? "-");

                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        private static void ChangeColor(Color? color)
        {
            Console.ForegroundColor = color == Color.Black ? ConsoleColor.Yellow : ConsoleColor.White;
        }
    }
}
