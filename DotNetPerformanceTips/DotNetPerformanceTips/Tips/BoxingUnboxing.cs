using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPerformanceTips.Tips.BoxingUnboxing
{
    public class SumWithBoxing
    {
        public object Sum(object n1, object n2, object n3, object n4)
        {
            return (int)n1 + (int)n2 + (int)n3 + (int)n4;
        }
    }

    public class SumWithType
    {
        public int Sum(int n1, int n2, int n3, int n4)
        {
            return n1 + n2 + n3 + n4;
        }
    }
}