namespace Crayon
{
    public class Background : IBackground
    {
        private readonly IOutput _chain;

        public Background(IOutput chain) => _chain = chain;

        public IOutput Black() => AppendFormat(Colors.Black);
        public IOutput Red() => AppendFormat(Colors.Red);
        public IOutput Green() => AppendFormat(Colors.Green);
        public IOutput Yellow() => AppendFormat(Colors.Yellow);
        public IOutput Blue() => AppendFormat(Colors.Blue);
        public IOutput Magenta() => AppendFormat(Colors.Magenta);
        public IOutput Cyan() => AppendFormat(Colors.Cyan);
        public IOutput White() => AppendFormat(Colors.White);

        public string Black(string text) => Black().Text(text);
        public string Red(string text) => Red().Text(text);
        public string Green(string text) => Green().Text(text);
        public string Yellow(string text) => Yellow().Text(text);
        public string Blue(string text) => Blue().Text(text);
        public string Magenta(string text) => Magenta().Text(text);
        public string Cyan(string text) => Cyan().Text(text);
        public string White(string text) => White().Text(text);
        public IOutput Rgb(byte r, byte g, byte b) => _chain.Append($"\u001b[48;2;{r};{g};{b}m");
        public string Rgb(byte r, byte g, byte b, string input) => Rgb(r, g, b).Text(input);

        private IOutput AppendFormat(int code) => _chain.Append($"\u001b[{code + 10}m");
    }
}