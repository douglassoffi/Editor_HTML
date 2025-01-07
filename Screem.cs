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
            Console.WriteLine("Qual tamanho de tela desejada?\n" + "VALOR RECOMENDADO: 30/10\n");

            Console.WriteLine("Tamanho da COLUNA:");
            int columnSize = ReadPositiveNumber();

            Console.WriteLine("\nTamanho da LINHA:");
            int lineSize = ReadPositiveNumber();

            return (columnSize, lineSize);
        }

        public static int ReadPositiveNumber()
        {
            int number;
            while (!int.TryParse(Console.ReadLine(), out number) || number <= 0) { }
            return number;
        }
    }
}