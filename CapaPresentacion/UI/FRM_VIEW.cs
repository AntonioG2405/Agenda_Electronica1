using CapaEntidad;
using CapaNegocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion.UI
{
    public partial class FRM_VIEW : Form
    {
        public FRM_VIEW()
        {
            InitializeComponent();
        }

        CAPA_NEGOCIO objNegocio = new CAPA_NEGOCIO();



        //---------------------------------------------------------------------------------------------------------------------------
        //eventos ENTER y LEAVE para la introduccion de datos
        private void txtBuscarDatos_DGV_Enter(object sender, EventArgs e)
        {
            if (txtBuscarDatos_DGV.Text == "Buscar")
            {
                txtBuscarDatos_DGV.Text = "";
            }
        }

        private void txtBuscarDatos_DGV_Leave(object sender, EventArgs e)
        {
            if (txtBuscarDatos_DGV.Text == "")
            {
                txtBuscarDatos_DGV.Text = "Buscar";
            }
        }

        private void btnBuscarDatos_DGV_MouseHover(object sender, EventArgs e)
        {
            // Aquí defines el mensaje de ayuda que deseas mostrar
            string mensajeAyuda = "Buscar datos.....";

            // Muestra el mensaje de ayuda utilizando un ToolTip
            toolTip1.SetToolTip(btnBuscarDatos_DGV, mensajeAyuda);
        }
        //--------------------------------------------------------------------------------------------------------------------------
       //espacio para los metodos extras de deseño

        public void accionesTabla()
        {
            DGV_Principal.Columns[0].Visible = false;
            DGV_Principal.Columns[1].Width = 120;
            DGV_Principal.Columns[2].Width = 120;
            DGV_Principal.Columns[3].Width = 100;
            DGV_Principal.Columns[4].Width = 400;

            DGV_Principal.ClearSelection();
        }

        private void MostrarInfo()
        {
            DataTable dt = objNegocio.MostrarDatos();
            DGV_Principal.DataSource = dt;
            
        }
        //-------------------------------------------------------------------------------------------------------------------------
        //espacio para las funciones principales

        private void FRM_VIEW_Load(object sender, EventArgs e)
        {
           MostrarInfo();
            accionesTabla();
        }

        private void btnBuscarDatos_DGV_Click(object sender, EventArgs e)
        {
            DGV_Principal.DataSource = objNegocio.Buscar(txtBuscarDatos_DGV.Text);
            txtBuscarDatos_DGV.Text = txtBuscarDatos_DGV.Text.Trim();

        }

        private void btnRerescar_Click(object sender, EventArgs e)
        {
            MostrarInfo();
            accionesTabla();
        }
    }
}
