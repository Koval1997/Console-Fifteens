using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifteens
{
    class ConsoleGameUI
    {
        
        IPlayable objectIPlayable;
       
        public ConsoleGameUI(IPlayable objectIPlayable)
        {
            this.objectIPlayable = objectIPlayable;
        }

        public void Print()
        {
            Game array = objectIPlayable as Game;

            for (int i = 0; i < objectIPlayable.SizeOfField; i++)
            {
                for (int j = 0; j < objectIPlayable.SizeOfField; j++)
                {
                    Console.Write("{0}\t", array[i,j].Number);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        

        public void StartGame()
        {
            
            int value = 0;
            while (!objectIPlayable.IsFinished(objectIPlayable as Game))
            {
                Console.WriteLine("Поле перед ходом.");
                Print();
                Console.WriteLine("Введите число, которое хотите передвинуть.");
                value = Convert.ToInt32(Console.ReadLine());
                if ((value < 1) & (value > objectIPlayable.SizeOfField))
                {
                    throw new ArgumentException("Нет такого числа");
                }
                objectIPlayable.Shift(value);
                Console.WriteLine("Поле после хода.");
                Print();
            }
            Console.WriteLine("Поздравляю, Вы выйграли.");
        }


        
    }
}
