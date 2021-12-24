# Boxing & Unboxing

Boxing is the process of converting a value type to the type object or to any interface type implemented by this value type. When the common language runtime (CLR) boxes a value type, it wraps the value inside a System.Object instance and stores it on the managed heap. Unboxing extracts the value type from the object. Boxing is implicit; unboxing is explicit. The concept of boxing and unboxing underlies the C# unified view of the type system in which a value of any type can be treated as an object.

**Example :**

*code :*

```csharp
int val = 10;
object boxedVal = val;
int unboxedVal = (int) boxedval;
```

## Benchmarks

Related codes : [Actual Class](../DotNetPerformanceTips/DotNetPerformanceTips/Tips/BoxingUnboxing.cs), [Benchmark](../DotNetPerformanceTips/DotNetPerformanceTips/Benchmarks/BoxingAndUnboxingBenchmark.cs)

Note that this is not a good example of boxing and unboxing in reality, it is just to show the bad impact of abusing these concepts.

### Benchmark results

|           Method |       Mean | Allocated |
|----------------- |-----------:|----------:|
|    SumWithBoxing | 51.2319 ns |     120 B |
| SumWithOutBoxing |  0.0278 ns |         - |

**Results are variable depending on the host machine !!!**

## Important points

- The actual work is just adding some numbers together that does not take much time, and as you can see running time of the 'SumWithOutBoxing' is almost zero but the running time of 'SumWithBoxing' is much longer than we expect. only for boxing and unboxing the variables.
