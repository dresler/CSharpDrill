using System;
using System.Threading.Tasks;
using Xunit;

namespace CSharpDrill.Advanced
{
    public class DeadlockMakerTests
    {
        // Task: Implement a deadlock in DeadlockMaker.Do()

        [Fact]
        public void Do_ShouldTimedOut()
        {
            var timedOut = true;

            var task = Task.Run(() =>
            {
                DeadlockMaker.Do();
                timedOut = false;
            });

            task.Wait(TimeSpan.FromSeconds(1));

            Assert.True(timedOut);
        }
    }

    public class DeadlockMaker
    {
        public static void Do()
        {
            var taskA = Task.Run(() => { });

            var taskB = Task.Run(() => { });

            Task.WaitAll(taskA, taskB);
        }
    }
}