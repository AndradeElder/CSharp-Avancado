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
            Descricao = string.Empty;
        }


        public string DefinirSabor(string sabor)
        {
            if (sabor == "c")
            {
                sabor = "Calabresa";
            }
            else if (sabor == "f")
            {
                sabor = "Frango;";
            }
            return sabor;
        }

        public string DefinirTamanho(string tamanho)
        {
            switch (tamanho)
            {
                case "p":
                    {
                        TamanhoDaPizza = TamanhoDaPizza.Pequena;
                        break;
                    }
                case "m":
                    {
                        TamanhoDaPizza = TamanhoDaPizza.Media; 
                        break;
                    }
                case "g":
                    {
                        TamanhoDaPizza = TamanhoDaPizza.Grande;
                        break;
                    }
                default:
                    {
                        throw new Exception("Tamanho não definido");
                    }
            }

            return Enum.GetName(TamanhoDaPizza);
        }

        public override string ToString()
        {
            return $"Sua Pizza é de sabor {Sabor} e tamanho { TamanhoDaPizza}";
        }

    }
}
