using DotNetPerformanceTips.Benchmarks;

List<Benchmark> benchmarks = new()
{
    new ParamsBenchmark()
};

foreach (Benchmark benchmark in benchmarks)
{
    benchmark.Run();
}