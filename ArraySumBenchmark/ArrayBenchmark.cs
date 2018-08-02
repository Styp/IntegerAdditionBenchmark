using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace ArraySumBenchmark {
    
    public class ArrayBenchmark {
        [Params(15,255,4095,65535,1048575,16777215,268435455)]
        public int Size;

        public int[] ArrayA;
        public int[] ArrayB;
      
        [GlobalSetup]
        public void Setup() {
            ArrayA = new int[Size];
            ArrayB = new int[Size];

            var rnd = new Random();

            for (var i = 0; i < ArrayA.Length; i++) {
                ArrayA[i] = rnd.Next();
                ArrayB[i] = rnd.Next();
            }
        }
        
        [Benchmark]
        public void ForLoop() {
            ArraySum.ForLoop(ArrayA, ArrayB);
        }

        [Benchmark]
        public void ForLoopConst() {
            ArraySum.ForLoopConst(ArrayA, ArrayB);
        }
  
        [Benchmark]
        public void ForLoopReverse() {
            ArraySum.ForLoopReverse(ArrayA, ArrayB);
        }
        
        [Benchmark]
        public void ForLoopReversePostIncrement() {
            ArraySum.ForLoopReversePostIncrement(ArrayA, ArrayB);
        }

        [Benchmark]
        public void ParallelFor() {
            var outArray = new int[ArrayA.Length];
            Parallel.For(0, outArray.Length, i => { outArray[i] = ArrayA[i] + ArrayB[i]; });
        }

        [Benchmark]
        public void ParallelForPartitioned() {
            ArraySum.ParallelForPartioned(ArrayA, ArrayB);
        }

        [Benchmark]
        public void LinqZip() {
            var outArray = ArrayA.Zip(ArrayB, (a, b) => a + b).ToArray();
        }

        [Benchmark]
        public void LinqSelectWithElementAt() {
            var outArray = ArrayA.Select((a, i) => a * ArrayB.ElementAt(i)).ToArray();
        }
        
        [Benchmark]
        public void ParallelLinqSelectWithElementAt() {
            var outArray = ArrayA.AsParallel().Select((a, i) => a * ArrayB.ElementAt(i)).ToArray();
        }

        [Benchmark]
        public void LinqSelectWithDirectAccessor() {
            var outArray = ArrayA.Select((a, i) => a * ArrayB[i]).ToArray();
        }
        
        [Benchmark]
        public void ParallelLinqSelectWithDirectAccessor() {
            var outArray = ArrayA.AsParallel().Select((a, i) => a * ArrayB[i]).ToArray();
        }
        
        [Benchmark]
        public void SimdFor() {
            var outArray = ArraySum.SimdFor(ArrayA, ArrayB);
        }
        
        [Benchmark]
        public void ParallelSimdFor() {
            var outArray = ArraySum.ParallelSimdFor(ArrayA, ArrayB);
        }
    }

}