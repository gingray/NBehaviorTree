using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBehaviorTree.Tree
{
    public class ExecutionResult
    {
        public ExecutionResult()
        {
            ExecutionResults = new List<ExecutionResult>();
        }
        public Status Status { get; set; }
        public List<ExecutionResult> ExecutionResults { get; set; }
    }

    public enum Status
    {
        Success, Failed, Running, Error, Unknown
    }
}
