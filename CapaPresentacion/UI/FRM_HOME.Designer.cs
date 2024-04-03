namespace CapaPresentacion.UI
{
    partial class FRM_HOME
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_HOME));
            this.panelBase = new Guna.UI2.WinForms.Guna2Panel();
            this.panelPrincipal = new Guna.UI2.WinForms.Guna2Panel();
            this.panelSuperior = new Guna.UI2.WinForms.Guna2Panel();
            this.panelBTN = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMin = new Shade.Controls.HopePictureBox();
            this.btnMax = new Shade.Controls.HopePictureBox();
            this.btnClose = new Shade.Controls.HopePictureBox();
            this.panelLateral = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAyuda = new Guna.UI2.WinForms.Guna2Button();
            this.panelSubMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.btnOptions = new Guna.UI2.WinForms.Guna2Button();
            this.btnView = new Guna.UI2.WinForms.Guna2Button();
            this.btnSetings = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new Shade.Controls.Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.hopePictureBox1 = new Shade.Controls.HopePictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelBase.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            this.panelBTN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panelLateral.SuspendLayout();
            this.panelSubMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBase
            // 
            this.panelBase.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelBase.Controls.Add(this.panelPrincipal);
            this.panelBase.Controls.Add(this.panelSuperior);
            this.panelBase.Controls.Add(this.panelLateral);
            this.panelBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBase.Location = new System.Drawing.Point(0, 0);
            this.panelBase.Name = "panelBase";
            this.panelBase.Size = new System.Drawing.Size(871, 433);
            this.panelBase.TabIndex = 0;
