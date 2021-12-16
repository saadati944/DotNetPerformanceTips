# Params

## Params keywork

The "params" keyword in C# allows a method to accept a variable number of arguments. C# params works as an array of objects. By using params keyword in a method argument definition, we can pass a number of arguments. Note: There can't be anymore parameters after a params.

**Example :**

*code :*

```csharp
Console.WriteLine(Sum());
Console.WriteLine(Sum(1));
Console.WriteLine(Sum(1, 2, 3, 4));

int Sum(params int[] inputs) {
    int sum = 0;
    foreach(int item in inputs)
        sum += item;
    return sum;
}
```

*output :*

```text
0
1
10
```

## Benchmarks

Related codes : [Actual Class](../DotNetPerformanceTips/DotNetPerformanceTips/Tips/Params.cs), [Benchmark](../DotNetPerformanceTips/DotNetPerformanceTips/Benchmarks/ParamsBenchmark.cs)

### Benchmark results

```terminal
|                          Method |      Mean | Allocated |
|-------------------------------- |----------:|----------:|
|             SimpleParams5Inputs | 9.2889 ns |      48 B |
|          SimpleParamsArrayInput | 3.6448 ns |         - |
|              SimpleParams0Input | 1.8979 ns |         - |
|              SimpleParams2Input | 5.7846 ns |      32 B |
| SimpleParamsWithOverloads2Input | 0.0048 ns |         - |
```

**Results are variable depending on the host machine !!!**

## Important points

- Each time you call a function that has a params keyword, the compiler creates an array of those objects and passes it to the function so each time it creates a new array, this is why `SimpleParamsArrayInput` is faster than `SimpleParams5Inputs` and has no memory allocation.

- In `SimpleParams0Input`, the compiler uses `Array.Empty<T>()` instead of `new T[0]` and this function uses an static empty array and doesn't create an array every time. so the memory allocation in `SimpleParams0Input` is zero.

- Having function overloads with most used number of inputs can help a lot. as you can see the running time of `SimpleParamsWithOverloads2Input` is almost zero and it doesn't have any memory allocation but `SimpleParams2Input` is has high runtime and even has memory allocation.
