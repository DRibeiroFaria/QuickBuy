﻿namespace QuickBuy.Dominio.Entity
{
    public class Produto :Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            if (Id == 0) {
                AdicionarMensagem("Produto não pode ser nulo");
            }
        }
    }
}
