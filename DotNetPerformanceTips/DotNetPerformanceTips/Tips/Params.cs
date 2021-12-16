using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPerformanceTips.Tips.Params;

public class SimpleParams
{
    public int Sum(params int[] inputs)
    {
        int sum = 0;
        for(int i=0; i<inputs.Length; i++)
            sum += inputs[i];
        return sum;
    }
}
public class SimpleParamsWithOverloads
{
    public int Sum(params int[] inputs)
    {
        int sum = 0;
        for (int i = 0; i < inputs.Length; i++)
            sum += inputs[i];
        return sum;
    }
    public int Sum(int firstInput, int secondInput)
    {
        return firstInput + secondInput;
    }
    public int Sum(int input)
    {
        return input;
    }
}
