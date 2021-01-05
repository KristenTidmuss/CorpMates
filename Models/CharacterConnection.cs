﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EveConnectionFinder.Models
{
    public class CharacterConnection
    {
        public string charName { get; set; }
        public int charID { get; set; }
        public string entityName { get; set; }
        public int entityID { get; set; }
        public DateTime overlapStart { get; set; }
        public DateTime overlapEnd { get; set; }
    }
}
