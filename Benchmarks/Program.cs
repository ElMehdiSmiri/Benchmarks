using BenchmarkDotNet.Running;
using Benchmarks.Yield;

Console.WriteLine("Benchmark starting...");

BenchmarkRunner.Run<YieldBenchmark>();

Console.WriteLine("Benchmark concluded");
