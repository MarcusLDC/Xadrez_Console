using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xadrez_Console.Services
{
    internal class ConsoleServices
    {
        internal static T GetFromConsole<T>(string text)
        {
            Console.Write(text);
            string input = Console.ReadLine();
            return (T)Convert.ChangeType(input, typeof(T));
        }
    }
}
