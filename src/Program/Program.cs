using System;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {   
            var hola = new bool[3,3] {
                {true, false, false},
                {false, true, true},
                {true, true, false}
            };

            bool[,] tablero = Leer.leerArchivo(@"../../assets/board.txt");
            
            Imprimir.imprimirTablero(tablero);

        }
    }
}
