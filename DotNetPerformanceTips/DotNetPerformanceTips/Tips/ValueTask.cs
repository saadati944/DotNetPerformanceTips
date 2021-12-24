using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPerformanceTips.Tips.ValueTask
{
    public class ValueTaskTip
    {
        public Task<int> GetConstantWithTaskRun()
        {
            return Task.Run(() => 10);
        }

        public Task<int> GetConstantWithTaskFromResult()
        {
            return Task.FromResult(10);
        }

        public ValueTask<int> GetConstantWithValueTask()
        {
            return new ValueTask<int>(10);
        }
    }
}
