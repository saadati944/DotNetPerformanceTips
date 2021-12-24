using BenchmarkDotNet.Attributes;
using DotNetPerformanceTips.Tips.BoxingUnboxing;

namespace DotNetPerformanceTips.Benchmarks;
public class BoxingAndUnboxingBenchmark : Benchmark
{
    private SumWithBoxing sumWithBoxing;
    private SumWithType sumWithoutBoxing;

    public override string DisplayName => "Boxing and unboxing";
    public BoxingAndUnboxingBenchmark()
    {
        sumWithBoxing = new SumWithBoxing();
        sumWithoutBoxing = new SumWithType();
    }

    [Benchmark]
    public void SumWithBoxing()
    {
        int _ = (int) sumWithBoxing.Sum(1, 2, 3, 4);
    }

    [Benchmark]
    public void SumWithOutBoxing()
    {
        int _ = sumWithoutBoxing.Sum(1, 2, 3, 4);
    }
}
