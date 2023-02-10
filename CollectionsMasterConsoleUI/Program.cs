using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            int[] arr = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(arr);
            

            //TODO: Print the first number of the array
            Console.WriteLine($"first: {arr[0]}");
            //TODO: Print the last number of the array            
            Console.WriteLine($" last: {arr[49]}");
            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(arr);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */
            Array.Reverse(arr);
            Console.WriteLine("All Numbers Reversed:");
            NumberPrinter(arr);
            Console.WriteLine("---------REVERSE CUSTOM------------");
            
            NumberPrinter(ReverseArray(arr));

            
            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(arr);
            NumberPrinter(arr);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(arr);
            NumberPrinter(arr);
            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            var listInt = new List<int>();

            //TODO: Print the capacity of the list to the console
            Console.WriteLine(listInt.Capacity);

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(listInt);

            //TODO: Print the new capacity
            Console.WriteLine(listInt.Capacity);

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            var inList = NumberChecker(listInt);
            Console.WriteLine(inList);
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(listInt); 
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            listInt = OddKiller(listInt);
            NumberPrinter(listInt);
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            listInt.Sort();
            NumberPrinter(listInt);
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            var arrFromList = listInt.ToArray();

            //TODO: Clear the list
            listInt.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = (numbers[i] % 3 == 0) ? 0 : numbers[i];
            }
        }

        private static List<int> OddKiller(List<int> numberList)
        {
            var listNew = new List<int>();
            for (int i = 0; i < numberList.Count; i++)
            {
                if (numberList[i] % 2 == 0)
                { listNew.Add(numberList[i]); }
            }
            return listNew;
        }

        private static bool NumberChecker(List<int> numberList)
        {
            Console.WriteLine("What number are you looking for?");
            var userIn = Console.ReadLine();
            if (int.TryParse(userIn, out int val) || numberList.Contains(val))
            {
                return true;
            }
            return false;
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for (int i = 0; i < 50; i++)
            {
                numberList.Add(rng.Next(0, 50));
            }
        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(0, 50);
            }
        }        

        private static int[] ReverseArray(int[] array)
        {
            int i = 0;
            int j = array.Length - 1;
            while (i < j)
            {
                int placeHolder = array[i];
                array[i] = array[j];
                array[j] = placeHolder;
                i++;
                j--;
            }
            return array;
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
