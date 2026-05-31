using BenchmarkDotNet.Attributes;
using DSA_Lab2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Lab2Benchmark {
    [MemoryDiagnoser]
    [RankColumn]
    public class DSA_Lab2BenchmarkTest {
        [Params(1000, 10000, 100000, 1000000, 10000000)]
        public int N;
        private readonly DuplicatesFinder _DuplicatesFinder = new DuplicatesFinder();
        private readonly Hash _Hash = new Hash(997);
        List<int> arr;
        Random rand = new Random();

        [IterationSetup]
        public void Setup() {
            arr = new List<int>(N);
            for (int i = 0; i < N; i++) {
                arr.Add(rand.Next(1000));
            }
        }

        [IterationCleanup]
        public void Cleanup() { 
            arr = null;
        }

        [Benchmark]
        public void BruteForce_DuplicateFinderTest() {
            _DuplicatesFinder.BruteForce(arr);
        }

        [Benchmark]
        public void WithFrequencyArray_DuplicateFinderTest() {
            _DuplicatesFinder.WithFrequencyArray(arr);
        }

        [Benchmark]
        public void SortAndCompare_DuplicateFinderTest() {
            _DuplicatesFinder.SortAndCompare(arr);
        }
    }
}
