using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheSymmetricDifference
{
    class SymmetricDifference
    {
        public int[] SymmetricDifferenceMethod (List<int[]> inputList)
        {
            inputList = MakeArraysInListDistinct(inputList);
            List<int> longList = ConvertListOfArrayToList(inputList);
            int[] result = RemoveDuplicates(longList);
            return result;
        }
        public List<int[]> MakeArraysInListDistinct(List<int[]> inputList)
        {
            List<int[]> distinctList = new();
            for (int i = 0; i < inputList.Count; i++)
            {
                distinctList.Add(inputList[i].Select(x => x).Distinct().ToArray());
            }
            return distinctList;
        }
        public List<int> ConvertListOfArrayToList(List<int[]> inputList)
        {
            List<int> tempList = new();
            foreach (int[] item in inputList)
            {
                tempList.AddRange(item);
            }
            return tempList;
        }
        public int[] RemoveDuplicates(List<int> inputList)
        {
            inputList = inputList.GroupBy(x => x)
                .Where(g => g.Count() == 1)
                .Select(y => y.Key)
                .ToList();
            return inputList.ToArray();
        }
    }
}

//inputList.Select(x => x).Distinct()