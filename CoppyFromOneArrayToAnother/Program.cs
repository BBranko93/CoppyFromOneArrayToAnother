using System;

namespace CoppyFromOneArrayToAnother
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5];
            int i;
            int[] arr2 = new int[5];
            //Input elements into the array
            Console.Write("Input 5 elements in the array : \n");
            for (i = 0; i < 5; i++)
            {
                Console.Write("Element - {0} :", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            //Display elements of the first array
            //and copy from first array to second array
            Console.Write("\nElements in array are : ");
            for (i = 0; i < 5; i++)
            {
                Console.Write("{0} ", arr1[i]);

                arr2[i] = arr1[i];
            }
            //Display second array
            Console.Write("\nElements in second array are : ");
            for (i = 0; i < 5; i++)
            {
                Console.Write("{0} ", arr2[i]);
            } 
            Console.Write("\n");

        }
    }
}
