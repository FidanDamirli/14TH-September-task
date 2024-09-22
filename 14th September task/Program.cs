using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int Square = Squared(5);
        Console.WriteLine(Square);

        int[] numbers = { 2, 4, 5 };
        int[] squaredNumbers = ArraySquare(numbers);
        foreach (int number in squaredNumbers)
        {
            Console.WriteLine(number);
        }

        string sentence = "Hikmet  Abbasov";

        SentenceWithoutSpaces(ref sentence);
        Console.WriteLine(sentence);

        int[] numberss = { 1, 5, 7 };

        AddNewNum(ref numberss, 3);
        for (int i = 0; i < numberss.Length; i++)
        {
            Console.WriteLine(numberss[i]);
        }
    }

    #region Task 1
    static int Squared(int a)
    {
        return a * a;
    }
    #endregion

    #region Task 2
    static int[] ArraySquare(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = array[i] * array[i];
        }
        return array;
    }
    #endregion

    #region Task 3

    static void SentenceWithoutSpaces(ref string words)
    {
        string newWord = "";
        for (int i = 0; i < words.Length; i++)
        {

            if (words[i]!= ' ')
            {
                newWord += words[i];

            }


        }

        words = newWord;
    }

    #endregion

    #region Task 4

    static void AddNewNum(ref int[]numbers, int num)
    {
        int[]newNumbers=new int[numbers.Length+1];
        for (int i = 0; i < numbers.Length; i++)
        {
            newNumbers[i] = numbers[i];

        }
        newNumbers[numbers.Length] = num;
        numbers = newNumbers;
    }

    #endregion


}

