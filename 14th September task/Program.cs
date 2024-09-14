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
}

