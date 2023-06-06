namespace ListOperationsAndIntroInterface.IntroInterface
{
    internal class IndentedParagraph
    {
        private string _text;

        public IndentedParagraph(string text)
        {
            _text = text;
        }

        public void Show()
        {
            Console.CursorLeft = 8;
            Console.WriteLine(_text);
        }
    }
}
