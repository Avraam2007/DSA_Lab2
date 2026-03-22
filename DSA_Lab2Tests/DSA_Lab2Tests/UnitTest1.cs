using DSA_Lab2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace DSA_Lab2Tests {
    [TestClass]
    public class DsaTests {
        [TestMethod]
        [TestCategory("DuplicatesFinder")]
        public void DuplicatesFinder_WithValidTypes_BruteForce() {
            int expected = 9;
            List<int> array = new List<int>{ 154, 32, 9, 74, 5, 9, 11, 258 };
            DuplicatesFinder df = new DuplicatesFinder();

            int actual = df.BruteForce(array);

            Assert.AreEqual(expected, actual, "Duplicate number not found correctly");
        }

        [TestMethod]
        [TestCategory("DuplicatesFinder")]
        public void DuplicatesFinder_WithOneElementArray_BruteForce() {
            int expected = -1;
            List<int> array = new List<int>{ 154 };
            DuplicatesFinder df = new DuplicatesFinder();

            int actual = df.BruteForce(array);

            Assert.AreEqual(expected, actual, "Duplicate number not found correctly");
        }

        [TestMethod]
        [TestCategory("DuplicatesFinder")]
        public void DuplicatesFinder_WithValidTypes_SortAndCompare() {
            List<int> expected = new List<int> { 9, 32 };
            List<int> array = new List<int>{ 154, 32, 9, 74, 5, 9, 11, 32, 258 };
            DuplicatesFinder df = new DuplicatesFinder();

            List<int> actual = df.SortAndCompare(array);

            CollectionAssert.AreEqual(expected, actual, "Duplicate numbers not found correctly");
        }

        [TestMethod]
        [TestCategory("DuplicatesFinder")]
        public void DuplicatesFinder_WithOneElementArray_SortAndCompare() {
            List<int> expected = null;
            List<int> array = new List<int>{ 154 };
            DuplicatesFinder df = new DuplicatesFinder();

            List<int> actual = df.SortAndCompare(array);

            Assert.AreEqual(expected, actual, "Duplicate number not found correctly");
        }

        [TestMethod]
        [TestCategory("DuplicatesFinder")]
        public void DuplicatesFinder_WithValidTypes_WithFrequencyArray() {
            List<int> expected = new List<int> { 9, 32 };
            List<int> array = new List<int> { 154, 32, 9, 74, 5, 9, 11, 32, 258 };
            DuplicatesFinder df = new DuplicatesFinder();

            List<int> actual = df.WithFrequencyArray(array);

            CollectionAssert.AreEqual(expected, actual, "Duplicate numbers not found correctly");
        }

        [TestMethod]
        [TestCategory("DuplicatesFinder")]
        public void DuplicatesFinder_WithOneElementArray_WithFrequencyArray() {
            List<int> expected = null;
            List<int> array = new List<int> { 154 };
            DuplicatesFinder df = new DuplicatesFinder();

            List<int> actual = df.WithFrequencyArray(array);

            Assert.AreEqual(expected, actual, "Duplicate number not found correctly");
        }

        [TestMethod]
        [TestCategory("Hash")]
        public void Hash_WithValidTypes_HashSum() {
            int expected = 27;
            string test = "hello";
            Hash hashing = new Hash(101);

            int actual = hashing.HashSum(test);

            Assert.AreEqual(expected, actual, "hashing not working correctly");
        }

        [TestMethod]
        [TestCategory("Hash")]
        public void Hash_WithValidTypes_HornerHash() {
            int expected = int.MaxValue;
            string test = "hello";
            Hash hashing = new Hash(101);

            int actual = hashing.HornerHash(test, 31);

            Assert.AreEqual(expected, actual, "hashing not working correctly");
        }

        [TestMethod]
        [TestCategory("Hash")]
        public void Hash_WithValidTypes_MultiplyingHash() {
            double expected = double.NaN;
            string test = "hello";
            Hash hashing = new Hash(101);

            double actual = hashing.MultiplyingHash(test, 31, 0.618033);

            Assert.AreEqual(expected, actual, "hashing not working correctly");
        }

        [TestMethod]
        [TestCategory("Hash")]
        public void Hash_WithValidTypes_HashSumWithPos() {
            double expected = double.NaN;
            string test = "hello";
            Hash hashing = new Hash(101);

            double actual = hashing.HashSumWithPos(test);

            Assert.AreEqual(expected, actual, "hashing not working correctly");
        }
    }
}
