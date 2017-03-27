using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifteens
{
    class Program
    {
        static void Main(string[] args)
        {
            Game2 field2 = new Game2(1, 6, 4, 0, 2, 3, 5, 7, 8, 11, 10, 9, 14, 12, 13, 15);
            Game3 field3 = new Game3(0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15);

            ConsoleGameUI obj = new ConsoleGameUI(field2);
            obj.startGame();
            
        }
    }
}
