using System;
using System.Reflection;
using Mapster;
using TestMapsterCodeGen.Client.Store;
using TestMapsterCodeGen.Contracts;

namespace TestMapsterCodeGen.Client;

/// <summary>
/// This is needed to enable the mapping of immutable types.
/// </summary>
public partial class MappingRegister : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.EnableImmutableMapping();
        MyStore.AddMyStoreMappings(config);
    }
}

/// <summary>
/// This is needed to tell mapster what to generate with the codegen tool.
/// </summary>
public class MappingCodeGenRegister : ICodeGenerationRegister
{
    public void Register(CodeGenerationConfig config)
    {
        // ask mapster to scan the assemblies and generate mappers for all types in the specified namespaces
        config.GenerateMapper("[name]Mapper")
            .ForAllTypesInNamespace(Assembly.GetExecutingAssembly(), "TestMapsterCodeGen.Client.Models")
            .ForAllTypesInNamespace(nameof(MyContract).GetType().Assembly, "TestMapsterCodeGen.Contracts");
    }
}