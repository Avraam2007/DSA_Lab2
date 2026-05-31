using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Lab2 {
    public class Hash {
        private int mod = 997;

        public int Mod { 
            get { return mod; } 
            set {
                if (value <= 0) {
                    throw new ArgumentException("Modifier cannot be negative");
                }
                mod = value; 
            } 
        }

        public Hash(int m) {
            this.Mod = m;
        }

        public int HashSum(string input) {
            //var sw = Stopwatch.StartNew();
            int hash = 0;
            foreach (char c in input) {
                hash += (int)c;
            }
            hash %= this.mod;
            //sw.Stop();
            //Console.WriteLine($"Time spent: {sw.Elapsed}");
            return hash;
        }

        public int HornerHash(string input, int p) {
            var sw = Stopwatch.StartNew();
            int hash = 0, l = 1;
            foreach (char c in input) {
                hash += (int)c * (int)Math.Pow(p,input.Length-l);
            }
            hash %= this.mod;
            sw.Stop();
            Console.WriteLine($"Time spent: {sw.Elapsed}");
            return hash;
        }

        public double MultiplyingHash(string input, int p, double A) {
            if (A < 0 || A > 1) {
                throw new ArgumentException("A should be between 0 and 1: 0 < A < 1");
            }
            var sw = Stopwatch.StartNew();

            double hash = 0;
            foreach (char x in input) {
                double n = this.mod * (((int)x * A) % 1);
                hash += (n - Math.Floor(n));
            }
            sw.Stop();
            Console.WriteLine($"Time spent: {sw.Elapsed}");
            return hash;
        }

        public int HashSumWithPos(string input) {
            var sw = Stopwatch.StartNew();
            int hash = 0;
            for (int i = 0; i < input.Length; i++) {
                hash += ((int)input[i] * (i+1));
            }
            hash %= this.mod;
            sw.Stop();
            Console.WriteLine($"Time spent: {sw.Elapsed}");
            return hash;
        }
    }
}
