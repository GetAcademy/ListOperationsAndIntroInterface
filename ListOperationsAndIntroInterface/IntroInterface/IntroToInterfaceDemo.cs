namespace ListOperationsAndIntroInterface.IntroInterface
{
    internal class IntroToInterfaceDemo
    {
        public static void Run()
        {
            var a = new CenteredHeader("Overskrift 1");
            var b = new IndentedParagraph("Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. ");
            var c = new IndentedParagraph("Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. ");
            var d = new CenteredHeader("Overskrift 2");
            var e = new IndentedParagraph("Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. Bla bla bla. ");

            var f1 = new BulletPoint("a");
            var f2 = new BulletPoint("b");
            var f3 = new BulletPoint("c");
            //a.Show();
            //b.Show();
            //c.Show();
            //d.Show();
            //e.Show();
            //f1.Show();
            //f2.Show();
            //f3.Show();

            var myTextElements = new ITextElement[] { a, b, c, d, e, f1, f2, f3};
            foreach (ITextElement myTextElement in myTextElements)
            {
                myTextElement.Show();
            }



            /*
                if (myTextElement is CenteredHeader)
                {
                    var centeredHeader = (CenteredHeader)myTextElement;
                    centeredHeader.Show();
                }
                // (myTextElement as CenteredHeader)?.Show();
             */
        }
    }
}
