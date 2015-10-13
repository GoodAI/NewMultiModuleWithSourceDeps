using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoodAI.Core.Memory;
using GoodAI.Core.Nodes;
using GoodAI.Core.Task;
using GoodAI.Core.Utils;
using YAXLib;

namespace MyCompany.Modules.NewModuleWithSourceDeps
{
    /// <author>Ann Author</author>
    /// <meta></meta>
    /// <status>TEST</status>
    /// <summary>A summary of the node's function</summary>
    /// <description>A more detailed description.</description>
    public class NewModuleNode : MyWorkingNode
    {
        [MyInputBlock(0)]
        public MyMemoryBlock<float> Input
        {
            get { return GetInput(0); }
        }

        [MyOutputBlock(0)]
        public MyMemoryBlock<float> Output
        {
            get { return GetOutput(0); }
            set { SetOutput(0, value); }
        }

        [MyBrowsable, Category("Parameters")]
        [YAXSerializableField(DefaultValue = true), YAXElementFor("Parameters")]
        public bool ParameterProperty { get; set; }

        public override void UpdateMemoryBlocks()
        {
            Output.Count = 1;
        }

        public NewModuleTask NewModuleTask { get; private set; }
    }

    /// <summary>
    /// The task that pushes the current simulation step into the output block.
    /// </summary>
    public class NewModuleTask : MyTask<NewModuleNode>
    {
        public override void Init(int nGPU)
        {
        }

        public override void Execute()
        {
        }
    }
}
