``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 11 (10.0.22621.1848/22H2/2022Update/SunValley2)
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
.NET SDK=8.0.100-preview.5.23303.2
  [Host]   : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
  .NET 6.0 : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
  .NET 7.0 : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  .NET 8.0 : .NET 8.0.0 (8.0.23.28008), X64 RyuJIT AVX2


```
|              Method |      Job |  Runtime |     Mean |    Error |   StdDev |   Median | Allocated |
|-------------------- |--------- |--------- |---------:|---------:|---------:|---------:|----------:|
| StringContainString | .NET 6.0 | .NET 6.0 | 65.44 ns | 0.307 ns | 0.288 ns | 65.52 ns |         - |
|   SpanContainString | .NET 6.0 | .NET 6.0 | 60.59 ns | 0.144 ns | 0.120 ns | 60.59 ns |         - |
|     SpanContainSpan | .NET 6.0 | .NET 6.0 | 60.92 ns | 0.549 ns | 0.487 ns | 60.71 ns |         - |
| StringContainString | .NET 7.0 | .NET 7.0 | 64.14 ns | 0.423 ns | 0.396 ns | 64.20 ns |         - |
|   SpanContainString | .NET 7.0 | .NET 7.0 | 63.78 ns | 0.177 ns | 0.157 ns | 63.77 ns |         - |
|     SpanContainSpan | .NET 7.0 | .NET 7.0 | 63.22 ns | 0.258 ns | 0.241 ns | 63.13 ns |         - |
| StringContainString | .NET 8.0 | .NET 8.0 | 50.54 ns | 1.001 ns | 2.022 ns | 49.77 ns |         - |
|   SpanContainString | .NET 8.0 | .NET 8.0 | 45.86 ns | 0.176 ns | 0.156 ns | 45.83 ns |         - |
|     SpanContainSpan | .NET 8.0 | .NET 8.0 | 45.33 ns | 0.171 ns | 0.160 ns | 45.29 ns |         - |
