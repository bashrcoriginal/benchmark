```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.2 LTS (Jammy Jellyfish) WSL
12th Gen Intel Core i7-1260P, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-NGOMNS : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

IterationCount=100  

```
| Method                     | input                | Mean     | Error     | StdDev    | Gen0   | Gen1   | Allocated |
|--------------------------- |--------------------- |---------:|----------:|----------:|-------:|-------:|----------:|
| **UniqueOptionSetsUsingRegex** | **EVLP(...)ZTAO [2132]** | **3.131 μs** | **0.0611 μs** | **0.1611 μs** | **0.6485** | **0.0114** |   **5.96 KB** |
| **UniqueOptionSetsUsingRegex** | **IOVK(...)UCH_ [2159]** | **5.331 μs** | **0.0495 μs** | **0.1436 μs** | **1.1902** | **0.0458** |  **10.95 KB** |
| **UniqueOptionSetsUsingSpan**  | **OBDU(...)DMY_ [2174]** | **1.982 μs** | **0.0221 μs** | **0.0645 μs** | **0.3319** |      **-** |   **3.08 KB** |
| **UniqueOptionSetsUsingSpan**  | **sydJ(...)ZYRN [2174]** | **1.980 μs** | **0.0241 μs** | **0.0686 μs** | **0.3319** |      **-** |   **3.08 KB** |
| **UniqueOptionSetsUsingRegex** | **sydK(...)IUKR [2177]** | **6.918 μs** | **0.1290 μs** | **0.3531 μs** | **1.4725** | **0.0687** |  **13.57 KB** |
| **UniqueOptionSetsUsingSpan**  | **sydP(...)YUZV [2153]** | **1.851 μs** | **0.0229 μs** | **0.0660 μs** | **0.2861** |      **-** |   **2.64 KB** |
| **UniqueOptionSetsUsingRegex** | **TYQI(...)CRZV [2141]** | **3.785 μs** | **0.0436 μs** | **0.1264 μs** | **0.7858** | **0.0153** |   **7.27 KB** |
| **UniqueOptionSetsUsingSpan**  | **URG_(...)VXVE [2141]** | **1.600 μs** | **0.0150 μs** | **0.0436 μs** | **0.1755** |      **-** |   **1.62 KB** |
| **UniqueOptionSetsUsingRegex** | **XGLJ(...)C_OH [2168]** | **6.351 μs** | **0.0760 μs** | **0.2181 μs** | **1.3275** | **0.0534** |  **12.26 KB** |
| **UniqueOptionSetsUsingSpan**  | **YDVO(...)ZPPF [2150]** | **1.681 μs** | **0.0153 μs** | **0.0433 μs** | **0.1945** |      **-** |    **1.8 KB** |
