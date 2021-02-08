using System;
using System.Collections.Generic;
using System.Text;

namespace Uchet_Material
{
    public class Material
    {
        public int id { get; set; }
        public string name { get; set; }

        public Material(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        override public string ToString() 
        {
            return this.name;
        }
    }
}
