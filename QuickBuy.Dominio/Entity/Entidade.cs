using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entity
{
    public abstract class Entidade
    {
        private List<string> _mensagemValidacao { get; set; }
        private List<string> mensagemValicao
        {
            get { return _mensagemValidacao ?? (_mensagemValidacao = new List<string>()); }
        }

        protected void LimpaMensagensValidacao()
        {
            mensagemValicao.Clear();
        }

        protected void AdicionarMensagem(string mensagem)
        {
            mensagemValicao.Add(mensagem);
        }

        public abstract void Validate();
        protected bool isValido 
        {
            get { return !mensagemValicao.Any(); } 
    
        }
    }
}
