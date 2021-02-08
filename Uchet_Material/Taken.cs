using System;
using System.Collections.Generic;
using System.Text;

namespace Uchet_Material
{
    public class Taken
    {
        public int id { get; set; }
        public string FIO { get; set; }

        public Taken(int id, string FIO)
        {
            this.id = id;
            this.FIO = FIO;
        }
        public override string ToString()
        {
            return this.FIO;
        }
    }
}
