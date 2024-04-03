using CapaEntidad;
using CapaNegocio;
using Guna.UI2.WinForms.Suite;
using System;
using System.Windows.Forms;
using CapaDatos;
using System.Data;
using System.Web.UI.WebControls;
using System.Collections.ObjectModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;



namespace CapaPresentacion.UI
{
    public partial class FRM_OPTIONS : Form
    {
        public FRM_OPTIONS()
        {
            InitializeComponent();
            
        }

        //llamada de capas global

        CAPA_ENTIDAD objEntidad = new CAPA_ENTIDAD();
        CAPA_NEGOCIO objNegocio = new CAPA_NEGOCIO();

        //----------------------------------------------------------------------------------------------------------------


        //----------------------------------------------------------------------------------------------------------------
        //Evento load...
        private void MostrarInfo()
        {
            DataTable dt = objNegocio.MostrarDatos();
            DGV_Secundario.DataSource = dt;
        }
        private void FRM_OPTIONS_Load(object sender, EventArgs e)
        {
            MostrarInfo();
            accionesTabla();
           
        }
        private void limpiar()
        {
            txtID.Text = "ID";
            txtTitulo.Text = "Titulo";
            txtCategoria.Text = "Categoria";
            txtDescripcion.Text = "Descripcion";
            txtFecha.Text = "YYYY-MM-DD";
        }
        public void accionesTabla()
        {
            DGV_Secundario.Columns[0].Width =80;
            DGV_Secundario.Columns[1].Width = 120;
            DGV_Secundario.Columns[2].Width = 120;
            DGV_Secundario.Columns[3].Width = 100;
            DGV_Secundario.Columns[4].Width = 200;


            DGV_Secundario.ClearSelection();
        }
        

        //-----------------------------------------------------------------------------------------
        //eventos enter y leave
        private void txtTitulo_Enter(object sender, EventArgs e)
        {
            if (txtTitulo.Text == "Titulo")
            {
                txtTitulo.Text = "";
            }
        }

        private void txtTitulo_Leave(object sender, EventArgs e)
        {
            if (txtTitulo.Text == "")
            {
                txtTitulo.Text = "Titulo";
            }
        }

        private void txtCategoria_Enter(object sender, EventArgs e)
        {
            if (txtCategoria.Text == "Categoria")
            {
                txtCategoria.Text = "";
            }
        }

        private void txtCategoria_Leave(object sender, EventArgs e)
        {
            if (txtCategoria.Text == "")
            {
                txtCategoria.Text = "Categoria";
            }
        }

        private void txtDescripcion_Enter(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "Descripcion")
            {
                txtDescripcion.Text = "";
            }
        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "")
            {
                txtDescripcion.Text = "Descripcion";
            }
        }
        private void txtID_Enter(object sender, EventArgs e)
        {
            if (txtID.Text == "ID")
            {
                txtID.Text = "";
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                txtID.Text = "ID";
            }
        }

        private void txtFecha_Enter(object sender, EventArgs e)
        {
            if (txtFecha.Text == "YYYY-MM-DD")
            {
                txtFecha.Text = "";
            }
        }

        private void txtFecha_Leave(object sender, EventArgs e)
        {
            if (txtFecha.Text == "")
            {
                txtFecha.Text = "YYYY-MM-DD";
            }
        }

        private void txtFecha_Enter_1(object sender, EventArgs e)
        {
            if (txtFecha.Text == "YYYY-MM-DD")
            {
                txtFecha.Text = "";
            }
        }

        private void txtFecha_Leave_1(object sender, EventArgs e)
        {
            if (txtFecha.Text == "")
            {
                txtFecha.Text = "YYYY-MM-DD";
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------
        //botones
        //---------------------------------------------------------------------------------------------------------------------------
        private void btnClear_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           CAPA_ENTIDAD objEntidad = new CAPA_ENTIDAD();

            try
            {
                if (true)
                {
                    //objEntidad.ID = txtID.TabIndex;
                    objEntidad.Titulo = txtTitulo.Text.ToUpper();
                    objEntidad.Fecha = txtFecha.Text.ToUpper();
                    objEntidad.Categoria = txtCategoria.Text.ToUpper();
                    objEntidad.Descripcion = txtDescripcion.Text.ToUpper();
                    

                    objNegocio.Agregar_Datos(objEntidad);
                    MostrarInfo();
                    limpiar();

                   
                }
            }
            catch (SqlException ex)
            {

                // Manejar la excepción aquí según tus necesidades
                MessageBox.Show("Error de base de datos: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
            objEntidad.ID = Convert.ToInt32(DGV_Secundario.SelectedRows[0].Cells["ID"].Value);
            objEntidad.Titulo = txtTitulo.Text;
            objEntidad.Fecha = txtFecha.Text;
            objEntidad.Categoria = txtCategoria.Text;
            objEntidad.Descripcion = txtDescripcion.Text;

            objNegocio.Editar_Datos(objEntidad);
            MostrarInfo();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGV_Secundario.SelectedRows.Count > 0)
                {
                    // Obtener los datos editados desde los TextBoxes
                    objEntidad.ID = Convert.ToInt32(DGV_Secundario.SelectedRows[0].Cells["ID"].Value);
                    objEntidad.Titulo = txtTitulo.Text.ToUpper();
                    objEntidad.Fecha = txtFecha.Text.ToUpper();
                    objEntidad.Categoria = txtCategoria.Text.ToUpper();
                    objEntidad.Descripcion = txtDescripcion.Text.ToUpper();


                    
                    MessageBox.Show("Registro eliminado correctamente.");
                }
                objNegocio.Eliminar_Datos(objEntidad);
                MostrarInfo();
            }
            catch (SqlException ex)
            {

                // Manejar la excepción aquí según tus necesidades
                MessageBox.Show("Error de base de datos: " + ex.Message);
            }




        }
       

        private void DGV_Secundario_SelectionChanged(object sender, EventArgs e)
        {
            // Al seleccionar una fila en el DataGridView, mostrar los datos en los TextBoxes correspondientes
            if (DGV_Secundario.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DGV_Secundario.SelectedRows[0];
                txtID.Text = selectedRow.Cells["ID"].Value.ToString();
                txtTitulo.Text = selectedRow.Cells["Titulo"].Value.ToString();
                txtFecha.Text = selectedRow.Cells["Fecha"].Value.ToString();
                txtCategoria.Text = selectedRow.Cells["Categoria"].Value.ToString();
                txtDescripcion.Text = selectedRow.Cells["Descripcion"].Value.ToString();
            }
            
        }

        
    }
}
