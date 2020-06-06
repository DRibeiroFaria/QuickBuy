using QuickBuy.Dominio.ValueObject;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace QuickBuy.Dominio.Entity
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsurarioId { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade{ get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroCompleto { get; set; }
        public int FormaPagamentoID { get; set; }
        public FormaPagamento FormaPagamento{ get; set; }
        public ICollection<ItemPedido> Pedidos { get; set; }

    }
}
