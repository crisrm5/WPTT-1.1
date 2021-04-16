using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capapresentacion
{
    public partial class FrmDetalleTarea : Form
    {
        public FrmDetalleTarea()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
        public void visualizaDatos(string id,string titulo,string descripcion,string aplicacion,string proyecto,string prioridad,string estado)
        {
            txtIdTarea.Text = id;
            txtTituloTarea.Text = titulo;
            txtProyecto.Text = proyecto;
            txtAplicacion.Text = aplicacion;
            txtEstado.Text = estado;
            //txtObservacionesTarea.Text=o
            //txtHoras.Text=



        }


        private void habilitar(bool valor)
        {
            this.txtIdTarea.ReadOnly = true;
            this.txtTituloTarea.ReadOnly = true;
            //this.txtnombre.ReadOnly = !valor;
            //this.txtapellidos.ReadOnly = !valor;
            //this.txtdocumento.ReadOnly = !valor;
            //this.txtdireccion.ReadOnly = !valor;
            //this.cbosexo.Enabled = valor;
            //this.cbotipodocumento.Enabled = valor;
            //this.dtfechanacimiento.Enabled = valor;

        }

        private void txtAplicacion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
