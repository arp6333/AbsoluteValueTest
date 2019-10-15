using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace AbsoluteValueTest
{
    public class AbsoluteValueTest
    {
        public static void Main(string[] args)
        {
            string key = "r";
            do
            {
                var absolute = 0;
                Stopwatch stopwatch = new Stopwatch();
                List<TimeSpan> values = new List<TimeSpan>();

                // Aboslute Value time
                for (int j = 0; j < 1000; j++)
                {
                    stopwatch.Start();
                    for (int i = -1; i >= -1000000; i--)
                    {
                        absolute = Math.Abs(i);
                    }
                    stopwatch.Stop();
                    values.Add(stopwatch.Elapsed);
                    stopwatch.Reset();
                }

                stopwatch.Stop();
                Console.WriteLine("Absolute Value average time (in ms): " + values.Average(timeSpan => timeSpan.Milliseconds));

                // Multiplied by -1 time
                values.Clear();
                for (int j = 0; j < 1000; j++)
                {
                    stopwatch.Start();
                    for (int i = -1; i >= -1000000; i--)
                    {
                        absolute = i * -1;
                    }
                    stopwatch.Stop();
                    values.Add(stopwatch.Elapsed);
                    stopwatch.Reset();
                }

                stopwatch.Stop();
                Console.WriteLine("Multiplied by -1 average time (in ms): " + values.Average(timeSpan => timeSpan.Milliseconds));

                // Multiplied by -1 with negative check time
                values.Clear();
                for (int j = 0; j < 1000; j++)
                {
                    stopwatch.Start();
                    for (int i = -1; i >= -1000000; i--)
                    {
                        if (i < 0)
                        {
                            absolute = i * -1;
                        }
                    }
                    stopwatch.Stop();
                    values.Add(stopwatch.Elapsed);
                    stopwatch.Reset();
                }

                stopwatch.Stop();
                Console.WriteLine("Multiplied by -1 with negative check average time (in ms): " + values.Average(timeSpan => timeSpan.Milliseconds));
                Console.WriteLine("Type 'r' to run again, any other key to exit.");
                key = Console.ReadLine();
            } while (key.Equals("r"));
        }
    }
}