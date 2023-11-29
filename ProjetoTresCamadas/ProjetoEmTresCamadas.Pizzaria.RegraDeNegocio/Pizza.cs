using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEmTresCamadas.Pizzaria.RegraDeNegocio
{
    public enum TamanhoDaPizza
    {
        Pequena = 0,
        Media = 1,
        Grande = 2
    }

    public class Pizza
    {
        public string Sabor { get; set; }
        public TamanhoDaPizza TamanhoDaPizza { get; set; }
        public string Descricao { get; set; }

        public Pizza()
        {
            


        }

        public Pizza CriarPizza(string Sabor, TamanhoDaPizza tamanhoDaPizza, string descricao = "")
        {
            Sabor = Sabor;
            TamanhoDaPizza = tamanhoDaPizza;
            if (string.IsNullOrEmpty(descricao))
            {
                Descricao = descricao;
            }
            return this;
        }
    }
}
