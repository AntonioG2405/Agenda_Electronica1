using System;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion.UI
{
    public partial class FRM_HOME : Form
    {
        //------------------------------------------------------------------------------------------------------------

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();

        private const int RESIZE_MARGIN = 10; // Márgen de redimensionamiento

        //------------------------------------------------------------------------------------------------------------
        public FRM_HOME()
        {
            InitializeComponent();
            this.customizeDesign();
            this.DoubleBuffered = true;
        
    }

        CAPA_NEGOCIO objNegocio = new CAPA_NEGOCIO();

        //-----------------------------------------------------------------------------------------------------------
        //metodos para los paneles espesificos que se usaran para mover el programa en la pantalla

        //------------------------------------------------------------------------------------------------------------
        //FRM secundarios
        private void OpenSecondForm(object FRMsecond)
        {
            if (this.panelPrincipal.Controls.Count > 0)
                this.panelPrincipal.Controls.RemoveAt(0);
            Form SecondForm = FRMsecond as Form;
            SecondForm.TopLevel = false;
            SecondForm.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(SecondForm);
            this.panelPrincipal.Tag = SecondForm;
            SecondForm.Show();

        }

        //------------------------------------------------------------------------------------------------------------

        //metodos para los botones principales


        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnMin_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }
        //--------------------------------------------------------------------------------------------------
        //metodos para la funcionalidad del subMenu

        private void customizeDesign()
        {
            panelSubMenu.Visible = false;
        }
        private void HideSubMenu()
        {
            if (panelSubMenu.Visible == true)
            {
                panelSubMenu.Visible = false;
            }
        }
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        //--------------------------------------------------------------------------------------------------

        //uso de las funciones del submenu
        private void btnSetings_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenu);
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenSecondForm(new Form1());
            HideSubMenu();

        }
        //------------------------------------------------------------------------------------------------------------

        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            // Verifica si el mouse está en el margen del formulario
           

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panelLateral_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------------
        //BOTONES PARA LLAMAR LOS DEMAS FROMS
        private void btnView_Click(object sender, EventArgs e)
        {
            //my code....
            OpenSecondForm(new FRM_VIEW());
            HideSubMenu();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            //my code....
            OpenSecondForm(new FRM_OPTIONS());
            HideSubMenu();
        }


        private void FRM_HOME_Load(object sender, EventArgs e)
        {
            btnHome_Click(null, e);
        }

      
    }
}










