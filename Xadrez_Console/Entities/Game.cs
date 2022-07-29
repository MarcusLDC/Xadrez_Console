using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez_Console.Entities.ChessBoard;
using Xadrez_Console.Entities.Enums;
using Xadrez_Console.Entities.Pieces;

namespace Xadrez_Console.Entities
{
    internal class Game
    {
        public Board Board { get; set; }
        public Game()
        {
            Board = Board.CreateEmptyBoard();
            SetPieces(Board);
        }
        private static void SetPieces(Board board)
        {
            SetPawns(board);
            SetKings(board);
            SetQueens(board);
            SetTowers(board);
            SetHorses(board);
            SetBishops(board);
        }

        private static void SetPawns(Board board)
        {
            for (int i = 0; i < 8; i++)
            {
                board.slots[6, i].Piece = new Pawn(Color.White);
                board.slots[1, i].Piece = new Pawn(Color.Black);
            }
        }
        private static void SetKings(Board board)
        {
            board.slots[7,4].Piece = new King(Color.White);
            board.slots[0,4].Piece = new King(Color.Black);
        }
        private static void SetQueens(Board board)
        {
            board.slots[7,3].Piece = new Queen(Color.White);
            board.slots[0,3].Piece = new Queen(Color.Black);
        }
        private static void SetTowers(Board board)
        {
            board.slots[7,0].Piece = new Tower(Color.White);
            board.slots[7,7].Piece = new Tower(Color.White);
            board.slots[0,0].Piece = new Tower(Color.Black);
            board.slots[0,7].Piece = new Tower(Color.Black);
        }
        private static void SetHorses(Board board)
        {
            board.slots[7,6].Piece = new Horse(Color.White);
            board.slots[7,1].Piece = new Horse(Color.White);
            board.slots[0,6].Piece = new Horse(Color.Black);
            board.slots[0,1].Piece = new Horse(Color.Black);
        }
        private static void SetBishops(Board board)
        {
            board.slots[7,2].Piece = new Bishop(Color.White);
            board.slots[7,5].Piece = new Bishop(Color.White);
            board.slots[0,2].Piece = new Bishop(Color.Black);
            board.slots[0,5].Piece = new Bishop(Color.Black);
        }
    }
}