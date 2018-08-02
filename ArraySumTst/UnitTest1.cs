using System;
using ArraySumBenchmark;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArraySumTst {
    
    [TestClass]
    public class UnitTest1 {
        const int Size = 101; // Prime Number!

        public static int[] GenerateRandomArrayWithLength(int size) {
            var rnd = new Random();
            var arr = new int[size];

            for (var i = 0; i < size; i++) {
                arr[i] = rnd.Next();
            }
            return arr;
        }

        public static void AreEqual(int[] a, int[] b) {
            Assert.AreEqual(a.Length, b.Length);

            for (var i = 0; i < a.Length; i++) {
                if (a[i] != b[i]) {
                    Assert.Fail("Value not same at: {0}", i);
                }
            }
        }
        
        [TestMethod]
        public void ReverseForHasToBeEqual() {

            var a = GenerateRandomArrayWithLength(Size);
            var b = GenerateRandomArrayWithLength(Size);

            var forLoopOut = ArraySum.ForLoop(a, b);
            var forLoopReverseOut = ArraySum.ForLoopReverse(a, b);
            
            AreEqual(forLoopOut, forLoopReverseOut);

        }
        
        [TestMethod]
        public void ConstForHasToBeEqual() {

            var a = GenerateRandomArrayWithLength(Size);
            var b = GenerateRandomArrayWithLength(Size);

            var forLoopOut = ArraySum.ForLoop(a, b);
            var forLoopConst = ArraySum.ForLoopConst(a, b);
            
            AreEqual(forLoopOut, forLoopConst);

        }
        
        [TestMethod]
        public void ParallelPartitionedHasToBeEqual() {

            var a = GenerateRandomArrayWithLength(Size);
            var b = GenerateRandomArrayWithLength(Size);

            var forLoopOut = ArraySum.ForLoop(a, b);
            var forLoopParallelPartioned = ArraySum.ParallelForPartioned(a, b);
            
            AreEqual(forLoopOut, forLoopParallelPartioned);

        }
        
        [TestMethod]
        public void SimdForHasToBeEqual() {

            var a = GenerateRandomArrayWithLength(Size);
            var b = GenerateRandomArrayWithLength(Size);

            var forLoopOut = ArraySum.ForLoop(a, b);
            var forLoopSimd = ArraySum.SimdFor(a, b);
            
            AreEqual(forLoopOut, forLoopSimd);

        }
        
        [TestMethod]
        public void ParallelSimdForHasToBeEqual() {

            var a = GenerateRandomArrayWithLength(Size);
            var b = GenerateRandomArrayWithLength(Size);

            var forLoopOut = ArraySum.ForLoop(a, b);
            var forLoopParallelSimd = ArraySum.ParallelSimdFor(a, b);
            
            AreEqual(forLoopOut, forLoopParallelSimd);

        }
    }
}