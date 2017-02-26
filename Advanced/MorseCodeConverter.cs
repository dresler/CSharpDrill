using System;
using Xunit;

namespace CSharpDrill.Advanced
{
    public class MorseCodeConverterTests
    {
        // Task: Implement MorseCodeConverter.ToMorseCode
        // Don't care about invalid characters.

        [Theory]
        [InlineData("", "")]
        [InlineData("a", ".-")]
        [InlineData("A", ".-")]
        [InlineData("42", "....-|..---")]
        [InlineData("Keep@it@secret!", "-.-|.|.|.--.|.--.-.|..|-|.--.-.|...|.|-.-.|.-.|.|-|-.-.--")]
        public void ToMorseCode_ForGivenText_ShouldReturnExpected(string text, string expectedMorseCode)
        {
            var morseCode = MorseCodeConverter.ToMorseCode(text);
            Assert.Equal(expectedMorseCode, morseCode);
        }

        // Task: Implement MorseCodeConverter.FromMorseCode
        // Don't care about invalid characters.

        [Theory]
        [InlineData("", "")]
        [InlineData("....|.|.-..|.--.|--|.", "helpme")]
        [InlineData("...|.|-.-.|.-.|.|-|...--|..---|----.|----.|---..|--...", "secret329987")]
        public void FromMorseCode_ForGivenText_ShouldReturnExpected(string morseCode, string expectedText)
        {
            var text = MorseCodeConverter.FromMorseCode(morseCode);
            Assert.Equal(expectedText, text);
        }
    }

    public static class MorseCodeConverter
    {
        public static string ToMorseCode(string text)
        {
            throw new NotImplementedException();
        }

        public static string FromMorseCode(string morseCode)
        {
            throw new NotImplementedException();
        }
    }

    public class MorseCodeConstants
    {
        public static string MorseCodesSeparator = "|";
        public static string MorseAlphabetAsJson =
            @"
{
  ""0"": ""-----"",
  ""1"": "".----"",
  ""2"": ""..---"",
  ""3"": ""...--"",
  ""4"": ""....-"",
  ""5"": ""....."",
  ""6"": ""-...."",
  ""7"": ""--..."",
  ""8"": ""---.."",
  ""9"": ""----."",
  ""a"": "".-"",
  ""b"": ""-..."",
  ""c"": ""-.-."",
  ""d"": ""-.."",
  ""e"": ""."",
  ""f"": ""..-."",
  ""g"": ""--."",
  ""h"": ""...."",
  ""i"": "".."",
  ""j"": "".---"",
  ""k"": ""-.-"",
  ""l"": "".-.."",
  ""m"": ""--"",
  ""n"": ""-."",
  ""o"": ""---"",
  ""p"": "".--."",
  ""q"": ""--.-"",
  ""r"": "".-."",
  ""s"": ""..."",
  ""t"": ""-"",
  ""u"": ""..-"",
  ""v"": ""...-"",
  ""w"": "".--"",
  ""x"": ""-..-"",
  ""y"": ""-.--"",
  ""z"": ""--.."",
  ""."": "".-.-.-"",
  "","": ""--..--"",
  ""?"": ""..--.."",
  ""!"": ""-.-.--"",
  ""-"": ""-....-"",
  ""/"": ""-..-."",
  ""@"": "".--.-."",
  ""("": ""-.--."",
  "")"": ""-.--.-""
}";
    }
}

