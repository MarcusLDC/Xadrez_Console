using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez_Console.Entities;
using Xadrez_Console.Entities.ChessBoard;
using Xadrez_Console.Entities.Pieces;

namespace Xadrez_Console.Services
{
    internal class Application : ConsoleServices
    {
        static Game Game;
        internal static void Start()
        {
            do
            {
                Game = new Game();
                Game.Board.Print();

            } while (false);
        }
        private static void UpdateBoard()
        {
            
        }
    }
}