// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using Span;

Console.WriteLine("Hello, World!");
var summary = BenchmarkRunner.Run<ContainTests>();