using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoodAI.Core.Memory;
using GoodAI.Core.Nodes;
using GoodAI.Core.Task;
using GoodAI.Core.Utils;

namespace GoodAI.Modules.NewModuleWithSourceDeps
{
    /// <summary>
    /// A node that provides the current simulation step number in the output block.
    /// </summary>
    public class MySimulationStepNode : MyWorkingNode
    {
        [MyOutputBlock(0)]
        public MyMemoryBlock<uint> Output
        {
            get { return GetOutput<uint>(0); }
            set { SetOutput(0, value); }
        }

        public override void UpdateMemoryBlocks()
        {
            // No memory blocks are used in the node.
        }

    }

    /// <summary>
    /// The task that pushes the current simulation step into the output block.
    /// </summary>
    public class MySimulationStepTask : MyTask<MySimulationStepNode>
    {
        public override void Init(int nGPU)
        {
        }

        public override void Execute()
        {
            Owner.Output.Host[0] = SimulationStep;
            Owner.Output.SafeCopyToDevice();
        }
    }
}
