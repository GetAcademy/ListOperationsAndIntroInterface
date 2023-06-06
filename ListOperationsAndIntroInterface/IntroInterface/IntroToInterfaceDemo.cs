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

            var b1 = new BulletPoint("a");
            var b2 = new BulletPoint("b");
            var b3 = new BulletPoint("c");
            a.Show();
            b.Show();
            b1.Show();
            b2.Show();
            b3.Show();
            c.Show();
            d.Show();
            e.Show();


                //var centeredHeader = part as CenteredHeader;
                //if (centeredHeader != null)
                //{
                //    centeredHeader.Show();
                //}

                //var indentedParagraph = part as IndentedParagraph;
                //if (indentedParagraph != null)
                //{
                //    indentedParagraph.Show();
                //}
                //if (part is CenteredHeader)
                //{
                //    var centeredHeader = (CenteredHeader)part;
                //    centeredHeader.
                //}
            }
        }
}
