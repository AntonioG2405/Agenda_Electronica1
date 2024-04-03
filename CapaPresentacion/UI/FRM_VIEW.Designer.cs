namespace CapaPresentacion.UI
{
    partial class FRM_VIEW
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_VIEW));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBuscarDatos_DGV = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnBuscarDatos_DGV = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.DGV_Principal = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnRerescar = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarDatos_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Principal)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscarDatos_DGV
            // 
            this.txtBuscarDatos_DGV.BorderRadius = 15;
            this.txtBuscarDatos_DGV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarDatos_DGV.DefaultText = "Buscar";
            this.txtBuscarDatos_DGV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscarDatos_DGV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscarDatos_DGV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarDatos_DGV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarDatos_DGV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarDatos_DGV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscarDatos_DGV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarDatos_DGV.Location = new System.Drawing.Point(364, 30);
            this.txtBuscarDatos_DGV.Name = "txtBuscarDatos_DGV";
            this.txtBuscarDatos_DGV.PasswordChar = '\0';
            this.txtBuscarDatos_DGV.PlaceholderText = "";
            this.txtBuscarDatos_DGV.SelectedText = "";
            this.txtBuscarDatos_DGV.Size = new System.Drawing.Size(325, 35);
            this.txtBuscarDatos_DGV.TabIndex = 1;
            this.txtBuscarDatos_DGV.Enter += new System.EventHandler(this.txtBuscarDatos_DGV_Enter);
            this.txtBuscarDatos_DGV.Leave += new System.EventHandler(this.txtBuscarDatos_DGV_Leave);
            // 
            // btnBuscarDatos_DGV
            // 
            this.btnBuscarDatos_DGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarDatos_DGV.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarDatos_DGV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarDatos_DGV.FillColor = System.Drawing.Color.DarkGray;
            this.btnBuscarDatos_DGV.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarDatos_DGV.Image")));
            this.btnBuscarDatos_DGV.ImageRotate = 0F;
            this.btnBuscarDatos_DGV.Location = new System.Drawing.Point(645, 30);
            this.btnBuscarDatos_DGV.Name = "btnBuscarDatos_DGV";
            this.btnBuscarDatos_DGV.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnBuscarDatos_DGV.Size = new System.Drawing.Size(33, 35);
            this.btnBuscarDatos_DGV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscarDatos_DGV.TabIndex = 2;
            this.btnBuscarDatos_DGV.TabStop = false;
            this.btnBuscarDatos_DGV.UseTransparentBackground = true;
            this.btnBuscarDatos_DGV.Click += new System.EventHandler(this.btnBuscarDatos_DGV_Click);
            this.btnBuscarDatos_DGV.MouseHover += new System.EventHandler(this.btnBuscarDatos_DGV_MouseHover);
            // 
            // DGV_Principal
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGV_Principal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Principal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Principal.ColumnHeadersHeight = 25;
            this.DGV_Principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Principal.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_Principal.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGV_Principal.Location = new System.Drawing.Point(35, 99);
            this.DGV_Principal.Name = "DGV_Principal";
            this.DGV_Principal.RowHeadersVisible = false;
            this.DGV_Principal.Size = new System.Drawing.Size(643, 248);
            this.DGV_Principal.TabIndex = 9;
            this.DGV_Principal.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGV_Principal.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGV_Principal.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGV_Principal.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGV_Principal.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGV_Principal.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGV_Principal.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGV_Principal.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGV_Principal.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGV_Principal.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV_Principal.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGV_Principal.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGV_Principal.ThemeStyle.HeaderStyle.Height = 25;
            this.DGV_Principal.ThemeStyle.ReadOnly = false;
            this.DGV_Principal.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGV_Principal.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGV_Principal.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV_Principal.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGV_Principal.ThemeStyle.RowsStyle.Height = 22;
            this.DGV_Principal.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGV_Principal.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnRerescar
            // 
            this.btnRerescar.Animated = true;
            this.btnRerescar.BackColor = System.Drawing.Color.Transparent;
            this.btnRerescar.BorderRadius = 5;
            this.btnRerescar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnRerescar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRerescar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRerescar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRerescar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRerescar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRerescar.FillColor = System.Drawing.Color.CadetBlue;
            this.btnRerescar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRerescar.ForeColor = System.Drawing.Color.Black;
            this.btnRerescar.Image = ((System.Drawing.Image)(resources.GetObject("btnRerescar.Image")));
            this.btnRerescar.IndicateFocus = true;
            this.btnRerescar.Location = new System.Drawing.Point(570, 71);
            this.btnRerescar.Name = "btnRerescar";
            this.btnRerescar.Size = new System.Drawing.Size(108, 22);
            this.btnRerescar.TabIndex = 10;
            this.btnRerescar.Text = "Refresh";
            this.btnRerescar.UseTransparentBackground = true;
            this.btnRerescar.Click += new System.EventHandler(this.btnRerescar_Click);
            // 
            // FRM_VIEW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(725, 373);
            this.Controls.Add(this.btnRerescar);
            this.Controls.Add(this.DGV_Principal);
            this.Controls.Add(this.btnBuscarDatos_DGV);
            this.Controls.Add(this.txtBuscarDatos_DGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_VIEW";
            this.Opacity = 0.9D;
            this.Text = "FRM_VIEW";
            this.Load += new System.EventHandler(this.FRM_VIEW_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarDatos_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Principal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarDatos_DGV;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btnBuscarDatos_DGV;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private Guna.UI2.WinForms.Guna2DataGridView DGV_Principal;
        private Guna.UI2.WinForms.Guna2Button btnRerescar;
    }
}