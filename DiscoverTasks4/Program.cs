using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using DiscoverTasks;
using System.Security.Cryptography;

using static System.Console;

var config = new DebugInProcessConfig()
				.WithOptions(ConfigOptions.DisableOptimizationsValidator);

BenchmarkRunner.Run<Breakfast>(config);

WriteLine("Hello World!");