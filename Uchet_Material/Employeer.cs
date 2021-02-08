using System;
using System.Collections.Generic;
using System.Text;

namespace Uchet_Material
{
    public class Employeer
    {
        public int id { get; set; }
        public string FIO { get; set; }
        public string Phone { get; set; }
        public int Position { get; set; }

        public Employeer(int id, string FIO, string Phone, int Position)
        {
            this.id = id;
            this.FIO = FIO;
            this.Phone = Phone;
            this.Position = Position;
        }

        public override string ToString()
        {
            return this.FIO;
        }
    }
}
