using BenchmarkDotNet.Attributes;
using DotNetPerformanceTips.Tips.Params;

namespace DotNetPerformanceTips.Benchmarks;

public class ParamsBenchmark : Benchmark
{
    private SimpleParams simpleParams;
    private SimpleParamsWithOverloads simpleParamsWithOverloads;

    private int[] inputs;

    public override string DisplayName => "Params keyword";

    public ParamsBenchmark()
    {
        simpleParams = new SimpleParams();
        simpleParamsWithOverloads = new SimpleParamsWithOverloads();
        inputs = new []{ 1, 2, 3, 4, 5};
    }

    [Benchmark]
    public void SimpleParams5Inputs()
    {
        _ = simpleParams.Sum(1, 2, 3, 4, 5);
    }

    [Benchmark]
    public void SimpleParamsArrayInput()
    {
        _ = simpleParams.Sum(inputs);
    }

    [Benchmark]
    public void SimpleParams0Input()
    {
        _ = simpleParams.Sum();
    }

    [Benchmark]
    public void SimpleParams2Input()
    {
        _ = simpleParams.Sum(1, 2);
    }

    [Benchmark]
    public void SimpleParamsWithOverloads2Input()
    {
        _ = simpleParamsWithOverloads.Sum(1, 2);
    }
}

