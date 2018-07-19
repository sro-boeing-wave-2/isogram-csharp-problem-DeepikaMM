using System;
using isogram_csharp_problem;
using Xunit;
using isogram_csharp_problem;
namespace isogram_csharp_problem.Tests
{

    public class program

    {

        bool expected = true;

        [Fact]
        public void isogram_emptyString()
        {

            Assert.Equal(expected, isogramClient.IsIsogram(""));
        }

        [Fact]
        public void isogram_lower_case_characters()
        {
            Assert.Equal(expected, isogramClient.IsIsogram("isogram"));
        }

        [Fact]
        public void isogram_wrong_input()
        {
            expected = false;
            Assert.Equal(expected, isogramClient.IsIsogram("isograms"));
        }

        [Fact]
        public void isogram_duplicated_charcacters_mixed_case()
        {
            Assert.Equal(expected, isogramClient.IsIsogram("God"));
        }

        [Fact]
        public void isogram_long_english_word()
        {
            Assert.Equal(expected, isogramClient.IsIsogram("subdermatoglyphic"));
        }

        [Fact]
        public void isogram_with_huphen()
        {
            Assert.Equal(expected, isogramClient.IsIsogram("OMG-cat"));
        }


        [Fact]
        public void isogram_with_duplicated_hyphen()
        {
            Assert.Equal(expected, isogramClient.IsIsogram("hi-by-e"));
        }

        [Fact]
        public void isogram_with_spaces()
        {
            Assert.Equal(expected, isogramClient.IsIsogram("the lazy dog"));
        }
    }
}

