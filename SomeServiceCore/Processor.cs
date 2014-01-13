using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace SomeServiceCore
{
    public class Processor : IProcessor
    {
        public IEnumerable<Work> CurrentWork { get; private set; }
        public int TotalBatchesProcessed { get; private set; }

        public Processor()
        {
            CurrentWork = Enumerable.Empty<Work>();
        }

        public void Start()
        {
            while (true)
            {
                var work = Db.LoadNextSet().ToList();

                CurrentWork = work;
                TotalBatchesProcessed++;

                foreach (var item in work)
                {
                    Thread.Sleep(1500);
                    Console.WriteLine(item.Name + ": Completed.");
                    item.Status = WorkStatus.Completed;
                }
                
            }

        }
    }
}