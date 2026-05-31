using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Lab2 {
    public class DuplicatesFinder {

        private bool CheckArraySize<T>(List<T> arr) {
            return arr == null || arr.Count <= 1;
        }

        public int BruteForce(List<int> arr) {
            if (CheckArraySize<int>(arr)) {
                return -1;
            }
            var sw = Stopwatch.StartNew();
            for (int i = 0; i < arr.Count; i++) {
                for (int j = i + 1; j < arr.Count; j++) {
                    if (arr[i] == arr[j]) {
                        sw.Stop();
                        Console.WriteLine($"Time spent: {sw.Elapsed}");
                        return arr[j];
                    }
                }
            }
            return -1;
        }

        public List<int> WithFrequencyArray(List<int> arr) {
            if (CheckArraySize<int>(arr)) {
                return null;
            }
            //if(arr.Max() > arr.Count) {
            //    throw new Exception("The bigeest element shouldn't be more than array size");
            //}

            //var sw = Stopwatch.StartNew();

            int n = arr.Count;

            List<int> freq = new List<int>();
            freq.AddRange(Enumerable.Repeat(0, arr.Max() + 1));

            List<int> ans = new List<int>();

            foreach (int num in arr) {
                freq[num]++;
            }

            //for (int i = 0; i < arr.Count; i++) {
            //    freq[arr[i]]++;
            //}

            //for (int i = 1; i <= n; i++) {
            //    if (freq[i] == 2) {
            //        ans.Add(i);
            //    }
            //}

            for (int i = 1; i < freq.Count; i++) {
                if (freq[i] >= 2) {
                    ans.Add(i);
                }
            }

            //sw.Stop();
            //Console.WriteLine($"Time spent: {sw.Elapsed}");
            return ans;
        }

        public List<int> SortAndCompare(List<int> arr) {
            if (CheckArraySize<int>(arr)) {
                return null;
            }
            var sw = Stopwatch.StartNew();
            arr.Sort();
            List<int> ans = new List<int>();
            for (int i = 1; i < arr.Count; i++) {
                if (arr[i] == arr[i - 1]) {
                    if (ans.Count == 0 || ans.Last() != arr[i]) {
                        ans.Add(arr[i]);
                    }
                }
            }
            sw.Stop();
            Console.WriteLine($"Time spent: {sw.Elapsed}");
            return ans;
        }
    }
}
