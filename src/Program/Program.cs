﻿using System;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {   
            bool[,] tablero = ReadArchive.readArchive(@"../../assets/board.txt");
            
            Print.printGameboard(tablero);

        }
    }
}
