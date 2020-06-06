using QuickBuy.Dominio.ValueObject;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace QuickBuy.Dominio.Entity
{
    public class Pedido : Entidade
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
        public ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validate()
        {
            LimpaMensagensValidacao();
            if (!ItensPedido.Any()) {
                AdicionarMensagem("Pedido não pode estar sem item de pedido!!!");
            }
            if (string.IsNullOrEmpty(CEP)) {
                AdicionarMensagem("CEP deve estar preenchido!!!");
            }
            if (FormaPagamentoID == 0) {
                AdicionarMensagem("Não foi selecionado metodo de pagamento");
            }
        }
    }
}
