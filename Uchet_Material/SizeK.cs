using System;
using System.Collections.Generic;
using System.Text;

namespace Uchet_Material
{
    public class SizeK
    {
        public int id { get; set; }

        public string name { get; set; }

        public SizeK(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