//            this.panelBase.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBase_Paint);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPrincipal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelPrincipal.BorderRadius = 50;
            this.panelPrincipal.Location = new System.Drawing.Point(145, 36);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(723, 397);
            this.panelPrincipal.TabIndex = 2;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelSuperior.Controls.Add(this.panelBTN);
            this.panelSuperior.Location = new System.Drawing.Point(145, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(726, 38);
            this.panelSuperior.TabIndex = 1;
//this.panelSuperior.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSuperior_Paint);
            this.panelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseDown);
            // 
            // panelBTN
            // 
            this.panelBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBTN.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelBTN.Controls.Add(this.btnMin);
            this.panelBTN.Controls.Add(this.btnMax);
            this.panelBTN.Controls.Add(this.btnClose);
            this.panelBTN.Location = new System.Drawing.Point(611, 3);
            this.panelBTN.Name = "panelBTN";
            this.panelBTN.Size = new System.Drawing.Size(115, 30);
            this.panelBTN.TabIndex = 2;
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(19, 3);
            this.btnMin.Name = "btnMin";
            this.btnMin.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.btnMin.Size = new System.Drawing.Size(27, 24);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnMin.TabIndex = 5;
            this.btnMin.TabStop = false;
            this.btnMin.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click_1);
            // 
            // btnMax
            // 
            this.btnMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMax.Image = ((System.Drawing.Image)(resources.GetObject("btnMax.Image")));
            this.btnMax.Location = new System.Drawing.Point(52, 3);
            this.btnMax.Name = "btnMax";
            this.btnMax.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.btnMax.Size = new System.Drawing.Size(27, 24);
            this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMax.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnMax.TabIndex = 4;
            this.btnMax.TabStop = false;
            this.btnMax.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(85, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.btnClose.Size = new System.Drawing.Size(27, 24);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnClose.TabIndex = 3;
            this.btnClose.TabStop = false;
            this.btnClose.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelLateral.Controls.Add(this.btnAyuda);
            this.panelLateral.Controls.Add(this.panelSubMenu);
            this.panelLateral.Controls.Add(this.btnSetings);
            this.panelLateral.Controls.Add(this.btnHome);
            this.panelLateral.Controls.Add(this.panel1);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(145, 433);
            this.panelLateral.TabIndex = 0;
            this.panelLateral.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLateral_MouseDown);
            // 
            // btnAyuda
            // 
            this.btnAyuda.Animated = true;
            this.btnAyuda.BackColor = System.Drawing.Color.Transparent;
            this.btnAyuda.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAyuda.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAyuda.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAyuda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAyuda.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAyuda.FillColor = System.Drawing.Color.DimGray;
            this.btnAyuda.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAyuda.ForeColor = System.Drawing.Color.White;
            this.btnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda.Image")));
            this.btnAyuda.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAyuda.IndicateFocus = true;
            this.btnAyuda.Location = new System.Drawing.Point(0, 404);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(145, 29);
            this.btnAyuda.TabIndex = 5;
            this.btnAyuda.Text = "Help";
            this.btnAyuda.UseTransparentBackground = true;
            // 
            // panelSubMenu
            // 
            this.panelSubMenu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelSubMenu.Controls.Add(this.btnOptions);
            this.panelSubMenu.Controls.Add(this.btnView);
            this.panelSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenu.Location = new System.Drawing.Point(0, 204);
            this.panelSubMenu.Name = "panelSubMenu";
            this.panelSubMenu.Size = new System.Drawing.Size(145, 80);
            this.panelSubMenu.TabIndex = 4;
            // 
            // btnOptions
            // 
            this.btnOptions.Animated = true;
            this.btnOptions.BackColor = System.Drawing.Color.Transparent;
            this.btnOptions.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOptions.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOptions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOptions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOptions.FillColor = System.Drawing.Color.DarkGray;
            this.btnOptions.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOptions.ForeColor = System.Drawing.Color.White;
            this.btnOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOptions.Image")));
            this.btnOptions.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnOptions.IndicateFocus = true;
            this.btnOptions.Location = new System.Drawing.Point(0, 36);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(145, 36);
            this.btnOptions.TabIndex = 3;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseTransparentBackground = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnView
            // 
            this.btnView.Animated = true;
            this.btnView.BackColor = System.Drawing.Color.Transparent;
            this.btnView.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnView.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnView.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnView.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnView.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnView.FillColor = System.Drawing.Color.DarkGray;
            this.btnView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnView.IndicateFocus = true;
            this.btnView.Location = new System.Drawing.Point(0, 0);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(145, 36);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "View";
            this.btnView.UseTransparentBackground = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnSetings
            // 
            this.btnSetings.Animated = true;
            this.btnSetings.BackColor = System.Drawing.Color.Transparent;
            this.btnSetings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSetings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSetings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSetings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSetings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetings.FillColor = System.Drawing.Color.DimGray;
            this.btnSetings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSetings.ForeColor = System.Drawing.Color.White;
            this.btnSetings.Image = ((System.Drawing.Image)(resources.GetObject("btnSetings.Image")));
            this.btnSetings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSetings.IndicateFocus = true;
            this.btnSetings.Location = new System.Drawing.Point(0, 168);
            this.btnSetings.Name = "btnSetings";
            this.btnSetings.Size = new System.Drawing.Size(145, 36);
            this.btnSetings.TabIndex = 3;
            this.btnSetings.Text = "Setings";
            this.btnSetings.UseTransparentBackground = true;
            this.btnSetings.Click += new System.EventHandler(this.btnSetings_Click);
            // 
            // btnHome
            // 
            this.btnHome.Animated = true;
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FillColor = System.Drawing.Color.DimGray;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.IndicateFocus = true;
            this.btnHome.Location = new System.Drawing.Point(0, 132);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(145, 36);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseTransparentBackground = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.guna2HtmlLabel1);
            this.panel1.Controls.Add(this.hopePictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(145, 132);
            this.panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel1.TabIndex = 0;
            this.panel1.Text = "panel1";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(38, 87);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(72, 27);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Agenda";
            // 
            // hopePictureBox1
            // 
            this.hopePictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.hopePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("hopePictureBox1.Image")));
            this.hopePictureBox1.Location = new System.Drawing.Point(38, 21);
            this.hopePictureBox1.Name = "hopePictureBox1";
            this.hopePictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.hopePictureBox1.Size = new System.Drawing.Size(71, 60);
            this.hopePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hopePictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.hopePictureBox1.TabIndex = 0;
            this.hopePictureBox1.TabStop = false;
            this.hopePictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            // 
            // FRM_HOME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 433);
            this.Controls.Add(this.panelBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_HOME";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_HOME";
            this.Load += new System.EventHandler(this.FRM_HOME_Load);
            this.panelBase.ResumeLayout(false);
            this.panelSuperior.ResumeLayout(false);
            this.panelBTN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panelLateral.ResumeLayout(false);
            this.panelSubMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelBase;
        private Guna.UI2.WinForms.Guna2Panel panelSuperior;
        private Guna.UI2.WinForms.Guna2Panel panelBTN;
        private Shade.Controls.HopePictureBox btnMin;
        private Shade.Controls.HopePictureBox btnMax;
        private Shade.Controls.HopePictureBox btnClose;
        private Guna.UI2.WinForms.Guna2Panel panelLateral;
        private Guna.UI2.WinForms.Guna2Panel panelSubMenu;
        private Guna.UI2.WinForms.Guna2Button btnOptions;
        private Guna.UI2.WinForms.Guna2Button btnView;
        private Guna.UI2.WinForms.Guna2Button btnSetings;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Shade.Controls.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnAyuda;
        private Guna.UI2.WinForms.Guna2Panel panelPrincipal;
        private Shade.Controls.HopePictureBox hopePictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}