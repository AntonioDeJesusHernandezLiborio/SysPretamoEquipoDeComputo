using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Entidad;
using System.Data;

namespace Controlador
{
    public class C_Categoria
    {
        M_Categoria modeloCategoria = new M_Categoria();

        public bool insertaCategoria(E_Categoria categoria)
        {
            return modeloCategoria.CategoriaInsertar(categoria);
        }

        public DataTable ConsultarCategoria()
        {
            return modeloCategoria.ConsultarCategoria();
        }

        public bool ActualizarCategoria(E_Categoria categoria)
        {
            return modeloCategoria.CategoriaModificar(categoria);
        }

        public bool EliminarCategoria(E_Categoria categoria)
        {
            return modeloCategoria.CategoriaEliminar(categoria);
        }
    }
}
