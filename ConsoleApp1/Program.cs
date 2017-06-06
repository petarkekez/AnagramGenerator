using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] lines = System.IO.File.ReadAllLines(@"WordList.txt", Encoding.GetEncoding("ISO-8859-2"));

            //Array.Sort(lines, (x, y) => x.Length.CompareTo(y.Length));
            //using (System.IO.StreamWriter file =
            //new System.IO.StreamWriter(@"WordList_LengthSort.txt", false, Encoding.GetEncoding("ISO-8859-2")))
            //{
            //    foreach (string line in lines)
            //    {
            //        file.WriteLine(line);
            //    }
            //}

            var rezultati = new List<string>{
                ""
            };

            var options = new ParallelOptions();
            options.MaxDegreeOfParallelism = 3;
            Parallel.ForEach(rezultati, options, (item) =>
                    {
                        var watch = System.Diagnostics.Stopwatch.StartNew();

                        var anagram = new AnagramLib.Anagram();

                        int smallWordCount = item.Length > 12 ? 0 : 1;

                        var result = anagram.MultipleWordAnagramWith(item, "", smallWordCount);

                        watch.Stop();
                        //var elapsedMs = watch.Elapsed.;

                        using (System.IO.StreamWriter file =
                        new System.IO.StreamWriter(item + ".txt", false, Encoding.Unicode))
                        {
                            file.WriteLine("Duration(days hours:minutes:seconds) "
                                + watch.Elapsed.Days + " "
                                + watch.Elapsed.Hours + ":"
                                + watch.Elapsed.Minutes + ":"
                                + watch.Elapsed.Seconds);

                            foreach (string line in result)
                            {
                                file.WriteLine(line);
                            }
                        }
                    }
                );

            //var anagram = new AnagramLib.Anagram();

            //var result = anagram.MultipleWordAnagramWith("ante caktaš", "", 1);

            //Debugger.Break();
        }
    }
}
