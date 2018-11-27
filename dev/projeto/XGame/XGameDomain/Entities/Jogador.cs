using System;

namespace XGameDomain.Entities
{
    public class Jogador
    {
        public Guid Id { get; set; }
        public string  PrimeiroNome { get; set; }
        public string SegundoNome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int Status { get; set; }
    }
}
