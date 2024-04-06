```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.2 LTS (Jammy Jellyfish) WSL
12th Gen Intel Core i7-1260P, 1 CPU, 16 logical and 8 physical cores
.NET SDK 7.0.117
  [Host]     : .NET 7.0.17 (7.0.1724.12101), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.17 (7.0.1724.12101), X64 RyuJIT AVX2


```
| Method             | MaxConcurrentThreads | Mean       | Error      | StdDev     |
|------------------- |--------------------- |-----------:|-----------:|-----------:|
| **AddWithLock**        | **8**                    | **505.126 ms** | **10.0328 ms** | **25.8979 ms** |
| AddWithInterlocked | 8                    | 520.803 ms | 10.1269 ms | 17.4685 ms |
| **AddWithLock**        | **16**                   | **262.695 ms** |  **5.2194 ms** |  **9.9305 ms** |
| AddWithInterlocked | 16                   | 257.822 ms |  5.0428 ms |  7.3917 ms |
| **AddWithLock**        | **32**                   | **134.613 ms** |  **2.6483 ms** |  **3.8819 ms** |
| AddWithInterlocked | 32                   | 134.988 ms |  2.6772 ms |  3.1870 ms |
| **AddWithLock**        | **64**                   |  **72.417 ms** |  **1.4460 ms** |  **3.1127 ms** |
| AddWithInterlocked | 64                   |  68.575 ms |  1.3317 ms |  1.3676 ms |
| **AddWithLock**        | **100**                  |  **45.649 ms** |  **0.4809 ms** |  **0.4016 ms** |
| AddWithInterlocked | 100                  |  49.167 ms |  0.9739 ms |  1.4872 ms |
| **AddWithLock**        | **2000**                 |   **9.576 ms** |  **0.1750 ms** |  **0.2395 ms** |
| AddWithInterlocked | 2000                 |  11.943 ms |  0.6215 ms |  1.8326 ms |
