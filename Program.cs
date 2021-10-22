using System;
using FindTheSymmetricDifference;
using System.Collections.Generic;


int[] array1 = new int[] {0, 1, 2, 3}, array2 = { 2, 3, 4, 4, 4, 5}, array3 = { 4, 32, 4, 1, 7, 6, 5 , 58, 57}, array4 = { -3, 5, 4, 2, 12, 1, 2, 3 };
List<int[]> theListOfArrays = new() { array1, array2, array3, array4 };

int[] result = SymmetricDifference.SymmetricDifferenceMethod(theListOfArrays);
foreach (int item in result)
{
    Console.WriteLine(item);
}




