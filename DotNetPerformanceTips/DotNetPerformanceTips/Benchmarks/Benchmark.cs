using BenchmarkDotNet.Running;
using BenchmarkDotNet.Attributes;

namespace DotNetPerformanceTips.Benchmarks;

[MemoryDiagnoser(false)]
public abstract class Benchmark
{
    public abstract string DisplayName { get; }

    public void Run()
    {
        BenchmarkRunner.Run(this.GetType());
    }
}

