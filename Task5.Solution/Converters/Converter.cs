using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Solution
{
    public abstract class Converter
    {
        public string Convert(Document document)
        {
            StringBuilder result = new StringBuilder();

            foreach(DocumentPart part in document.Parts)
            {
                result.Append(ConvertDocumentPart(part));
            }

            return result.ToString();
        }

        private string ConvertDocumentPart(DocumentPart documentPart)
        {
            if (documentPart.GetType() == typeof(BoldText))
                return Convert((BoldText)documentPart);
            if (documentPart.GetType() == typeof(PlainText))
                return Convert((PlainText)documentPart);
            if (documentPart.GetType() == typeof(Hyperlink))
                return Convert((Hyperlink)documentPart);
            return String.Empty;
        }

        public abstract string Convert(BoldText boldText);

        public abstract string Convert(Hyperlink hyperlink);

        public abstract string Convert(PlainText plainText);
    }
}
