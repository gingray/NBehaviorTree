using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBehaviorTree.Tree
{
    public class Root<T> :NodeBase<T>
    {
        private readonly NodeBase<T> _rootNode;

        public Root(T item, NodeBase<T> rootNode )
        {
            _rootNode = rootNode;
            Object = item;
        }

        public override ExecutionResult Execute()
        {
            LinkNode(_rootNode);
            return _rootNode.Execute();
        }
    }
}
