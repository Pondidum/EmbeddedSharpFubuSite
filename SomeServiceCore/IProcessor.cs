using System.Collections.Generic;

namespace SomeServiceCore
{
    public interface IProcessor
    {
        IEnumerable<Work> CurrentWork { get; }
        int TotalBatchesProcessed { get; }

        void Start();
    }
}