using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class E_Componente
    {
        int clave;
        string nombre;
        string marca;
        int stock;
        int categoria;
        int activo;
        int id_usuario;
        public int Clave { get => clave; set => clave = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Marca { get => marca; set => marca = value; }
        public int Stock { get => stock; set => stock = value; }
        public int Categoria { get => categoria; set => categoria = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public int Activo { get => activo; set => activo = value; }
    }
}
