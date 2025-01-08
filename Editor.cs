using System.Text;

namespace HTMLEditor
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Editor");
            Console.WriteLine("------");

            Start();

        }
        public static void Start()
        {
            var text = new StringBuilder();

            do
            {
                text.Append(Console.ReadLine());
                text.Append(Environment.NewLine);

            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine(" --------------------------------------------");
            Console.WriteLine(" Deseja salvar o arquivo? [s - SIM | n - NÃO]");

            char option = char.Parse(Console.ReadLine().ToLower());

            if (option == 's')
                Save(text);

            else if (option == 'n')
            {
                Console.Clear();
                Environment.Exit(0);
            }
        }

        public static void Save(StringBuilder text)
        {
            Console.Clear();
            Console.WriteLine("Informe o caminho para salvar o arquivo: ");

            var path = Console.ReadLine();

            using var file = new StreamWriter(path);
            file.Write(text);

            Console.Clear();
            Console.WriteLine("Arquivo salvo em {path}");

            Menu.Show();
        }
    }
}