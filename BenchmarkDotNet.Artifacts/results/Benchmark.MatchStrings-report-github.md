```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.2 LTS (Jammy Jellyfish) WSL
12th Gen Intel Core i7-1260P, 1 CPU, 16 logical and 8 physical cores
.NET SDK 7.0.117
  [Host]     : .NET 7.0.17 (7.0.1724.12101), X64 RyuJIT AVX2
  Job-AAOTNE : .NET 7.0.17 (7.0.1724.12101), X64 RyuJIT AVX2

IterationCount=100  

```
| Method                     | input                | Mean     | Error     | StdDev    |
|--------------------------- |--------------------- |---------:|----------:|----------:|
| **UniqueOptionSetsUsingRegex** | **_CQQ(...)LVFJ [2132]** | **4.656 μs** | **0.0413 μs** | **0.1211 μs** |
| **UniqueOptionSetsUsingRegex** | **_KZU(...)O_KJ [2165]** | **8.748 μs** | **0.0991 μs** | **0.2890 μs** |
| **UniqueOptionSetsUsingSpan**  | **_L_J(...)QQNO [2180]** | **2.184 μs** | **0.0272 μs** | **0.0798 μs** |
| **UniqueOptionSetsUsingSpan**  | **BCOJ(...)ZPLN [2144]** | **1.791 μs** | **0.0139 μs** | **0.0404 μs** |
| **UniqueOptionSetsUsingRegex** | **LCIP(...)PPOV [2168]** | **8.549 μs** | **0.0833 μs** | **0.2455 μs** |
| **UniqueOptionSetsUsingSpan**  | **OHQD(...)_U_O [2174]** | **2.199 μs** | **0.0179 μs** | **0.0527 μs** |
| **UniqueOptionSetsUsingRegex** | **QKDR(...)CTI_ [2156]** | **7.551 μs** | **0.0789 μs** | **0.2290 μs** |
| **UniqueOptionSetsUsingRegex** | **syd_(...)BRWL [2168]** | **8.640 μs** | **0.0849 μs** | **0.2477 μs** |
| **UniqueOptionSetsUsingSpan**  | **sydN(...)HYKC [2195]** | **2.414 μs** | **0.0199 μs** | **0.0583 μs** |
| **UniqueOptionSetsUsingSpan**  | **Z_GX(...)SAIB [2162]** | **2.023 μs** | **0.0226 μs** | **0.0664 μs** |
