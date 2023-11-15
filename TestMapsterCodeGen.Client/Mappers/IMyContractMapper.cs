using Mapster;
using TestMapsterCodeGen.Client.Models;
using TestMapsterCodeGen.Contracts;
using MyContract = TestMapsterCodeGen.Contracts.MyContract;

namespace TestMapsterCodeGen.Client.Mappers;

[Mapper]
public interface IMyContractMapper
{
    MyModel Map(MyContract contract);
}
