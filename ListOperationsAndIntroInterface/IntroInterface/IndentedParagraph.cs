namespace ListOperationsAndIntroInterface.IntroInterface
{
    internal class IndentedParagraph : ITextElement
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
