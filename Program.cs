// See https://aka.ms/new-console-template for more information
using Benchmark;
using BenchmarkDotNet.Running;
using System.Threading;

BenchmarkRunner.Run<MatchStrings>();
// var matchStrings = new MatchStrings();
// foreach (var str in matchStrings.GenerateRandomStrings())
// {
//     var values = matchStrings.UniqueOptionSetsUsingRegex(str);
//     Console.WriteLine($"Values: {string.Join(",", values)}");
//     var values2 = matchStrings.UniqueOptionSetsUsingSpan(str);
//     Console.WriteLine($"Values: {string.Join(",", values2)}");
//     if (values.Count != values2.Count)
//     {
//         Console.WriteLine($"Values: {string.Join(",",values.Exc(values2))}");
//         throw new Exception("Values are not equal");
//     }
// }

// var counter = new Counter();
// counter.MaxConcurrentThreads = 64;
// counter.AddWithInterlocked();
// counter.N = 16*1000;
// Console.WriteLine($"AddWithLock: {counter.AddWithLock()}");
// var counter2 = new Counter();
// counter2.N = 16*1000;
// Console.WriteLine($"AddWithInterlocked: {counter2.AddWithInterlocked()}");
