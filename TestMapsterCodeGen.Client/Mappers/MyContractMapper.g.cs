using System.Collections.Immutable;
using System.Linq;
using TestMapsterCodeGen.Client.Mappers;
using TestMapsterCodeGen.Client.Models;
using TestMapsterCodeGen.Contracts;

namespace TestMapsterCodeGen.Client.Mappers
{
    public partial class MyContractMapper : IMyContractMapper
    {
        public MyModel Map(MyContract p1)
        {
            return p1 == null ? null : new MyModel()
            {
                String = p1.String,
                Values = p1.SubTypes == null ? default(ImmutableArray<MySubModel>) : ImmutableArray.CreateRange<MySubModel>(p1.SubTypes == null ? null : p1.SubTypes.Select<MyContract.MyContractSubType, MySubModel>(funcMain1))
            };
        }
        
        private MySubModel funcMain1(MyContract.MyContractSubType p2)
        {
            return p2 == null ? null : new MySubModel() {Value = p2.Value};
        }
    }
}