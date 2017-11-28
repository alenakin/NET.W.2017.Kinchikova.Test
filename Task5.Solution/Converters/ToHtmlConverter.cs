using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Solution.Converters
{
    public class ToHtmlConverter : Converter
    {
        public override string Convert(BoldText boldText) => "<b>" + boldText.Text + "</b>";

        public override string Convert(Hyperlink hyperlink) => "<a href=\"" + hyperlink.Url + "\">" + hyperlink.Text + "</a>";

        public override string Convert(PlainText plainText) => plainText.Text;
    }
}
