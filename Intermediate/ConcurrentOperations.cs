using System.Threading.Tasks;
using Xunit;

namespace CSharpDrill.Intermediate
{
    public class ConcurrentOperationTests
    {
        // Task: Make implementation of Do() correct.

        [Fact]
        public void Do_For1000000Iterations_ShouldReturn0()
        {
            var result = ConcurrentOperations.Do(1000000);
            Assert.Equal(0, result);
        }
    }

    public static class ConcurrentOperations
    {
        public static int Do(int iterations)
        {
            var n = 0;

            var up = Task.Run(() =>
            {
                for (int i = 0; i < iterations; i++)
                    n++;
            });

            for (int i = 0; i < iterations; i++)
                n--;

            up.Wait();

            return n;
        }
    }
}
