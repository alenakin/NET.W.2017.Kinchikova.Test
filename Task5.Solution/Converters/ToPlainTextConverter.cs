using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Solution.Converters
{
    public class ToPlainTextConverter : Converter
    {
        public override string Convert(BoldText boldText) => "**" + boldText.Text + "**";

        public override string Convert(Hyperlink hyperlink) => hyperlink.Text + " [" + hyperlink.Url + "]";

        public override string Convert(PlainText plainText) => plainText.Text;
    }
}
