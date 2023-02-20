using BenchmarkDotNet.Attributes;

namespace Benchmarks.Yield;

[MemoryDiagnoser]
public class YieldBenchmark
{
    [Params(20)]
    public int N;

    [Benchmark]
    public void TestWithoutYield()
    {
        foreach (var i in GetListWithoutYield(N))
        {
            // Do stuff 
        }
    }

    [Benchmark]
    public void TestWithYield()
    {
        foreach (var i in GetListWithYield(N))
        {
            // Do stuff 
        }
    }

    private static IEnumerable<int> GetListWithYield(int max)
    {
        for (int i = 0; i < max; i++)
        {
            yield return i;
        }
    }

    private static IEnumerable<int> GetListWithoutYield(int max)
    {
        var list = new List<int>();
        for (int i = 0; i < max; i++)
        {
            list.Add(i);
        }
        return list;
    }
}
