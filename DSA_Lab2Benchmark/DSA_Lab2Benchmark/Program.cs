using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Lab2Benchmark {
    internal class DSA_Lab2Benchmark {
        static void Main(string[] args) {
            BenchmarkRunner.Run<DSA_Lab2BenchmarkTest>();
        }
    }
}
