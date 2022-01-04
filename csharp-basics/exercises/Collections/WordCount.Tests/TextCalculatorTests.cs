using System;
using System.Collections.Generic;
using Xunit;

namespace WordCount.Tests
{
    public class TextCalculatorTests
    {
        private TextCalculator _target;

        public TextCalculatorTests()
        {
            var text = new List<string>()
            {
                "Mani sauc Davis ",
                "Dzivesvieta Saulraksti"
            };
            _target = new TextCalculator(text);
        }

        [Fact]
        public void CharsCount_Chars38_ShouldReturn38()
        {
            //Arange
            var chars = 38;

            //Act
            var charsCount = _target.CharsCount();

            //Assert
            Assert.Equal(chars, charsCount);
        }

        [Fact]
        public void LinesCount_Lines2_ShouldReturn2()
        {
            //Arange
            var lines = 2;

            //Act
            var linesCount = _target.LinesCount();

            //Assert
            Assert.Equal(lines, linesCount);
        }

        [Fact]
        public void WordsCount_words5_ShouldReturn5()
        {
            //Arange
            var words = 5;

            //Act
            var wordsCount = _target.WordsCount();

            //Assert
            Assert.Equal(words, wordsCount);
        }
    }
}