using System;
using System.Linq;
using Xunit;

namespace AnagramLib.Test
{
    public class Anagram
    {
        [Fact]
        public void Initialize()
        {
            var data = new AnagramLib.Anagram();
            
            Assert.NotNull(data.WordList);
        }

        [Fact]
        public void OneWordTest1()
        {
            var anagram = new AnagramLib.Anagram();

            var result = anagram.OneWordAnagram("etst");

            Assert.NotNull(result);
            Assert.Equal(result.Count, 1);
            Assert.Equal(result[0], "test");
        }

        [Fact]
        public void OneWordTest2()
        {
            var anagram = new AnagramLib.Anagram();

            var result = anagram.OneWordAnagram("ititraž");

            Assert.NotNull(result);
            Assert.Equal(result.Count, 1);
            Assert.Equal(result[0], "tražiti");
        }


        [Fact]
        public void MultipleWordAnagramTest1()
        {
            var anagram = new AnagramLib.Anagram();

            var result = anagram.MultipleWordAnagramWith("Gospin dolac", "", 5);

            Assert.NotNull(result);
            Assert.True(result.Count > 0);
        }
    }
}
