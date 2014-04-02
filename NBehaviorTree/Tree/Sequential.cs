using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBehaviorTree.Tree
{
    public class Sequential<T> : NodeBase<T>
    {
        private readonly IEnumerable<NodeBase<T>> _nodes;

        public Sequential(IEnumerable<NodeBase<T>> nodes)
        {
            _nodes = nodes;
        }

        public override ExecutionResult Execute()
        {
            foreach (var nodeBase in _nodes)
            {
                LinkNode(nodeBase);
            }

            foreach (var nodeBase in _nodes)
            {
                ExecutionResult.ExecutionResults.Add(nodeBase.Execute());
            }
            return ExecutionResult;
        }
    }
}
