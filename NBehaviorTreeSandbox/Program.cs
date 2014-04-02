using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBehaviorTree.Tree;

namespace NBehaviorTreeSandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataStorage = new DataStorage();
            dataStorage.SomeField = "Ohayo world";
            var execution = new NBehaviorTree.Tree.Action<DataStorage>((f, e) => Console.WriteLine(f.SomeField));
            var cond = new Condition<DataStorage>(p => p.Counter > 3, new NBehaviorTree.Tree.Action<DataStorage>((f, e) => Console.WriteLine("Counter > 3")), null);
            var sequential = new Sequential<DataStorage>(new NodeBase<DataStorage>[] { execution, execution, execution, execution, cond });

            var cond2 = new Condition<DataStorage>(p => p.SomeField.Contains("Oh"), sequential, new NBehaviorTree.Tree.Action<DataStorage>((f, e) => Console.WriteLine("No-No-No")));
            var root = new Root<DataStorage>(dataStorage, cond2);
            root.Execute();
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
