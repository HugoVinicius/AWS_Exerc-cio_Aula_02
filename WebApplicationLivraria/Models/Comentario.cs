using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationLivraria.Models
{
    public class Comentario
    {
        public int CodigoComentari { get; set; }
        public string Descricao { get; set; }
        public Livro LivroComentario { get; set; }
    }
}
