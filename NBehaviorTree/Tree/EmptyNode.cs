using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBehaviorTree.Tree
{
    public class EmptyNode<T> :NodeBase<T>
    {
        public override ExecutionResult Execute()
        {
            return new ExecutionResult();
        }
    }
}
