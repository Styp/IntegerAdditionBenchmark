using System;
using System.Numerics;
using BenchmarkDotNet.Running;

namespace ArraySumBenchmark {
    class Program {

        static void Main(string[] args) {
            BenchmarkRunner.Run<ArrayBenchmark>();
        }
    }
}