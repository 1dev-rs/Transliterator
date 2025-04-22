using System.Collections.Generic;
using System.Text;

namespace AspNet.Transliterator
{
    public class Transliteration
    {
        #region Static members

        /// <summary>
        /// Cyrillic to latin mapping
        /// </summary>
        static readonly Dictionary<char, string> CyrLatMapping = new()
        {
            { 'А', "A" }, { 'Б', "B" }, { 'В', "V" }, { 'Г', "G" }, { 'Д', "D" }, { 'Ђ', "Đ" },
            { 'Е', "E" }, { 'Ж', "Ž" }, { 'З', "Z" }, { 'И', "I" }, { 'Ј', "J" }, { 'К', "K" },
            { 'Л', "L" }, { 'Љ', "LJ" }, { 'М', "M" }, { 'Н', "N" }, { 'Њ', "NJ" }, { 'О', "O" },
            { 'П', "P" }, { 'Р', "R" }, { 'С', "S" }, { 'Т', "T" }, { 'Ћ', "Ć" }, { 'У', "U" },
            { 'Ф', "F" }, { 'Х', "H" }, { 'Ц', "C" }, { 'Ч', "Č" }, { 'Џ', "DŽ" }, { 'Ш', "Š" },
            { 'а', "a" }, { 'б', "b" }, { 'в', "v" }, { 'г', "g" }, { 'д', "d" }, { 'ђ', "đ" },
            { 'е', "e" }, { 'ж', "ž" }, { 'з', "z" }, { 'и', "i" }, { 'ј', "j" }, { 'к', "k" },
            { 'л', "l" }, { 'љ', "lj" }, { 'м', "m" }, { 'н', "n" }, { 'њ', "nj" }, { 'о', "o" },
            { 'п', "p" }, { 'р', "r" }, { 'с', "s" }, { 'т', "t" }, { 'ћ', "ć" }, { 'у', "u" },
            { 'ф', "f" }, { 'х', "h" }, { 'ц', "c" }, { 'ч', "č" }, { 'џ', "dž" }, { 'ш', "š" }
        };

        /// <summary>
        /// To bold latin mapping
        /// </summary>
        static readonly Dictionary<char, string> ToBoldLatinMapping = new()
        {
            { 'А', "A" }, { 'Б', "B" }, { 'В', "V" }, { 'Г', "G" }, { 'Д', "D" }, { 'Ђ', "DJ" },
            { 'Е', "E" }, { 'Ж', "Z" }, { 'З', "Z" }, { 'И', "I" }, { 'Ј', "J" }, { 'К', "K" },
            { 'Л', "L" }, { 'Љ', "LJ" }, { 'М', "M" }, { 'Н', "N" }, { 'Њ', "NJ" }, { 'О', "O" },
            { 'П', "P" }, { 'Р', "R" }, { 'С', "S" }, { 'Т', "T" }, { 'Ћ', "C" }, { 'У', "U" },
            { 'Ф', "F" }, { 'Х', "H" }, { 'Ц', "C" }, { 'Ч', "C" }, { 'Џ', "DZ" }, { 'Ш', "S" },
            { 'а', "a" }, { 'б', "b" }, { 'в', "v" }, { 'г', "g" }, { 'д', "d" }, { 'ђ', "dj" },
            { 'е', "e" }, { 'ж', "z" }, { 'з', "z" }, { 'и', "i" }, { 'ј', "j" }, { 'к', "k" },
            { 'л', "l" }, { 'љ', "lj" }, { 'м', "m" }, { 'н', "n" }, { 'њ', "nj" }, { 'о', "o" },
            { 'п', "p" }, { 'р', "r" }, { 'с', "s" }, { 'т', "t" }, { 'ћ', "c" }, { 'у', "u" },
            { 'ф', "f" }, { 'х', "h" }, { 'ц', "c" }, { 'ч', "c" }, { 'џ', "dz" }, { 'ш', "s" },
            { 'Ć', "C" }, { 'Č', "C" }, { 'Ž', "Z" }, { 'Š', "S" }, { 'Đ', "DJ" },
            { 'ć', "c" }, { 'č', "c" }, { 'ž', "z" }, { 'š', "s" }, { 'đ', "dj" },
        };

