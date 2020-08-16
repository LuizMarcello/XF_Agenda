using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using XF_Agenda.Model;

namespace XF_Agenda.Services
{
    public class ContatoService
    {
        public static List<Contato> GetContatos(string criterio = null)
        {
            var listaContatos = new List<Contato>();
            listaContatos.Add(new Contato { Nome = "Macoratti", Email = "macoratti@yahoo.com" });
            listaContatos.Add(new Contato { Nome = "Luiz Marcello", Email = "luizmarcello.vmo@hotmail.com"});
            listaContatos.Add(new Contato { Nome = "Janice Bueno", Email = "janjan@hotmail.com" });

            if (criterio == null)
                return listaContatos;

            return listaContatos.Where(c => c.Nome.Contains(criterio)).ToList();
        }
    }
}
