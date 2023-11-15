using Mapster;
using TestMapsterCodeGen.Client.Models;
using TestMapsterCodeGen.Contracts;

namespace TestMapsterCodeGen.Client.Store;

public class MyStore
{
    public static void AddMyStoreMappings(TypeAdapterConfig config)
    {
        config
            .NewConfig<MyContract, MyModel>()
            .Map(dest => dest.Values, src => src.SubTypes);
    }
}