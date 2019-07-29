using System;


namespace PokemonBattleSim.Models
{
    public class Pokemon
    {
        private int df;
        private int att;

        public int Id { get; set; }
            public String name { get; set; }
            public String type1 { get; set; }
            public String type2 { get; set; }
            public int hp { get; set; }
            public int defense { get; set; }
            public int attack { get; set; }

        public Pokemon() { }

        public Pokemon(int id, string name, string type1, string type2, int hp, int df, int att)
        {
            Id = id;
            this.name = name;
            this.type1 = type1;
            this.type2 = type2;
            this.hp = hp;
            this.df = df;
            this.att = att;
        }
    }
}
