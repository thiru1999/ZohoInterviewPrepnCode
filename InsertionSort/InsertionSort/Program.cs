// C# program for implementation of Insertion Sort
using System;

class InsertionSort
{
	public InsertionSort(int a)
    {
		Console.Write(a);
    }

	// Function to sort array
	// using insertion sort
	void sort(int[] arr)   //Algorithm will check curretn elemnt with all the previous element
	{
		int n = arr.Length;
		for(int i = 1; i < n; i++) //i starts from 1 bcz it comparing Previous element and swapping 
        {
			int Key = arr[i];
			int j = i - 1;
			while(j>=0 && arr[j] > Key)  //Checking the previous elemtn is smaller than the current element else swap
            {
				arr[j + 1] = arr[j];
				j = j - 1;
            }
			arr[j + 1] = Key;

        }

	}

	// A utility function to print
	// array of size n
	static void printArray(int[] arr)
	{
		int n = arr.Length;
		for (int i = 0; i < n; ++i)
			Console.Write(arr[i] + " ");

		Console.Write("\n");
	}

	// Driver Code
	public static void Main()
	{
		int[] arr = { 12, 11, 13, 5, 6 };
		InsertionSort ob = new InsertionSort(65655);
		ob.sort(arr);
		printArray(arr);
	}
}


