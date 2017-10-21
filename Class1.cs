using System;

public class Sorter
{
    //List<int> numberList = new List<int>();
    public void Input()
    {
        List<int> numberList = new List<int>();
        while(numberList.Count<10)
        {
            numberList.Add() = Convert.ToInt32(Console.ReadLine());
        }
        numberList.ToArray();
        Console.WriteLine("You want the numbers to be arranged ASC or DSC");
        if ((Console.ReadLine().ToUpper) == "ASC")
            ASCsort(numberList);
        if ((Console.ReadLine().ToUpper) == "DSC")
            DSCsort(numberList);



    }

    public void ASCsort(params int[] array) 
    {
        for (int i = 0; i < array.length; i++)
        {
            for (int j = 0; j < array.length - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    swap(array[j], array[j + 1]);

                }
            }
        }

        Display(array);
    }

    public void DSCsort(params int[] array)
    {
        for (int i = 0; i < array.length; i++)
        {
            for (int j = 0; j < array.length - 1; j++)
            {
                if (array[j] < array[j + 1])
                {
                    swap(array[j], array[j + 1]);
                }
            }
        }
        Display(array);
    }
    public void swap(int A,int B)
    {
        A = A + B;
        B = A - B;
        A = A - B;

    }
    public void Display(params int[] array)
    {
        Console.WriteLine("\n Sorted List \n");

        for (int i = 0; i < array.length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }

}
