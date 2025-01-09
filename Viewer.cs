using System.Text.RegularExpressions;

namespace HTMLEditor
{
    public static class Viewer
    {
        public static void Show()
        {
            // Console.BackgroundColor = ConsoleColor.White;
            // Console.ForegroundColor = ConsoleColor.Black;

            Console.Clear();

            Console.WriteLine("Vizualizador");
            Console.WriteLine("------------");
        }

        public static void Replace(string text)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var words = text.Split(' ');
            for (var i = 0; i < words.Length; i++)
            {
                if (strong.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(
                        words[i].Substring(
                            words[i].IndexOf('>') + 1,
                            ((words[i].LastIndexOf('<') - 1) - words[i].IndexOf('>'))
                        )
                    );
                    Console.Write(" ");
                }
                else
                {
                    // Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(words[i]);
                    Console.Write(" ");
                }
            }
        }

        public static void Open()
        {
            Console.Clear();

            // Console.BackgroundColor = ConsoleColor.White;
            // Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Qual o nome do arquivo?");
            string path = Console.ReadLine();

            using (var file = new StreamReader("text/" + path + ".txt"))
            {
                string text = file.ReadToEnd();
                Replace(text.ToString());
            }
            Console.ReadKey();

            Menu.Show();
        }
    }
}