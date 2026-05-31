using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Lab2 {
    internal class Program {
        static void Main(string[] args) {
            Hash h = new Hash(997);
            string word = "Hello world!";
            Console.WriteLine("Word: " + word);
            Console.WriteLine("\nHash number: " + h.HashSum(word));
        }
    }
}
