using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBehaviorTree.Tree
{
    public class Action<T> : NodeBase<T>
    {
        private readonly Action<T, ExecutionResult> _action;

        public Action(Action<T,ExecutionResult> action)
        {
            _action = action;
        }

        public override ExecutionResult Execute()
        {
            var executionResult = new ExecutionResult();
            if (_action != null)
                _action(Object,executionResult);
            return executionResult;
        }
    }
}
