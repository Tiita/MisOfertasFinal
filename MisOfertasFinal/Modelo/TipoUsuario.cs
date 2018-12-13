using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MisOfertasFinal.Modelo
{
    public class TipoUsuario
    {
        public TipoUsuario()
        {
            this.coleccion_usuarios = new HashSet<Usuario>();
        }

        public decimal id_tipousuario { get; set; }
        public string nombre_tipousuario { get; set; }
        public string descripcion { get; set; }

        public virtual ICollection<Usuario> coleccion_usuarios { get; set; }
    }
}