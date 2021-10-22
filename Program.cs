using System;
using FindTheSymmetricDifference;
using System.Collections.Generic;

int[] array1 = new int[] {0, 1, 2, 3};
int[] array2 = new int[] { 2, 3, 4, 4, 4, 5};
int[] array3 = new int[] { 4, 32, 4, 1, 7, 6, 5 , 58};
int[] array4 = new int[] { -3, 5, 4, 2, 12, 1, 2, 3 };
int[] array5 = new int[] { 5, 4, -6, 3, 7, 6, 3, 2, 1 , 433, 57};
SymmetricDifference sym = new();
List<int[]> theListOfArrays = new();
theListOfArrays.Add(array1);
theListOfArrays.Add(array2);
theListOfArrays.Add(array3);
theListOfArrays.Add(array4);
theListOfArrays.Add(array5);

int[] result = sym.SymmetricDifferenceMethod(theListOfArrays);
foreach (int item in result)
{
    Console.WriteLine(item);
}




