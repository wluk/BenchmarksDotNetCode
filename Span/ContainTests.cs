using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;

namespace Span;

[MemoryDiagnoser]
[SimpleJob(RuntimeMoniker.Net60)]
[SimpleJob(RuntimeMoniker.Net70)]
[SimpleJob(RuntimeMoniker.Net80)]
public class ContainTests
{
    private readonly string command = "CreateApplicationRoleCommand";

    [Benchmark]
    public bool StringContainString() => command.Contains("role", StringComparison.InvariantCultureIgnoreCase);

    [Benchmark]
    public bool SpanContainString() => command.AsSpan().Contains("role", StringComparison.InvariantCultureIgnoreCase);

    [Benchmark]
    public bool SpanContainSpan()
    {
        var role = "role".AsSpan();
        return command.AsSpan().Contains(role, StringComparison.InvariantCultureIgnoreCase);
    }
}
