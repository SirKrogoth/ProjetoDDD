using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD.Domain.Entidades
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public int idPerfilUsuario { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public DateTime dataCadastro { get; set; }
        public virtual perfilUsuario PerfilUsuario { get; set; }
    }
}
