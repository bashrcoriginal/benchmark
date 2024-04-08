```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.2 LTS (Jammy Jellyfish) WSL
12th Gen Intel Core i7-1260P, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.103
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-OFBNEN : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

IterationCount=100  

```
| Method                     | input                | Mean     | Error     | StdDev    | Gen0   | Gen1   | Allocated |
|--------------------------- |--------------------- |---------:|----------:|----------:|-------:|-------:|----------:|
| **UniqueOptionSetsUsingRegex** | **AH_M(...)TWBZ [2168]** | **7.060 μs** | **0.0835 μs** | **0.2449 μs** | **1.6251** | **0.0839** |  **14.95 KB** |
| **UniqueOptionSetsUsingRegex** | **DPDX(...)IDMG [2153]** | **5.943 μs** | **0.0979 μs** | **0.2776 μs** | **1.3199** | **0.0458** |  **12.18 KB** |
| **UniqueOptionSetsUsingSpan**  | **KDZA(...)JJEL [2159]** | **1.914 μs** | **0.0352 μs** | **0.1003 μs** | **0.2975** |      **-** |   **2.77 KB** |
| **UniqueOptionSetsUsingRegex** | **MPKS(...)HTL_ [2150]** | **5.436 μs** | **0.0790 μs** | **0.2242 μs** | **1.1749** | **0.0458** |  **10.85 KB** |
| **UniqueOptionSetsUsingRegex** | **NK_J(...)RFYM [2168]** | **7.231 μs** | **0.0692 μs** | **0.2019 μs** | **1.6251** | **0.0839** |  **14.95 KB** |
| **UniqueOptionSetsUsingRegex** | **QNAN(...)Z_KE [2174]** | **7.700 μs** | **0.1079 μs** | **0.3164 μs** | **1.7395** | **0.0916** |  **16.03 KB** |
| **UniqueOptionSetsUsingSpan**  | **RFIA(...)JTGN [2153]** | **1.891 μs** | **0.0146 μs** | **0.0427 μs** | **0.2861** |      **-** |   **2.64 KB** |
| **UniqueOptionSetsUsingSpan**  | **RYND(...)HWWH [2168]** | **1.962 μs** | **0.0197 μs** | **0.0566 μs** | **0.3204** |      **-** |   **2.95 KB** |
| **UniqueOptionSetsUsingSpan**  | **sydF(...)ZQIS [2171]** | **1.988 μs** | **0.0230 μs** | **0.0675 μs** | **0.3281** |      **-** |   **3.02 KB** |
| **UniqueOptionSetsUsingSpan**  | **sydG(...)PRBB [2177]** | **1.967 μs** | **0.0173 μs** | **0.0506 μs** | **0.3414** | **0.0019** |   **3.14 KB** |
