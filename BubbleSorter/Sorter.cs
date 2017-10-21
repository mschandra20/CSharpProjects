using System;
using System.Collections.Generic;

namespace BSorter
{
    //interface ISorter
    //{
    //     void Input();
    //     void Display(params int[] NameOfTheArray);
    //}

     class Sorter/*:ISorter*/
    {
        
        //List<int> numberList = new List<int>();
        public  void Input()
        {
            Console.WriteLine("Enter Numbers");
            List<int> numberList = new List<int>();
            do
            {
                numberList.Add(Convert.ToInt32(Console.ReadLine()));
            } while (!numberList.Contains(Convert.ToInt32("")));

                int[] array=numberList.ToArray();

            Console.WriteLine("You want the numbers to be arranged ASC or DSC");
            string choice = Console.ReadLine().ToUpper();
            if ( choice== "ASC")
                ASCsort(array);
            if (choice == "DSC")
                DSCsort(array);
        }

        private void ASCsort(params int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        swap(array[j], array[j + 1],out array[j],out array[j+1]);

                    }
                }
            }

            Display(array);
        }

        private void DSCsort(params int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        swap(array[j], array[j + 1], out array[j], out array[j + 1]);
                    }
                }
            }
             
            Display(array);
        }
        void swap(int A, int B,out int X, out int Y )
        {
            A = A + B;
            B = A - B;
            A = A - B;
            X=A;Y = B;

        }
        public  void Display(params int[] array)
        {
            Console.WriteLine("\n Sorted List \n");

            for (int i = 0; i < array.Length; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(array[i]);
            }
        }

    }
}
