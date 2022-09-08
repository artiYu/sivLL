using System;
using System.Collections.Generic;

namespace SIV
{
    public partial class PokemonsCatalog
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int FirstType { get; set; }
        public int? SecondType { get; set; }
        public int? Evolution { get; set; }
        public int Habitat { get; set; }
    }
}
