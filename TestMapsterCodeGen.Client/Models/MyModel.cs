using System.Collections.Immutable;

namespace TestMapsterCodeGen.Client.Models;

public record MyModel
{
    public string String { get; init; } = "";
    public ImmutableArray<MySubModel> Values { get; init; }
}

public record MySubModel
{
    public string Value { get; init; } = "";
}
