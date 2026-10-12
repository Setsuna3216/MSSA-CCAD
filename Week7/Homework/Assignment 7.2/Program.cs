namespace Assignment_7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = { 8, 3, 5, 1, 9, 2 };
            Console.WriteLine("Q1:");
            int[] numbers = CreateNumbers();

            Console.WriteLine("Before sorting:");
            Console.WriteLine(string.Join(", ", numbers));

            int[] sortedNumbers = MergeSort(numbers);

            Console.WriteLine("After sorting:");
            Console.WriteLine(string.Join(", ", sortedNumbers));

            Console.WriteLine("Q2:");
            
            string[] testCases =
            {
                "hello",
                "avacado",
                "intelligent",
                "bcdfg",
                "AEIOU",
                "a",
                ""
            };

            foreach (string test in testCases)
            {
                char[] result = ReverseVowels(test);

                Console.WriteLine($"Input:  {test}");
                Console.WriteLine($"Output: {new string(result)}");
                Console.WriteLine();
            }

            Console.WriteLine("Q3:");
            Console.WriteLine(IsAnagram("anagram", "nagaram")); // True
            Console.WriteLine(IsAnagram("rat", "car"));         // False
            Console.WriteLine(IsAnagram("listen", "silent"));   // True
            Console.WriteLine(IsAnagram("aab", "abb"));         // False
            Console.WriteLine(IsAnagram("abc", "abcd"));        // False
            Console.WriteLine(IsAnagram("", ""));              // True
            Console.WriteLine(IsAnagram("abc", "abc"));         // True

        }

        static int[] CreateNumbers()
        {
            Console.WriteLine("Enter numbers");
            string numbersEntered = Console.ReadLine();
            string[] numbersSplited = numbersEntered.Split(' ');
            int[] numbers = new int[numbersSplited.Length];
            for (int i = 0; i < numbersSplited.Length; i++) {
                numbers[i] = int.Parse(numbersSplited[i]);
            }
            return numbers;
        }

        static int[] MergeSort(int[] numbers)
        {
            if (numbers.Length <= 1)
            {
                return numbers;
            }
            int[] numbersLeft = new int[numbers.Length / 2];
            int[] numbersRight = new int[numbers.Length - numbersLeft.Length];

            for (int n = 0; n < numbersLeft.Length; n++)
            {
                numbersLeft[n] = numbers[n];
            }

            numbersLeft = MergeSort(numbersLeft);
            for (int n = 0; n < numbersRight.Length; n++)
            {
                numbersRight[n] = numbers[numbersLeft.Length + n];
            }
            numbersRight = MergeSort(numbersRight);

            int[] merged = new int[numbersLeft.Length+ numbersRight.Length];
            int i = 0;
            int j = 0;
            int k = 0;

            while (i < numbersLeft.Length && j< numbersRight.Length) 
            {
                if (numbersLeft[i] < numbersRight[j])
                {
                    merged[k] = numbersLeft[i];
                    i++;
                }
                else
                {
                    merged[k] = numbersRight[j];
                    j++;
                }
                k++;
            }
            while (i < numbersLeft.Length)
            {
                merged[k] = numbersLeft[i];
                i++;
                k++;
            }
            while (j < numbersRight.Length)
            {
                merged[k] = numbersRight[j];
                j++;
                k++;
            }
            return merged;
        }

        static char[] ReverseVowels(string s)
        {
            char[] letters = s.ToCharArray();

            int left = 0;
            int right = letters.Length - 1;
            char temp;
            

            while (left < right) 
            {
                while(left < right && !"aeiou".Contains(char.ToLower(letters[left])))
                {
                    left++;
                }

                while(left < right && !"aeiou".Contains(char.ToLower(letters[right])))
                {
                    right--;
                }
                if (left < right)
                {
                    temp = letters[left];
                    letters[left] = letters[right];
                    letters[right] = temp;
                    left++;
                    right--;
                }
                    
            }

            return letters;

        }

        static bool IsAnagram(string s, string t)
        {
            if(s.Length != t.Length)
            {
                return false;
            }
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            
            foreach(char c in s)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount.Add(c,1);
                }
            }

            foreach (char c in t)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]--;
                    if(charCount[c] < 0)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            return true;
            
        }


    }
}
