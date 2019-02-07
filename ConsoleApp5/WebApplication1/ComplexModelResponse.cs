using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class ComplexModelResponse
    {
        public float FloatProperty { get; set; }
        public string StringProperty { get; set; }
        public List<string> ListProperty { get; set; }

        public DateTimeOffset DateTimeOffsetProperty { get; set; }
    }
}
