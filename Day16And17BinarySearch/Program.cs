using System;

namespace Day16And17BinarySearch
{
	// C# program to implement Binary Search for strings
	class GFG
	{

		// Returns index of x if it is present in arr[],
		// else return -1
		static int binarySearch(String[] arr, String x)
		{
			int l = 0, r = arr.Length - 1;
			while (l <= r)
			{
				int m = l + (r - l) / 2;

				int res = x.CompareTo(arr[m]);

				// Check if x is present at mid
				if (res == 0)
					return m;

				// If x greater, ignore left half
				if (res > 0)
					l = m + 1;

				// If x is smaller, ignore right half
				else
					r = m - 1;
			}

			return -1;
		}

		// Driver method to test above
		public static void Main(String[] args)
		{
			String[] arr = new string[4];
			for(int i=0;i<=3;i++)
            {
				Console.WriteLine("Enter string "+i);
				arr[i] = Console.ReadLine();
			}
			Console.WriteLine("-------------------");
			Console.WriteLine("All Strings");
			for(int i=0;i<=3;i++)
            {
				Console.WriteLine(arr[i]);
            }
			Console.WriteLine("-------------------");
			Console.WriteLine("Enter string to search");
			String x = Console.ReadLine();
			//String[] arr = { "contribute", "geeks", "ide", "practice" };
			//String x = "ide";
			int result = binarySearch(arr, x);

			if (result == -1)
				Console.WriteLine("Element not present");
			else
				Console.WriteLine("Element found at "
								+ "index " + result);
		}
		// This code is contributed by Ryuga
	}
}