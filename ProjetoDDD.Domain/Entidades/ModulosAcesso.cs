using System;
using System.Collections.Generic;

namespace ProjetoDDD.Domain.Entidades
{
    public partial class ModulosAcesso
    {
        public ModulosAcesso()
        {
            this.PerfilUsuarios = new List<PerfilUsuario>();
        }

        public int idModulo { get; set; }
        public string nomeModulo { get; set; }
        public string nomeMenuAcesso { get; set; }
        public string urlMenu { get; set; }
        public bool ativo { get; set; }
        public DateTime dataCadastro { get; set; }
        public int idModuloPai { get; set; }
        public virtual ModulosAcesso modulosAcesso { get; set; }
        public virtual ICollection<PerfilUsuario> PerfilUsuarios { get; set; }

    }
}