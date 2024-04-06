```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.2 LTS (Jammy Jellyfish) WSL
12th Gen Intel Core i7-1260P, 1 CPU, 16 logical and 8 physical cores
.NET SDK 7.0.117
  [Host]     : .NET 7.0.17 (7.0.1724.12101), X64 RyuJIT AVX2
  Job-WBMJBZ : .NET 7.0.17 (7.0.1724.12101), X64 RyuJIT AVX2

IterationCount=100  

```
| Method                     | input                | Mean     | Error     | StdDev    | Gen0   | Gen1   | Allocated |
|--------------------------- |--------------------- |---------:|----------:|----------:|-------:|-------:|----------:|
| **UniqueOptionSetsUsingRegex** | **AELH(...)LCJL [2153]** | **7.076 μs** | **0.0571 μs** | **0.1665 μs** | **1.3199** | **0.0534** |  **12.18 KB** |
| **UniqueOptionSetsUsingSpan**  | **BIPV(...)UQZ_ [2162]** | **2.044 μs** | **0.0170 μs** | **0.0490 μs** | **0.3052** |      **-** |   **2.83 KB** |
| **UniqueOptionSetsUsingRegex** | **BLWA(...)ZON_ [2150]** | **6.730 μs** | **0.0475 μs** | **0.1392 μs** | **1.1749** | **0.0458** |  **10.85 KB** |
| **UniqueOptionSetsUsingRegex** | **DYNU(...)FUHT [2153]** | **6.905 μs** | **0.0557 μs** | **0.1632 μs** | **1.3199** | **0.0534** |  **12.18 KB** |
| **UniqueOptionSetsUsingSpan**  | **G_PT(...)ZMHZ [2150]** | **1.819 μs** | **0.0137 μs** | **0.0400 μs** | **0.1945** |      **-** |    **1.8 KB** |
| **UniqueOptionSetsUsingRegex** | **HEE_(...)TZOS [2153]** | **7.066 μs** | **0.1371 μs** | **0.3955 μs** | **1.3199** | **0.0534** |  **12.18 KB** |
| **UniqueOptionSetsUsingSpan**  | **NQNC(...)_ZIJ [2156]** | **1.955 μs** | **0.0213 μs** | **0.0621 μs** | **0.2937** |      **-** |    **2.7 KB** |
| **UniqueOptionSetsUsingSpan**  | **PRQR(...)HNVD [2189]** | **2.335 μs** | **0.0224 μs** | **0.0646 μs** | **0.3662** | **0.0038** |   **3.39 KB** |
| **UniqueOptionSetsUsingSpan**  | **VZNP(...)J_VN [2156]** | **1.975 μs** | **0.0161 μs** | **0.0465 μs** | **0.2937** |      **-** |    **2.7 KB** |
| **UniqueOptionSetsUsingRegex** | **YAPU(...)NOVQ [2171]** | **9.292 μs** | **0.0887 μs** | **0.2603 μs** | **1.6785** | **0.0916** |  **15.51 KB** |
