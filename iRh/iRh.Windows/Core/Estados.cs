using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    class Estados
    {
    ´  
        public string Nome { get; set; }
        public string sigla { get; set; }

        public List<Estados> ObterTodosEstados()
        {
            var listaDeEstados = new List<Estados>();

            listaDeEstados.Add(new Estados { sigla = "RO", Nome = "Rondônia" });
            listaDeEstados.Add(new Estados { sigla = "AC", Nome = "Acre" });
            listaDeEstados.Add(new Estados { sigla = "ES", Nome = "Espirito Santo" });
            listaDeEstados.Add(new Estados { sigla = "RJ", Nome = "Rio de Janeiro" });
            listaDeEstados.Add(new Estados { sigla = "SP", Nome = "São Paulo" });
            listaDeEstados.Add(new Estados { sigla = "SE", Nome = "Sergipe" });
            listaDeEstados.Add(new Estados { sigla = "BA", Nome = "Bahia" });
            listaDeEstados.Add(new Estados { sigla = "AL", Nome = "Alagoas" });
            listaDeEstados.Add(new Estados { sigla = "MG", Nome = "Minas Gerais" });
            listaDeEstados.Add(new Estados { sigla = "RR", Nome = "Roraima" });
            listaDeEstados.Add(new Estados { sigla = "RN", Nome = "Rio Grande do Norte" });
            listaDeEstados.Add(new Estados { sigla = "RS", Nome = "Rio Grande do Sul" });
            listaDeEstados.Add(new Estados { sigla = "SC", Nome = "Santa Catarina" });
            listaDeEstados.Add(new Estados { sigla = "TO", Nome = "Tocantins" });
            listaDeEstados.Add(new Estados { sigla = "GO", Nome = "Goiás" });
            listaDeEstados.Add(new Estados { sigla = "PI", Nome = "Piaui" });
            listaDeEstados.Add(new Estados { sigla = "PB", Nome = "Paraiba" });
            listaDeEstados.Add(new Estados { sigla = "MS", Nome = "Mato Grosso do Sul" });
            listaDeEstados.Add(new Estados { sigla = "DF", Nome = "Distrito Federal" });
            listaDeEstados.Add(new Estados { sigla = "PA", Nome = "Pará" });
            listaDeEstados.Add(new Estados { sigla = "CE", Nome = "Ceará" });
            listaDeEstados.Add(new Estados { sigla = "PE", Nome = "Pernambuco" });
            listaDeEstados.Add(new Estados { sigla = "RR", Nome = "RORAÍMA" });
            listaDeEstados.Add(new Estados { sigla = "MT", Nome = "Mato Grosso" });
            listaDeEstados.Add(new Estados { sigla = "AM", Nome = "Amazonas" });
            listaDeEstados.Add(new Estados { sigla = "AM", Nome = "Amapá" });
            listaDeEstados.Add(new Estados { sigla = "MA", Nome = "Maranhão" });
            listaDeEstados.Add(new Estados { sigla = "", Nome = "" });
        }
}

           
                

                

