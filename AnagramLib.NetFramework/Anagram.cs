using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace AnagramLib
{
    public class Anagram
    {
        private const string wordlistNameFileName = @"WordList_LengthSort_reverse.txt";
        private const string encoding = "ISO-8859-2";
        private const int smallWordlenght = 3;
        private List<string> resultStrings;
        private List<char> keys;

        public List<StringCharaterCount> WordList { get; set; }

        public Anagram()
        {
            InitializeWordList();
        }

        public List<string> OneWordAnagram(string anagramResult)
        {
            var result = new List<string>();

            var data = new StringCharaterCount(anagramResult);

            foreach (var word in WordList)
            {
                if (data.Lenght == word.Lenght)
                {
                    bool anagram = true;
                    foreach (var item in data.Data)
                        if (item.Value != word.Data[item.Key])
                        {
                            anagram = false;
                            break;
                        }

                    if (anagram)
                        result.Add(word.Original);
                }
            }

            return result;
        }

        public List<string> MultipleWordAnagram(string query)
        {
            resultStrings = new List<string>();

            var queryData = new StringCharaterCount(query.ToLower().Replace(" ", ""));
            keys = new List<char>(queryData.Data.Keys);

            FindStrings(queryData, "", new List<string>(),0,  int.MaxValue, 0);
            

            return resultStrings;
        }

        public List<string> MultipleWordAnagramWith(string query, string phrase, int smallWordCount)
        {
            resultStrings = new List<string>();

            var queryData = new StringCharaterCount(query.ToLower().Replace(" ", ""));
            var phraseData = new StringCharaterCount(phrase.ToLower().Replace(" ", ""));

            keys = new List<char>(queryData.Data.Keys);

            foreach (var key in keys)
            {
                queryData.Data[key] -= phraseData.Data[key];

                if (queryData.Data[key] < 0)
                    throw new ArgumentException("Phrase not contained in query");
            }
            queryData.Lenght -= phraseData.Lenght;

            FindStrings(queryData, phrase, new List<string>(), 0, smallWordCount, 0);


            return resultStrings;
        }

        private void FindStrings(StringCharaterCount queryData, string phrase, List<string> answer, int wordIndex, int MaxSmallWordCount, int CurrentSmallWordCount)
        {
            for (int i = wordIndex; i < WordList.Count; i++)
            {
                if (CurrentSmallWordCount == MaxSmallWordCount && WordList[i].Lenght <= smallWordlenght)
                    break;

                if (queryData.Lenght == WordList[i].Lenght)
                {
                    bool anagram = true;
                    foreach (var item in queryData.Data)
                        if (item.Value != WordList[i].Data[item.Key])
                        {
                            anagram = false;
                            break;
                        }

                    if (anagram)
                    {
                        var result = phrase + " ";
                        foreach (var answerPart in answer)
                            result += answerPart + " ";

                        result += WordList[i].Original;

                        resultStrings.Add(result);
                    }
                }
                else if (WordList[i].Lenght < queryData.Lenght)
                {
                    bool anagramPart = true;
                    foreach (var queryDataCharacter in queryData.Data)
                        if (queryDataCharacter.Value < WordList[i].Data[queryDataCharacter.Key])
                        {
                            anagramPart = false;
                            break;
                        }

                    if (anagramPart)
                    {
                        foreach (var key in keys)
                            queryData.Data[key] -= WordList[i].Data[key];

                        queryData.Lenght -= WordList[i].Lenght;

                        answer.Add(WordList[i].Original);

                        if (WordList[i].Lenght <= smallWordlenght)
                            FindStrings(queryData, phrase, answer, i + 1, MaxSmallWordCount, CurrentSmallWordCount + 1);
                        else
                            FindStrings(queryData, phrase, answer, i + 1, MaxSmallWordCount, CurrentSmallWordCount);

                        answer.Remove(WordList[i].Original);

                        foreach (var key in keys)
                            queryData.Data[key] += WordList[i].Data[key];

                        queryData.Lenght += WordList[i].Lenght;
                    }
                }
            }
        }

        private void InitializeWordList()
        {
            WordList = new List<StringCharaterCount>();
            

            const Int32 BufferSize = 128;
            using (var fileStream = File.OpenRead(wordlistNameFileName))
            using (var streamReader = new StreamReader(fileStream, Encoding.GetEncoding(encoding), true, BufferSize))
            {
                String line;
                while ((line = streamReader.ReadLine()) != null)
                    WordList.Add(new StringCharaterCount(line));
            }
        }
    }
}
