using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOperationsAndIntroInterface.IntroInterface
{
    internal class BulletPoint : ITextElement
    {
        private string _text;

        public BulletPoint(string text)
        {
            _text = text;
        }

        public void Show()
        {
            Console.Write(" * ");
            Console.WriteLine(_text);
        }
    }
}
