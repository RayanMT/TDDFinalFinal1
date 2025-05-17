﻿using System.Collections.Generic;
using FinalTDD;



namespace FinalTDD
{
    public static class SortHelper
    {
        public static List<Vehicle> BubbleSort(List<Vehicle> list)
        {
            return MergeSort(list);
        }

        private static List<Vehicle> MergeSort(List<Vehicle> list)
        {
            if (list.Count <= 1)
                return list;

            int mid = list.Count / 2;
            var left = MergeSort(list.GetRange(0, mid));
            var right = MergeSort(list.GetRange(mid, list.Count - mid));

            return Merge(left, right);
        }

        private static List<Vehicle> Merge(List<Vehicle> left, List<Vehicle> right)
        {
            List<Vehicle> result = new List<Vehicle>();
            int i = 0, j = 0;

            while (i < left.Count && j < right.Count)
            {
                if (left[i].Year >= right[j].Year) // Descending order
                {
                    result.Add(left[i]);
                    i++;
                }
                else
                {
                    result.Add(right[j]);
                    j++;
                }
            }

            while (i < left.Count)
                result.Add(left[i++]);
            while (j < right.Count)
                result.Add(right[j++]);

            return result;
        }
    }

}


// ==============================
// Old Version (Required by Prof)
// ==============================

/*
public static class SortHelper
{
    public static List<Vehicle> BubbleSort(List<Vehicle> list)
    {
        var sortedList = new List<Vehicle>(list);
        int n = sortedList.Count;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (sortedList[j].Year < sortedList[j + 1].Year)
                {
                    var temp = sortedList[j];
                    sortedList[j] = sortedList[j + 1];
                    sortedList[j + 1] = temp;
                }
            }
        }

        return sortedList;
    }
}
*/
