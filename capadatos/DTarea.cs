using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace capadatos
{
    public class DTarea
    {
        private int _id;
        private string _titulo;
        private string _descripcion;
        private string _aplicacion;
        private string _prioridad;
        private string _estado;
        private string _textobuscar;


        public int Id { get => _id; set => _id = value; }
        public string Titulo { get => _titulo; set => _titulo = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string Aplicacion { get => _aplicacion; set => _aplicacion = value; }
        public string Prioridad { get => _prioridad; set => _prioridad = value; }
        public string Estado { get => _estado; set => _estado = value; }

        public string Textobuscar { get => _textobuscar; set => _textobuscar = value; }

        public DTarea()
        {

        }

        public DTarea(int id, string titulo, string descripcion, string aplicacion, string prioridad, string estado, string textobuscar)
        {
            Id = id;
            Titulo = titulo;
            Descripcion = descripcion;
            Aplicacion = aplicacion;
            Prioridad = prioridad;
            Estado = estado;
            Textobuscar = textobuscar;
        }

        public DataTable mostrartarea(DTarea objeto)
        {
            DataTable dtresultado = new DataTable("tareas");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_tareas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqladap = new SqlDataAdapter(SqlCmd);//es el que se encarga de rellenar nuestra tabla con el procedimiento almacenado
                sqladap.Fill(dtresultado);


            }
            catch (Exception)
            {
                dtresultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();

            }

            return dtresultado;
        }


        public DataTable buscartarea(DTarea tarea)
        {
            DataTable dtresultado = new DataTable("tareas");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_tareas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Buscar proyecto por codigo
                SqlParameter ParTextobuscar = new SqlParameter();
                ParTextobuscar.ParameterName = "@textobuscar";
                ParTextobuscar.SqlDbType = SqlDbType.VarChar;
                ParTextobuscar.Size = 10;
                ParTextobuscar.Value = tarea.Textobuscar;
                SqlCmd.Parameters.Add(ParTextobuscar);

                SqlDataAdapter sqladap = new SqlDataAdapter(SqlCmd);
                sqladap.Fill(dtresultado);//es el que se encarga de rellenar nuestra tabla con el procedimiento almacenado


            }
            catch (Exception)
            {
                dtresultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();

            }

            return dtresultado;
        }

    }
}
