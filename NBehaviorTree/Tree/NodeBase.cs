using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBehaviorTree.Tree
{
    public abstract class NodeBase<T>
    {
        protected NodeBase()
        {
            ExecutionResult = new ExecutionResult();
        }
        public T Object { get; set; }
        public abstract ExecutionResult Execute();
        public ExecutionResult ExecutionResult;

        protected void LinkNode(NodeBase<T> node)
        {
            node.Object = Object;
        }
    }
}
