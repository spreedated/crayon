namespace Crayon
{
    public class OutputBuilderIgnoreFormat : IOutput
    {
        public IOutput Black() => this;
        public IOutput Red() => this;
        public IOutput Green() => this;
        public IOutput Yellow() => this;
        public IOutput Blue() => this;
        public IOutput Magenta() => this;
        public IOutput Cyan() => this;
        public IOutput White() => this;

        public string Black(string text) => text;
        public string Red(string text) => text;
        public string Green(string text) => text;
        public string Yellow(string text) => text;
        public string Blue(string text) => text;
        public string Magenta(string text) => text;
        public string Cyan(string text) => text;
        public string White(string text) => text;

        public IOutput Rgb(byte r, byte g, byte b) => this;
        public string Rgb(byte r, byte g, byte b, string text) => text;


        public IOutput Bold() => this;
        public IOutput Dim() => this;
        public IOutput Underline() => this;
        public IOutput Reversed() => this;
        public string Bold(string text) => Text(text);
        public string Dim(string text) => Text(text);
        public string Underline(string text) => Text(text);
        public string Reversed(string text) => Text(text);

        public IBright Bright => new Bright(this);
        public IBackground Background => new Background(this);

        public string Text(string text) => text;
        public IOutput Append(string format) => this;
    }
}