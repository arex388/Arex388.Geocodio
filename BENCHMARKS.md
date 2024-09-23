# Benchmarks

- BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.4894/22H2/2022Update)
- Intel Core i7-4790K CPU 4.00GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
- .NET SDK 8.0.400
  - [Host]     : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  - DefaultJob : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2



#### 2024-09-21 (.NET 8)

###### Geocode

| Method   |     Mean |   Error |   StdDev | Allocated |
| -------- | -------: | ------: | -------: | --------: |
| Multiple | 483.7 ms | 3.64 ms |  5.23 ms |  36.88 KB |
| Single   | 488.9 ms | 9.21 ms | 11.31 ms |  27.43 KB |

###### Reverse Geocode

| Method   |     Mean |   Error |   StdDev | Allocated |
| -------- | -------: | ------: | -------: | --------: |
| Multiple | 489.3 ms | 9.75 ms | 15.18 ms |  34.78 KB |
| Single   | 489.7 ms | 7.61 ms |  8.77 ms |  26.58 KB |