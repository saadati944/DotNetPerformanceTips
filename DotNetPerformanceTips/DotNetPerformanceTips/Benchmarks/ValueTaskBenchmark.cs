using BenchmarkDotNet.Attributes;
using DotNetPerformanceTips.Tips.ValueTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPerformanceTips.Benchmarks;

public class ValueTaskBenchmark : Benchmark
{
    private ValueTaskTip valueTaskTip;
    public override string DisplayName => "Value task";

    public ValueTaskBenchmark()
    {
        valueTaskTip = new ValueTaskTip();
    }

    [Benchmark]
    public async Task WithTaskRun()
    {
        var _ = await valueTaskTip.GetConstantWithTaskRun();
    }

    [Benchmark]
    public async Task WithTaskFromResult()
    {
        var _ = await valueTaskTip.GetConstantWithTaskFromResult();
    }

    [Benchmark]
    public async Task WithValueTask()
    {
        var _ = await valueTaskTip.GetConstantWithValueTask();
    }
}
