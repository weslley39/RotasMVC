using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RotasMVC.Models
{
    public class Noticia
    {
        public int NoticiaID { get; set; }

        public string Titulo { get; set; }

        public string Conteudo { get; set; }

        public string Categoria { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Data { get; set; }

        public IEnumerable<Noticia> TodasAsNoticias()
        {
            var retorno = new Collection<Noticia>
            {
                new Noticia
                {
                    NoticiaID = 1,
                    Categoria = "Esportes",
                    Titulo = "Felipe massa ganha numa",
                    Conteudo = "Numa tarde de chuva Felipe Massa ganha a F1 no Brasil...",
                    Data = new DateTime(2012,7,5)
                },

                 new Noticia
                {
                    NoticiaID = 2,
                    Categoria = "Politica",
                    Titulo = "Presidente assina convenio",
                    Conteudo = "Durante reunião o presidente Ismael Freitas assinou os ocnvênios...",
                    Data = new DateTime(2012,7,3)
                }

        };
            return retorno;
        }
    }
}



