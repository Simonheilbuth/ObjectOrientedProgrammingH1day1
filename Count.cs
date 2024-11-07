namespace ObjectOrientedProgrammingH1day1
{

    public class WordCounter
    {
        // Modified method to count both singular and plural forms
        public (int singular, int plural) CountWordAndPlural(string text, string wordToCount)
        {
            // Split the text into words and convert to lowercase for case-insensitive comparison
            string[] words = text.ToLower().Split(new[] { ' ', '.', ',', ':', ';', '(', ')', '\n', '\r', '\t' },
                StringSplitOptions.RemoveEmptyEntries);

            // Convert search words to lowercase
            string singular = wordToCount.ToLower();
            string plural = wordToCount + "s";

            int singularCount = 0;
            int pluralCount = 0;

            foreach (string word in words)
            {
                if (word == singular)
                    singularCount++;
                else if (word == plural)
                    pluralCount++;
            }

            return (singularCount, pluralCount);
        }
    }
}