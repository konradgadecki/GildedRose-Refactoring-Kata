using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public class ConjuredItem : Item
    {
        protected override int QUALITY_DROP_VALUE { get { return 2; } }
    }
}
