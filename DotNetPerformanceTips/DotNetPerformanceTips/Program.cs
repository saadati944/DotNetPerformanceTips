using DotNetPerformanceTips.Benchmarks;
using System.Reflection;

namespace DotNetPerformanceTips;

public class Program
{
    private string menu = "Choose one to start benchmarks :";
    private List<Benchmark> benchmarks = new List<Benchmark>();

    public static void Main(string[] args)
    {
        var prog = new Program();
        prog.AddBenchmarks();
        prog.PresentMenu();
    }

    private void AddBenchmarks()
    {
        foreach (var type in Assembly.GetExecutingAssembly().GetTypes())
        {
            if (type.IsAssignableTo(typeof(Benchmark)) && !type.IsAbstract)
            {
                object? obj = Activator.CreateInstance(type);
                if (obj is not null) benchmarks.Add(obj as Benchmark);
            }
        }
    }

    private void PresentMenu()
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine(menu);
            Console.WriteLine();
            int i = 1;
            foreach (var item in benchmarks)
            {
                Console.WriteLine(" {0} -> {1}", i, item.DisplayName);
                i++;
            }
            Console.WriteLine(" {0} -> exit", i);
            Console.WriteLine();

            int? ch = null;
            do
            {
                ch = GetChoise();
            } while (ch == null || ch < 1 || ch > benchmarks.Count + 1);

            if (ch == benchmarks.Count+1)
                break;

            benchmarks[ch.Value - 1].Run();
        }
    }

    public int? GetChoise()
    {
        Console.Write("Enter a number : ");
        if (!int.TryParse(Console.ReadLine(), out int choise)) return null;
        return choise;
    }
}