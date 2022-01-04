using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace WordCount
{
    public class TextCalculator
    {
        private List<string> _lines;
        private string _allText;

        public TextCalculator(List<string> lines)
        {
            _lines = lines;
            foreach (var x in _lines)
            {
                _allText += x;
            }
        }

        public int WordsCount()
        {
            var wordsCountResult = Regex
                .Matches(
                    _allText,
                    @"\w+").Cast<Match>().Select(m => m.Value).ToList();
            return wordsCountResult.Count;
        }

        public int CharsCount()
        {
            return _allText.Length;
        }

        public int LinesCount()
        {
            return _lines.Count;
        }
    }
}