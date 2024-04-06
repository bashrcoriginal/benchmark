using BenchmarkDotNet.Attributes;
using System.Linq;
using System.Threading;
using System.Collections.Generic;
using System.Collections.Immutable;

public class Counter
{
    Dictionary<Key, int> _counter = new Dictionary<Key, int>();
    public enum Key
    {
        abc,
        def,
        ghi
    };

    private int _counter1 = 0;
    private int _counter2 = 0;
    private int _counter3 = 0;
    private static Random random = new Random();
    private static readonly List<Key> _keys = new List<Key> {Key.abc, Key.def, Key.ghi};

    public int N = 16*1000;

    [Params(8, 16, 32, 64, 100, 2000)]
    public int MaxConcurrentThreads;

    [Benchmark]
    public long AddWithLock() => Add(true);

    [Benchmark]
    public long AddWithInterlocked() => Add(false);

    private long Add(bool withLock)
    {
        var tasks = new List<Task<int>>(N);
        var func = withLock ? new Func<Key, int>(_AddWithLock) : new Func<Key, int>(_AddWithInterlocked);
        for (int i = 0; i < N; i++)
        {
            var key = _keys[i % 3];
            tasks.Add(Task.Run(() => func(key)));
            if (i % MaxConcurrentThreads == 0)
            {
                Task.WhenAll(tasks).Wait();
            }
        }

        Task.WhenAll(tasks).Wait();
        Console.WriteLine($"LOLOLOLO2");
        return tasks.Sum(t => (long)t.Result);
    }
    private int _AddWithInterlocked(Key key)
    {
        Console.WriteLine($"LOLOLOLO");
        int value = 0;
        switch(key)
        {
            case Key.abc:
                value = Interlocked.Increment(ref _counter1);
                break;
            case Key.def:
                value = Interlocked.Increment(ref _counter2);
                break;
            case Key.ghi:
                value = Interlocked.Increment(ref _counter3);
                break;
        }
        Console.WriteLine($"LOLOLOLO2");
        return value;
    }

    private int _AddWithLock(Key key)
    {
        Console.WriteLine($"LOLOLOLO");

        int value;
        lock(this._counter)
        {
            if (this._counter.TryGetValue(key, out var val))
            {
                this._counter[key] = val + 1;
            }
            else
            {
                this._counter[key] = 1;
            }

            value = this._counter[key];
        }
        Console.WriteLine($"LOLOLOLO2");
        return value;
    }

}