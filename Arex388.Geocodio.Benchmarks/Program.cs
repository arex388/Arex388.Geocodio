using Arex388.Geocodio.Benchmarks;
using BenchmarkDotNet.Running;

BenchmarkRunner.Run<GeocodeBenchmarks>();
BenchmarkRunner.Run<ReverseGeocodeBenchmarks>();