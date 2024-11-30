using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Game = new Program();
            char[] symbolsMap = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
            int queue = 0;
            string queueName = "";
            int str = 0;
            int column = 0;
            int index = 0;
            int count = 0;
            while (count<9)
            {
                Game.PrintMap(symbolsMap);
                if(queue == 0) { queueName = "Нолики"; } else { queueName = "Крестики"; };
                Console.Write("Введите строку, куда хотите поставить свой символ: ");
                str = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите столбец, куда хотите поставить свой символ: ");
                column = Convert.ToInt32(Console.ReadLine());
                index = Game.TranslateToIngex(str, column);
                if (symbolsMap[index] == ' ')
                {
                    Game.InsertSymb(symbolsMap, queue, index);
                    if (queue == 0){queue++;}else{queue--;};
                }
                else
                {
                    Console.WriteLine("Выбрана занятая клетка. Переход.");
                    count--;
                }
                count++;
            }
            Game.PrintMap(symbolsMap);
            Console.Read();
        }
        void PrintMap(char[] symbolsMap)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{symbolsMap[0+3*i]}" + "|" + $"{symbolsMap[1+3*i]}" + "|" + $"{symbolsMap[2+3*i]}");
                if (i != 2){ Console.WriteLine("-----");};;
            }
        }

        int TranslateToIngex(int str, int column)
        {
            int x = 0;
            int y = 0;
            int iter = 0;
            switch (str)
            {
                case 1:
                    x = 0;
                    break;
                case 2:
                    x = 3;
                    break;
                case 3:
                    x = 6;
                    break;
            }
            for (int i = x; i < (x+3); i++)
            {if (iter == (column - 1)){y = iter; break;} iter++;}
            return (x+y);
        }

        char[] InsertSymb(char[] symbolsMap, int queue, int index)
        {
            char symb = 'X';
            if (queue == 0) symb = '0';
            symbolsMap[index] = symb;
            return symbolsMap;
        }

        bool CheckWin(char[] symbolsMap)
        {
            return false;
        }
    }
}
