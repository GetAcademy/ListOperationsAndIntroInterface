namespace ListOperationsAndIntroInterface.IntroInterface
{
    internal class CenteredHeader
    {
        private string _text;

        public CenteredHeader(string text)
        {
            _text = text;
        }

        public void Show()
        {
            var startPos = (Console.WindowWidth - _text.Length) / 2;
            var dashCount = startPos - 4;
            var dashes = "  " + string.Empty.PadLeft(dashCount, '-') + "  ";
            Console.Write(dashes);
            Console.Write(_text);
            Console.WriteLine(dashes);
        }
    }
}
