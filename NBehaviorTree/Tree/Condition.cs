using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBehaviorTree.Tree
{
    public class Condition<T> : NodeBase<T>
    {
        private readonly Func<T, bool> _predicate;
        private readonly NodeBase<T> _positive;
        private readonly NodeBase<T> _negative;

        public Condition(Func<T, bool> predicate, NodeBase<T> positive, NodeBase<T> negative)
        {
            _predicate = predicate;
            _positive = positive ?? new EmptyNode<T>();
            _negative = negative ?? new EmptyNode<T>();

        }


        public override ExecutionResult Execute()
        {
            LinkNode(_positive);
            LinkNode(_negative);
            ExecutionResult.ExecutionResults.Add(_predicate(Object) ? _positive.Execute() : _negative.Execute());
            return ExecutionResult;
        }
    }
}
