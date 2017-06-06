using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AnagramLib
{
    public class Anagram
    {
        private const string wordlistNameFileName = "WordList.txt";
        public List<StringCharaterCount> WordList { get; set; }

        public Anagram()
        {
            InitializeWordList();
        }

        public List<string> OneWordAnagram(string anagramResult)
        {
            return new List<string>();
        }

        private void InitializeWordList()
        {
            WordList = new List<StringCharaterCount>();
            

            const Int32 BufferSize = 128;
            using (var fileStream = File.OpenRead(wordlistNameFileName))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
            {
                String line;
                while ((line = streamReader.ReadLine()) != null)
                    WordList.Add(new StringCharaterCount(line));
            }
        }
    }
}
