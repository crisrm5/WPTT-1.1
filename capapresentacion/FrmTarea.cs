using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capanegocio;

namespace capapresentacion
{
    public partial class FrmTarea : Form
    {
        public FrmPrincipal frmparent;
        public FrmTarea()
        {
            InitializeComponent();
            mostrartareas();
            ocultarcolumnas();
        }

        private void FrmTarea_Load(object sender, EventArgs e)
        {

        }

        public void mostrartareas()
        {
            this.dataListTareas.DataSource = NTarea.mostrartareas();
           // this.ocultarcolumnas();
           // this.btnEliminarProyecto.Visible = true;
          //  this.lblTotal.Text = "Número de proyectos: " + Convert.ToString(dataListProyectos.Rows.Count);
        }
        
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmparent.lanzarNuevoProyecto(new FrmDetalleTarea());
        }

        private void label_añadir_Click(object sender, EventArgs e)
        {

        }

        private void ocultarcolumnas()
        {
            this.dataListTareas.Columns[0].Visible = false;
            this.dataListTareas.Columns[1].Visible = false;
            //this.dataListProyectos.Columns[1].Visible = false;
           // this.btnEliminarProyecto.Enabled = false;
            //this.cbEliminar.Checked = false;

        }

        private void txtBuscarProyecto_TextChanged(object sender, EventArgs e)
        {
          
                this.buscarTarea(this.txtBuscarTarea.Text);
            
        }

        private void buscarTarea(string texto)
        {
            this.dataListTareas.DataSource = NTarea.buscartarea(texto);
            //this.ocultarcolumnas();
        }

        private void dataListTareas_CellDoubleClick(object sender, EventArgs e)
        {
            FrmDetalleTarea detalleTareas = new FrmDetalleTarea();

            detalleTareas.visualizaDatos(
                Convert.ToString(this.dataListTareas.CurrentRow.Cells["id"].Value),
                Convert.ToString(this.dataListTareas.CurrentRow.Cells["titulo"].Value),
                Convert.ToString(this.dataListTareas.CurrentRow.Cells["descripcion"].Value),
                Convert.ToString(this.dataListTareas.CurrentRow.Cells["aplicacion"].Value),
                Convert.ToString(this.dataListTareas.CurrentRow.Cells["proyecto"].Value),
                Convert.ToString(this.dataListTareas.CurrentRow.Cells["prioridad"].Value),
                Convert.ToString(this.dataListTareas.CurrentRow.Cells["estado"].Value)
                );

            frmparent.lanzarNuevoProyecto(detalleTareas);

            try
            {


            }
            catch (Exception)
            {
                MessageBox.Show("Error en el evento Double click ", "Error en el evento Double click ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
