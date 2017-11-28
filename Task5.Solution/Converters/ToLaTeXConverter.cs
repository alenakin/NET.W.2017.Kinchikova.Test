using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Solution.Converters
{
    public class ToLaTeXConverter : Converter
    {
        public override string Convert(BoldText boldText) => "\\textbf{" + boldText.Text + "}";

        public override string Convert(Hyperlink hyperlink) => "\\href{" + hyperlink.Url + "}{" + hyperlink.Text + "}";

        public override string Convert(PlainText plainText) => plainText.Text;
    }
}
