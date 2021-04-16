using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capadatos;

namespace capanegocio
{
    public class NTarea
    {
        public static DataTable buscartarea(String textobuscar)
        {
            DTarea objeto = new DTarea();
            objeto.Textobuscar = textobuscar;
            return objeto.buscartarea(objeto);
        }

        public static DataTable mostrartareas()
        {
            DTarea objeto = new DTarea();
            return objeto.mostrartarea(objeto);
        }

    }
}
