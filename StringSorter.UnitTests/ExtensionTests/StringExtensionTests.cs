using System;
using StringSorter.ConsoleApp.Extensions;
using NUnit.Framework;

namespace StringSorter.UnitTests.ExtensionTests
{
    [TestFixture]
    public class StringExtensionTests
    {
        [Test]
        public void SortString_InputIsEmpty_ReturnsEmptyArray()
        {
            var input = string.Empty;

            var result = input.SortString();

            Assert.IsEmpty(result, "Should return empty array when input string is empty.");
        }

        [Test]
        public void SortString_InputHasValue_ReturnsSortedCharArray()
        {
            var input = "contrary";

            var result = input.SortString();

            Assert.Multiple(() =>
            {
                Assert.AreEqual(result[0], 'a');
                Assert.AreEqual(result[1], 'c');
                Assert.AreEqual(result[2], 'n');
                Assert.AreEqual(result[3], 'o');
                Assert.AreEqual(result[4], 'r');
                Assert.AreEqual(result[5], 'r');
                Assert.AreEqual(result[6], 't');
                Assert.AreEqual(result[7], 'y');
            });
        }

        [Test]
        public void CleanInputString_InputIsEmpty_ReturnsEmptyString()
        {
            var input = string.Empty;

            var result = input.CleanInputString();

            Assert.IsEmpty(result, "Should return empty string when input string is empty.");
        }

        [Test]
        public void CleanInputString_InputContainsOnlyPunctuationAndWhitespaces_ReturnsEmptyString()
        {
            var input = " #$% !, ...";

            var result = input.CleanInputString();

            Assert.IsEmpty(result, "Should return empty string when input string is empty.");
        }

        [Test]
        public void CleanInputString_InputContains_Punctuation_UpperCase_Whitespace_ReturnsLowerCaseWords()
        {
            var input = "Contrary to popular belief, the pink unicorn flies east.";

            var result = input.CleanInputString();

            Assert.AreEqual("contrarytopopularbeliefthepinkunicornflieseast", result, "Should return string with whitespaces and punctuation removed as well as all letters set to lowercase.");
        }
    }    
}
