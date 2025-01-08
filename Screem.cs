using System;

namespace HTMLEditor
{
    public class Screem()
    {
        public static void DrawScreem(int columnSize, int lineSize)
        {
            CreateColumn(columnSize);
            CreateLine(columnSize, lineSize);
            CreateColumn(columnSize);
        }

        // Cria as colunas da tela
        public static void CreateColumn(int columnSize)
        {
            Console.Write("+");
            for (int column = 0; column <= columnSize; column++)
                Console.Write("-");
            Console.Write("+");
            Console.Write("\n");
        }

        // Cria as linhas da tela.
        public static void CreateLine(int columnSize, int lineSize)
        {
            for (int line = 0; line <= lineSize; line++)
            {
                Console.Write("|");
                for (int column = 0; column <= columnSize; column++)
                    Console.Write(" ");
                Console.Write("|");
                Console.Write("\n");
            }
        }

        // Define o tamaho da Tela que será gerada.
        public static (int, int) GetScreemSize()
        {
            Console.WriteLine("Qual tamanho de tela desejada?\n");

            Console.WriteLine("Tamanho da COLUNA (MÍNIMO 23 | MÁXIMO 50):");
            int columnSize = GetColumnSize();

            Console.WriteLine("\nTamanho da LINHA: (MÍNIMO 10 | MÁXIMO 50)");
            int lineSize = GetLineSize();

            return (columnSize, lineSize);
        }

        public static int GetColumnSize()
        {
            int number;
            while (!int.TryParse(Console.ReadLine(), out number) || number < 23 || number > 50) { }
            return number;
        }

        public static int GetLineSize()
        {
            int number;
            while (!int.TryParse(Console.ReadLine(), out number) || number < 10 || number > 50) { }
            return number;
        }
    }
}