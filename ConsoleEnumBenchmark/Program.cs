// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");

using BenchmarkDotNet.Running;
using ConsoleEnumBenchmark;


BenchmarkRunner.Run<EnumBenchmarkToString>();
//BenchmarkRunner.Run<EnumBenchmarkFromString>();

