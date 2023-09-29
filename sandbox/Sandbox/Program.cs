using System.Collections.Generic;

class Program
{

    static void Main(string[] args)

    {
        string[] wordsToHide = { "apple", "banana", "cherry", "date", "grape", "kiwi", "mango", "orange", "pear", "strawberry" };

        while (true)
        {
            Console.Clear();
            string sentence = "I like to eat apple, banana, cherry, and strawberry.";

            // Randomly select words to hide
            Random random = new Random();
            int numberOfWordsToHide = random.Next(1, 4); // Randomly choose 1 to 3 words to hide

            for (int i = 0; i < numberOfWordsToHide; i++)
            {
                int wordIndex = random.Next(wordsToHide.Length);
                string wordToHide = wordsToHide[wordIndex];
                sentence = sentence.Replace(wordToHide, new string('*', wordToHide.Length));
            }

            Console.WriteLine(sentence);
            Thread.Sleep(2000); // Wait for 2 seconds before clearing the console again
        }
    }


    
}