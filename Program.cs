
using System;

//question1
class Program
{
    static int SumOfDigits(int number)
    {
        number = Math.Abs(number); 
        int sum = 0;

        for (; number > 0; number /= 10) 
        {
            sum += number % 10; 
        }

        return sum;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Sum of digits: " + SumOfDigits(number));
    }
}

//question2
class Program
{
    static void Main()
    {
        int number;

        while (true) 
        {
            Console.Write("Enter a number between 10 and 100: ");
            number = int.Parse(Console.ReadLine());

            if (number >= 10 && number <= 100)
            {
                Console.WriteLine("Valid number entered: " + number);
                break;
            }
            else
            {
                Console.WriteLine("Invalid number! Please enter a number between 10 and 100.");
            }
        }
    }
}
//question3 
class Program
{
    static void Main()
    {
        int[] ages = { 5, 16, 25, 45, 70 }; 

        foreach (int age in ages)
        {
            string category = GetAgeCategory(age);
            Console.WriteLine($"Age {age}: {category}");
        }
    }

    static string GetAgeCategory(int age)
    {
        if (age >= 0 && age <= 12)
            return "Child";
        else if (age >= 13 && age <= 19)
            return "Teen";
        else if (age >= 20 && age <= 64)
            return "Adult";
        else
            return "Senior";
    }
}
//question4
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] numbers = { 4, 2, 7, 4, 8, 2, 9, 7, 1, 4 }; 

        FindDuplicates(numbers);
    }

    static void FindDuplicates(int[] array)
    {
        HashSet<int> seen = new HashSet<int>();  
        HashSet<int> duplicates = new HashSet<int>();

        foreach (int num in array)
        {
            if (!seen.Add(num))
            {
                duplicates.Add(num);
            }
        }

        Console.WriteLine("Duplicate elements: " + string.Join(", ", duplicates));
    }
}

//question5

class Program
{
    static void Main()
    {
        string[] words = { "apple", "banana", "kiwi", "grape", "strawberry", "fig" }; 

        FindLongestAndShortest(words);
    }

    static void FindLongestAndShortest(string[] array)
    {
        if (array.Length == 0)
        {
            Console.WriteLine("The array is empty.");
            return;
        }

        string shortest = array[0];
        string longest = array[0];

        foreach (string word in array)
        {
            if (word.Length < shortest.Length)
                shortest = word;

            if (word.Length > longest.Length)
                longest = word;
        }

        Console.WriteLine($"Shortest word: {shortest}");
        Console.WriteLine($"Longest word: {longest}");
    }
}
//question6
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        string[] words = sentence.Split(' ');
        Array.Sort(words, StringComparer.OrdinalIgnoreCase); 

        Console.WriteLine("Sorted words: " + string.Join(", ", words));
    }
}
//question7
using System;

class Program
{
    static void Main()
    {
        string[] words = new string[0]; 
        string input;

        while (true)
        {
            Console.Write("Enter a word (or type 'exit' to stop): ");
            input = Console.ReadLine();

            if (input.ToLower() == "exit")
                break;

            words = ExpandArray(words, input);
        }

        Console.WriteLine("Final array: " + string.Join(", ", words));
    }

    static string[] ExpandArray(string[] oldArray, string newWord)
    {
        string[] newArray = new string[oldArray.Length + 1]; 
        Array.Copy(oldArray, newArray, oldArray.Length);
        newArray[newArray.Length - 1] = newWord;
        return newArray;
    }
}
//question8
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> words = new List<string>(); 
        string input;

        while (true)
        {
            Console.Write("Enter a word (or type 'exit' to stop): ");
            input = Console.ReadLine();

            if (input.ToLower() == "exit")
                break;

            words.Add(input); 
        }

        words.Reverse(); 

        Console.WriteLine("Words in reverse order: " + string.Join(", ", words));
    }
}
//question9
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>(); 
        string input;

        while (true)
        {
            Console.Write("Enter a number (or type 'exit' to stop): ");
            input = Console.ReadLine();

            if (input.ToLower() == "exit")
                break;

            if (int.TryParse(input, out int number)) 
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }
        }

        if (numbers.Count > 0)
        {
            double average = numbers.Average(); 
            numbers.Sort(); 

            Console.WriteLine("Numbers in ascending order: " + string.Join(", ", numbers));
            Console.WriteLine("Average of numbers: " + average);
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}
//question10
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 5, 15, 8, 20, 3, 12 };
        numbers.RemoveAll(x => x < 10);

        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}
//question11
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> grades = new List<int> { 45, 60, 30, 70, 50, 40 };

        for (int i = 0; i < grades.Count; i++)
        {
            if (grades[i] < 50)
            {
                grades[i] = 50;
            }
        }

        foreach (var grade in grades)
        {
            Console.WriteLine(grade);
        }
    }
}

