namespace Assignment_7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] scores = { 85, 72, 93, 68, 88 };

            SortScores(scores);

            Console.WriteLine("Sorted scores:");

            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }

            string word1 = "abc";
            string word2 = "pqr";

            string result = AlternatingWords(word1, word2);

            Console.WriteLine(result);

        }

        static int[] SortScores(int[] scores)
        {
            int temp;
            int minIndex;
            for (int i = 0; i < scores.Length-1; i++)
            {
                minIndex = i;
                temp = scores[i];

                for(int j =i+1; j< scores.Length; j++)
                {
                    if (scores[j] < scores[minIndex])
                    {

                        minIndex = j;
                    }
                }
                scores[i] = scores[minIndex];
                scores[minIndex] = temp;

            }
            return scores;
        }

        static string AlternatingWords(string word1, string word2)
        {
            string result = "";
            int longerLength;

            if(word1.Length >= word2.Length)
            {
                longerLength = word1.Length;
            }
            else
            {
                longerLength = word2.Length;
            }

            for (int i = 0; i < longerLength; i++)
            {
                if (i < word1.Length)
                {
                    result += word1[i];
                }

                if (i < word2.Length)
                {
                    result += word2[i];
                }
            }

            return result;
        }
    }
}
