﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XGameDomain.Entities
{
    class MeusJogos
    {
        public Guid Id { get; set; }
        public JogoPlataforma JogoPlataforma { get; set; }
        public bool Desejo { get; set; }
        public DateTime DataDesejo { get; set; }
        public bool Troco { get; set; }
        public bool Vendo { get; set; }
        
    }
}
