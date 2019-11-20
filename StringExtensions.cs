using System.Linq;


// We can declare namespace System since we are using namespace System in Program
// This is best for Extension methods


// ReSharper disable once CheckNamespace
namespace System
{
    public static class StringExtensions
    {
        public static string Shorten(this String str, int numberOfWords)
        {
            if (numberOfWords < 0)
                throw new ArgumentOutOfRangeException("numberOfWords of should be greater than or equal to 0");
            if (numberOfWords == 0)
                return "";
          

            var words = str.Split(' ');

            if (words.Length <= numberOfWords)
                return str;
            return string.Join(" ", words.Take(numberOfWords));
        }
    }
}