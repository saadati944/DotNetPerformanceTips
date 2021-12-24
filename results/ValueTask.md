# Returning precalculated values in async methods

**Example :**

*code :*

```csharp

// Bad practice
public Task<int> GetConstantWithTaskRun()
{
    return Task.Run(() => 10);
}

// Best practices
public Task<int> GetConstantWithTaskFromResult()
{
    return Task.FromResult(10);
}

public ValueTask<int> GetConstantWithValueTask()
{
    return new ValueTask<int>(10);
}
```

## Benchmarks

Related codes : [Actual Class](../DotNetPerformanceTips/DotNetPerformanceTips/Tips/ValueTask.cs), [Benchmark](../DotNetPerformanceTips/DotNetPerformanceTips/Benchmarks/ValueTaskBenchmark.cs)

### Benchmark results

|            Method |        Mean | Allocated |
|------------------ |------------:|----------:|
|       WithTaskRun | 1,346.58 ns |     191 B |
|WithTaskFromResult |    26.25 ns |      72 B |
|     WithValueTask |    25.25 ns |         - |

**Results are variable depending on the host machine !!!**

## Important points

- The worst case scenario is to use task.run and send it a lambda, as it wastes a thread from the Thread Pool and performs poorly..
