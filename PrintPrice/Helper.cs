using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintPrice
{
    internal class Helper
    {
        /// <summary>
        /// сокращает, переданное слово до двух символов слева и добавляет точку. 
        /// Если второй символ гласная буква, то до трех символов, если третий символ гласная буква, 
        /// то до 4 и т.д.
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public string ShortWord(string word)
        {
            return word;
        }
        /// <summary>
        /// Функция получает из строки бренд. 
        /// Бренд - это слово или слова на английском языке 
        /// (удалить все символы, кроме английских букв)
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public string GetBrend(string word)
        {
            return word;
        }
        /// <summary>
        /// В исходной строке находит бренд и оборачивает его в кавычки, 
        /// брендом считать те символы, 
        /// которые написаны большими буквами (более двух букв подряд)

        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public string BrendWord(string word)
        {
            return word;
        }
        /// <summary>
        /// Для исходной строки после каждой точки с запятой вставить Enter
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public string InsertEnter(string word)
        {
            return word;
        }
        /// <summary>
        /// Функция удаляет в исходной строке дублирующиеся слова
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public string DeleteDuplicate(string word)
        {
            return word;
        }
        /// <summary>
        /// Функция  разделяет число на триады

        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public string SplitTriads(string word)
        {
            return word;
        }
        /// <summary>
        /// Функция удаляет из строки все предлоги, 
        /// остальные слова сокращает до одной буквы (первой) 
        /// и повышает ее в верхний регистр
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public string GetOrganizationalForm(string word)
        {
            return word;
        }

    }
}
