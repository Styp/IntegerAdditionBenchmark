using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;

namespace ArraySumBenchmark {
    public static class ArraySum {

        public static int[] ForLoop(int[] a, int[] b) {
            var outArray = new int[a.Length];

            for (var i = 0; i < outArray.Length; i++) {
                outArray[i] = a[i] + b[i];

            }
            return outArray;
        }

        public static int[] ForLoopReverse(int[] a, int[] b) {
            var outArray = new int[a.Length];

            for (var i = outArray.Length - 1; i >= 0; --i) {
                outArray[i] = a[i] + b[i];
            }

            return outArray;
        }

        public static int[] ForLoopReversePostIncrement(int[] a, int[] b) {
            var outArray = new int[a.Length];

            for (var i = outArray.Length - 1; i >= 0; i--) {
                outArray[i] = a[i] + b[i];
            }

            return outArray;
        }
        
        public static int[] ForLoopConst(int[] a, int[] b) {
            var outArray = new int[a.Length];
            var length = a.Length;

            for (var i = 0; i < length; i++) {
                outArray[i] = a[i] + b[i];
            }

            return outArray;
        }

        public static int[] SimdFor(int[] a, int[] b) {
            var outArray = new int[a.Length];

            var simdLength = Vector<int>.Count;

            int i;
            for (i = 0; i <= outArray.Length - simdLength; i += simdLength) {
                var va = new Vector<int>(a, i);
                var vb = new Vector<int>(b, i);
                var vOut = Vector.Add(va, vb);
                vOut.CopyTo(outArray, i);
            }

            // Process any remaining elements
            for (; i < outArray.Length; ++i) {
                outArray[i] = a[i] + b[i];
            }

            return outArray;
        }
        
        public static int[] ParallelForPartioned(int[] a, int[] b) {
            var outArray = new int[a.Length];
            
            var numOfThreads = Environment.ProcessorCount;
            var partition = outArray.Length / numOfThreads;
            
            Parallel.For(0, numOfThreads, currentThread => {
                var thisFirst = partition * currentThread;
                var thisLast = partition * (currentThread + 1);
                for (var i = thisFirst; i < thisLast; i++) {
                    outArray[i] = a[i] + b[i];
                }
            });

            for (var i = numOfThreads * partition; i < outArray.Length; i++) {
                outArray[i] = a[i] + b[i];
            }

            return outArray;
        }

        public static int[] ParallelSimdFor(int[] a, int[] b) {
            var outArray = new int[a.Length];
            var simdLength = Vector<int>.Count;
            
            var numOfThreads = Environment.ProcessorCount / 2;
            var partition = outArray.Length / numOfThreads;
            
            Parallel.For(0, numOfThreads, currentThread => {
                var thisFirst = partition * currentThread;
                var thisLast = partition * (currentThread + 1);
                
                int i;
                for (i = thisFirst; i <= thisLast - simdLength; i += simdLength) {
                    var va = new Vector<int>(a, i);
                    var vb = new Vector<int>(b, i);
                    var vOut = Vector.Add(va, vb);
                    vOut.CopyTo(outArray, i);
                }

                // Process any remaining elements
                for (; i < thisLast; ++i) {
                    outArray[i] = a[i] + b[i];
                }
            });
            
            for (var i = numOfThreads * partition; i < outArray.Length; i++) {
                outArray[i] = a[i] + b[i];
            }

            return outArray;
        }
   
        
    }
}