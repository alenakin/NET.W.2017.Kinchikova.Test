namespace Task5.Console
{
    using System.Collections.Generic;
    using System;
    using Task5.Solution;
    using Task5.Solution.Converters;

    class Program
    {
        static void Main(string[] args)
        {
            List<DocumentPart> parts = new List<DocumentPart>
                {
                    new PlainText {Text = "Some plain text"},
                    new Hyperlink {Text = "google.com", Url = "https://www.google.by/"},
                    new BoldText {Text = "Some bold text"}
                };

            var htmlConverter = new ToHtmlConverter();
            var plainTextConverter = new ToPlainTextConverter();
            var laTeXConverter = new ToLaTeXConverter();
            Document document = new Document(parts);

            Console.WriteLine(htmlConverter.Convert(document));

            Console.WriteLine(plainTextConverter.Convert(document));

            Console.WriteLine(laTeXConverter.Convert(document));
        }
    }
}
