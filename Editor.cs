using System.Text;

namespace HTMLEditor
{
    public static class Editor
    {
        public static void Show()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Clear();

            Console.WriteLine("Editor");
            Console.WriteLine("------\n");

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

            Console.Clear();

            Viewer.Replace(text.ToString());
            Console.ReadKey();

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Deseja salvar o arquivo? [s - SIM | n - NÃO]");

            char option = char.Parse(Console.ReadLine().ToLower());

            if (option == 's')
                Save(text.ToString());

            else if (option == 'n')
            {
                Console.Clear();
                Environment.Exit(0);
            }
        }

        public static void Save(string text)
        {
            Console.Clear();
            Console.WriteLine("Informe o nome do arquivo: ");

            var path = Console.ReadLine();

            using var file = new StreamWriter("text/" + path + ".txt");
            file.Write(text);

            Console.Clear();
            Console.WriteLine("Arquivo salvo em {path}");

            Menu.Show();
        }
    }
}