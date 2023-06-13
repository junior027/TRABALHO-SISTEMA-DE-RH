using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    class Estados
    {
    ´   public int Id { get; set; }
        public string Nome { get; set; }
        public string sigla { get; set; }
        public List<Estados> ObterTodosEstados()
        {
            var listaDeEstados = new List<Estados>();

            listaDeEstados.Add(new Estados {
                Id = 11,
                Nome = "Roraima",
                sigla = "RO"
            });
           
               {
            listaDeEstados.Add(new Estados
            {
                Id = 12,
                Nome = "Acre",
                sigla = "AC"
            });
                return listaDeEstados;
}
