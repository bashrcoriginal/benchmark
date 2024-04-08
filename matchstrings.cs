using System.Text;
using System.Text.RegularExpressions;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;
namespace Benchmark
{

    partial class MatchRegex
    {
        [GeneratedRegex("syd([a-zA-Z0-9 _:]+)(,)?", RegexOptions.IgnoreCase | RegexOptions.Singleline)]
        public static partial Regex SydPrefix();
    }

    [MemoryDiagnoser]

        public class MatchStrings
    {
        public int NumbersOfSegments = 100;
        public int NumberOfIterations = 5;
        
        private static readonly Random rnd = new Random();

        [ArgumentsSource(nameof(GenerateRandomStrings))]
        [IterationCount(100)]
        [Benchmark]
        public ISet<string> UniqueOptionSetsUsingRegex(string input) => SplitStringWithRegex(input);

        [ArgumentsSource(nameof(GenerateRandomStrings))]
        [IterationCount(100)]
        [Benchmark]
        public ISet<string> UniqueOptionSetsUsingSpan(string input) => SplitStringAsSpan(input);
        private static ISet<string> SplitStringWithRegex(string input)
        {
            var matches = MatchRegex.SydPrefix().Matches(input);
            var values = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (Match match in matches)
            {
                values.Add(match.Groups[1].Value);
            }

            return values; 
        }

        private static ISet<string> SplitStringAsSpan(string input)
        {
            var values = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            var remainingInput = input.AsSpan();
            var prefix = "syd".AsSpan();
            while (!remainingInput.IsEmpty)
            {
                var value = GetNextValue(remainingInput, out remainingInput);
                if (value.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
                {
                    values.Add(value[3..].ToString());
                }
            }

            return values;
        }

        private static ReadOnlySpan<char> GetNextValue(ReadOnlySpan<char> input, out ReadOnlySpan<char> remainingInput)
        {
            var commaIndex = input.IndexOf(',');
            if (commaIndex == -1)
            {
                remainingInput = ReadOnlySpan<char>.Empty;
                return input;
            }

            remainingInput = input[(commaIndex + 1)..];
            return input[..commaIndex];
        }

        public IEnumerable<string> GenerateRandomStrings()
        {
            for (int i = 0; i < this.NumberOfIterations; i++)
            {
                int numbersOfSegments = this.NumbersOfSegments;
                var segments = new List<string>(numbersOfSegments);
                for (int j = 0; j < numbersOfSegments; j++)
                {
                    var randomString = (rnd.Next(0, 5) == 1 ? "syd" : "") + string.Join("", Enumerable.Range(0, 20).Select(x => rnd.Next(0,10) != 1 ? ((char)(rnd.Next(0, 26) + 'A')) : '_'));
                    segments.Add(randomString);
                }
                
                yield return string.Join(",", segments);
            }
        }
    }
}