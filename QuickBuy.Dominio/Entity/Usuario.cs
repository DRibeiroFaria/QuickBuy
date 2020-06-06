﻿using System.Collections.Generic;

namespace QuickBuy.Dominio.Entity
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set;}
        public string Senha { get; set;}
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email)) {
                AdicionarMensagem("Email não foi introduzido");
            }
            if (string.IsNullOrEmpty(Senha)) {
                AdicionarMensagem("Senha não foi introduzida");
            }
        }
    }
}