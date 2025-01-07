using System;
using Microsoft.VisualBasic;


namespace HTMLEditor
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();

            var (columnSize, lineSize) = Screem.GetScreemSize();

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            Screem.DrawScreem(columnSize, lineSize);
        }

    }
}