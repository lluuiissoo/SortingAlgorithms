using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mergesort.sorting
{
    public class MergeSort
    {
        // Note: Debug information was added to visualize how the recursive method is called in the call stack.
        // To see, select Debug from the output console and run the tests in debug mode.

        public List<int> Sort(List<int> list)
        {
            Debug.WriteLine("Sort");
            Debug.WriteLine(GetListAsString(list));

            // If list count is 0 or 1 the list is considered sorted and should be returned.
            if (list.Count <= 1)
                return list;

            // Divide the list into two sublists.
            List<int> left = new List<int>();
            List<int> right = new List<int>();
            int middleIndex = (list.Count) / 2;
            left = list.GetRange(0, middleIndex);
            right = list.GetRange(middleIndex, list.Count - middleIndex);

            // Recursively call Sort() to further split each sublist
            // until sublist size is 1.
            left = Sort(left);
            right = Sort(right);

            // Merge the sublists returned from prior calls to MergeSort()
            // and return the resulting merged sublist.
            return Merge(left, right);
        }

        private List<int> Merge(List<int> left, List<int> right)
        {
            Debug.WriteLine("Merge");
            Debug.WriteLine("Left: " + GetListAsString(left));
            Debug.WriteLine("Right: " + GetListAsString(right));

            List<int> result = new List<int>();

            // The two incoming lists are each sorted.
            // The must be merged into one single list by comparing the first element from each side.
            // The resulting list will be completely sorted.
            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    // Compare the first element of each list, append the smaller value to the result
                    // and remove it from the original list.
                    if (left[0] <= right[0])
                    {
                        result.Add(left[0]);
                        left.RemoveAt(0);
                    }
                    else
                    {
                        result.Add(right[0]);
                        right.RemoveAt(0);
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left[0]);
                    left.RemoveAt(0);
                }
                else if (right.Count > 0)
                {
                    result.Add(right[0]);
                    right.RemoveAt(0);
                }
            }

            Debug.WriteLine("Result: " + GetListAsString(result));

            return result;
        }

        private string GetListAsString(List<int> list)
        {
            string result = string.Empty;

            foreach (int i in list)
            {
                result += i.ToString();
            }

            return result;
        }
    }
}