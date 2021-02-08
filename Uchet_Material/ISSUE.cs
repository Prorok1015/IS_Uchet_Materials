using System;
using System.Collections.Generic;
using System.Text;

namespace Uchet_Material
{
    public class ISSUE
    {
        public uint id { get; set; }
        public uint quin { get; set; }
        public DateTime date { get; set; }
        public Employeer employeer { get; set; }
        public Material material { get; set; }
        public Taken taken { get; set; }
        public SizeK Size { get; set; }

        public override string ToString()
        {
            return this.material.ToString();
        }
    }
}
