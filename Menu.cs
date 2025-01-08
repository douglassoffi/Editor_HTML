using System;
using Microsoft.VisualBasic;


namespace HTMLEditor
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();

            // Aqui o usuário deveria informar o tamnho da tela que ele deseja mas para testes o valor será padronizado para 23/10
            // var (columnSize, lineSize) = Screem.GetScreemSize();

            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            Screem.DrawScreem(23, 10);

            WriteOptions();

            int option = int.Parse(Console.ReadLine());

            HandleMenuOption(option);
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("EDITOR HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("===========");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção:");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo Arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");
        }

        public static void HandleMenuOption(int option)
        {
            switch (option)
            {
                case 1: Console.WriteLine("Editor"); break;
                case 2: Console.WriteLine("Abrir"); break;
                case 0: return;
                default: Show(); break;
            }
        }
    }
}