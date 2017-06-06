using System;
using System.Collections.Generic;
using System.Text;

namespace AnagramLib
{
    public class StringCharaterCount
    {
        public Dictionary<char, int> Data;

        public StringCharaterCount()
        {
            InitialData();
        }

        public StringCharaterCount(string data)
        {
            InitialData();

            var dataToLower = data.ToLower();
            for (int i = 0; i < dataToLower.Length; i++)
                if (Char.IsLetter(dataToLower[i]))
                    Data[dataToLower[i]]++;
        }


        private void InitialData()
        {
            Data = new Dictionary<char, int>();
            Data.Add('a', 0);
            Data.Add('b', 0);
            Data.Add('c', 0);
            Data.Add('č', 0);
            Data.Add('ć', 0);
            Data.Add('d', 0);
            Data.Add('đ', 0);
            Data.Add('e', 0);
            Data.Add('f', 0);
            Data.Add('g', 0);
            Data.Add('h', 0);
            Data.Add('i', 0);
            Data.Add('j', 0);
            Data.Add('k', 0);
            Data.Add('l', 0);
            Data.Add('m', 0);
            Data.Add('n', 0);
            Data.Add('o', 0);
            Data.Add('p', 0);
            Data.Add('r', 0);
            Data.Add('s', 0);
            Data.Add('š', 0);
            Data.Add('t', 0);
            Data.Add('u', 0);
            Data.Add('v', 0);
            Data.Add('z', 0);
            Data.Add('ž', 0);
            Data.Add('q', 0);
        }

        

    }
}
