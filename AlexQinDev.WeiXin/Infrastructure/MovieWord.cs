using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AlexQinDev.WeiXin.Infrastructure
{
    public class MovieWord
    {
        private static MovieWord _movieWord = new MovieWord();
        private List<string> _words = new List<string>();

        private MovieWord()
        {

        }

        private void ReadText()
        {
            string filePath = AppDomain.CurrentDomain.BaseDirectory + @"\App_Data\MoiveWords.txt";
            string[] arr = File.ReadAllLines(filePath, System.Text.Encoding.UTF8);
            _words = arr.ToList();
            _words = _words.Where(w => !string.IsNullOrEmpty(w.Trim())).ToList();
        }

        public static MovieWord GetInstance()
        {
            return _movieWord;
        }

        public List<string> GetMovieWords()
        {
            if (_words.Count == 0)
            {
                ReadText();
            }

            return _words;
        }

        public string GetRandomMovieWord()
        {
            if (_words.Count == 0)
            {
                ReadText();
            }

            string result = string.Empty;
            Random r = new Random();
            int randomIndex = r.Next(_words.Count - 1);
            result = _words[randomIndex];

            return result;
        }
    }
}
