using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoodAI.Core.Configuration;

namespace GoodAI.Modules.Versioning
{
    public class MyConversion: MyBaseConversion
    {
        public override int CurrentVersion
        {
            get { return 1; }
        }
    }
}
