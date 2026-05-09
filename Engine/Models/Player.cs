using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models
{
    internal class Player
    {
        public  string? Name { get; set; }
        public string? CharacterClass { get; set; }
        public int HitPoints { get; set; }
        public int ExperincePoints { get; set; }
        public int Level { get; set; }
        public int Gold { get; set; }
    }
}
