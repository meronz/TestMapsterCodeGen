namespace TestMapsterCodeGen.Contracts;

public record MyContract
{
    public string String { get; init; } = "";
    public MyContractSubType[] SubTypes { get; init; }

    public record MyContractSubType(string Value);
}