        /// <summary>
        /// Cyrillic to latin mapping
        /// </summary>

        static readonly Dictionary<string, string> LatCyrCompositeMapping = new()
        {
            { "LJ", "Љ" },
            { "NJ", "Њ" },
            { "DŽ", "Џ"},
            { "DJ", "Ђ"},
            { "lj", "љ" },
            { "nj", "њ" },
            { "dž", "џ" },
            { "dj", "ђ" },

            { "lJ", "љ" },
            { "Lj", "Љ" },
            { "nJ", "њ" },
            { "Nj", "Њ" },
            { "dŽ", "џ" },
            { "Dž", "Џ" },
            { "dJ", "ђ" },
            { "Dj", "Ђ" }
        };

        static readonly Dictionary<char, char> LatCyrMapping = new()
        {
            { 'A', 'А' }, { 'B', 'Б' }, { 'V', 'В' }, { 'G', 'Г' }, { 'D', 'Д' }, { 'Đ', 'Ђ' },
            { 'E', 'Е' }, { 'Ž', 'Ж' }, { 'Z', 'З' }, { 'I', 'И' }, { 'J', 'Ј' }, { 'K', 'К' },
            { 'L', 'Л' }, { 'M', 'М' }, { 'N', 'Н' }, { 'O', 'О' }, { 'P', 'П' }, { 'R', 'Р' },
            { 'S', 'С' }, { 'T', 'Т' }, { 'Ć', 'Ћ' }, { 'U', 'У' }, { 'F', 'Ф' }, { 'H', 'Х' },
            { 'C', 'Ц' }, { 'Č', 'Ч' }, { 'Š', 'Ш' }, { 'a', 'а' }, { 'b', 'б' }, { 'v', 'в' },
            { 'g', 'г' }, { 'd', 'д' }, { 'đ', 'ђ' }, { 'e', 'е' }, { 'ž', 'ж' }, { 'z', 'з' },
            { 'i', 'и' }, { 'j', 'ј' }, { 'k', 'к' }, { 'l', 'л' }, { 'm', 'м' }, { 'n', 'н' },
            { 'o', 'о' }, { 'p', 'п' }, { 'r', 'р' }, { 's', 'с' }, { 't', 'т' }, { 'ć', 'ћ' },
            { 'u', 'у' }, { 'f', 'ф' }, { 'h', 'х' }, { 'c', 'ц' }, { 'č', 'ч' }, { 'š', 'ш' }
        };

        #endregion

        #region Public methods

        public static string CyrlToLatin(string word)
        {
            if (string.IsNullOrEmpty(word?.Trim())) { return null; }

            var builder = new StringBuilder();

            foreach (var character in word)
            {
                if (CyrLatMapping.TryGetValue(character, out string value))
                {
                    builder.Append(value);
                    continue;
                }

                builder.Append(character);
            }

            return builder.ToString();
        }

        public static string LatinToCyrl(string word)
        {
            if (string.IsNullOrEmpty(word?.Trim())) { return null; }

            var transliterated = word;

            foreach (var character in LatCyrCompositeMapping.Keys)
            {
                if(word.Contains(character))
                {
                    transliterated = transliterated.Replace(character, LatCyrCompositeMapping[character]);
                }
            }

            var builder = new StringBuilder();

            foreach (var character in transliterated)
            {
                if (LatCyrMapping.TryGetValue(character, out char value))
                {
                    builder.Append(value);
                    continue;
                }

                builder.Append(character);
            }

            return builder.ToString();
        }

        public static string ToBoldLatin(string word)
        {
            if (string.IsNullOrEmpty(word?.Trim())) { return null; }

            var builder = new StringBuilder();

            foreach (var character in word)
            {
                if (ToBoldLatinMapping.TryGetValue(character, out string value))
                {
                    builder.Append(value);
                    continue;
                }

                builder.Append(character);
            }

            return builder.ToString();
        }

        public static string ToLowerBoldLatin(string word)
        {
            return ToBoldLatin(word)?.ToLowerInvariant();
        }

        public static string ToUpperBoldLatin(string word)
        {
            return ToBoldLatin(word)?.ToUpperInvariant();
        }

        #endregion
    }
}
