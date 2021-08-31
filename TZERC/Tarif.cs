using System;
using System.Collections.Generic;

#nullable disable

namespace TZERC
{
    public partial class Tarif
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double? Tarif1 { get; set; }
        public double? Norma { get; set; }
        public string EdIzm { get; set; }
    }
}
