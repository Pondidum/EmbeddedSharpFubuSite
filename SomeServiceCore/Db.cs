using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Ploeh.AutoFixture;

namespace SomeServiceCore
{
    public class Db
    {
        public static IEnumerable<Work> LoadNextSet()
        {
            Thread.Sleep(500);    //db simulation...
            var fixture = new Fixture();

            Console.WriteLine("Loaded 10 Records.");

            return Enumerable.Range(0, 10).Select(i => fixture.Create<Work>());
        }
    }
}
