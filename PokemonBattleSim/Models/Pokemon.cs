using System;


namespace PokemonBattleSim.Models
{
    public class Pokemon
    {

            public int Id { get; set; }
            public String name { get; set; }
            public String type1 { get; set; }
            public String type2 { get; set; }
            public int hp { get; set; }
            public int defense { get; set; }
            public int attack { get; set; }
    }
}
