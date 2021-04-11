
using System.Windows.Forms;

namespace proyectFactura.views
{
    partial class principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.notaCreditoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.referenciaToolStripMenuItem,
            this.movimientosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1354, 37);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.BackColor = System.Drawing.Color.Lavender;
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem});
            this.usuarioToolStripMenuItem.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(79, 33);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(180, 34);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.BackColor = System.Drawing.Color.Lavender;
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem,
            this.verToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.clienteToolStripMenuItem.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(73, 33);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(143, 34);
            this.crearToolStripMenuItem.Text = "Crear";
            this.crearToolStripMenuItem.Click += new System.EventHandler(this.crearToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(143, 34);
            this.verToolStripMenuItem.Text = "Ver";
            this.verToolStripMenuItem.Click += new System.EventHandler(this.verToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(143, 34);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // referenciaToolStripMenuItem
            // 
            this.referenciaToolStripMenuItem.BackColor = System.Drawing.Color.Lavender;
            this.referenciaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem1,
            this.verToolStripMenuItem1,
            this.eliminarToolStripMenuItem1});
            this.referenciaToolStripMenuItem.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.referenciaToolStripMenuItem.Name = "referenciaToolStripMenuItem";
            this.referenciaToolStripMenuItem.Size = new System.Drawing.Size(98, 33);
            this.referenciaToolStripMenuItem.Text = "Referencia";
            // 
            // crearToolStripMenuItem1
            // 
            this.crearToolStripMenuItem1.Name = "crearToolStripMenuItem1";
            this.crearToolStripMenuItem1.Size = new System.Drawing.Size(143, 34);
            this.crearToolStripMenuItem1.Text = "Crear";
            this.crearToolStripMenuItem1.Click += new System.EventHandler(this.crearToolStripMenuItem1_Click);
            // 
            // verToolStripMenuItem1
            // 
            this.verToolStripMenuItem1.Name = "verToolStripMenuItem1";
            this.verToolStripMenuItem1.Size = new System.Drawing.Size(143, 34);
            this.verToolStripMenuItem1.Text = "Ver";
            this.verToolStripMenuItem1.Click += new System.EventHandler(this.verToolStripMenuItem1_Click);
            // 
            // eliminarToolStripMenuItem1
            // 
            this.eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1";
            this.eliminarToolStripMenuItem1.Size = new System.Drawing.Size(143, 34);
            this.eliminarToolStripMenuItem1.Text = "Eliminar";
            // 
            // movimientosToolStripMenuItem
            // 
            this.movimientosToolStripMenuItem.BackColor = System.Drawing.Color.Lavender;
            this.movimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturaToolStripMenuItem,
            this.notaCreditoToolStripMenuItem});
            this.movimientosToolStripMenuItem.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movimientosToolStripMenuItem.Name = "movimientosToolStripMenuItem";
            this.movimientosToolStripMenuItem.Size = new System.Drawing.Size(116, 33);
            this.movimientosToolStripMenuItem.Text = "Movimientos";
            // 
            // facturaToolStripMenuItem
            // 
            this.facturaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem2,
            this.verToolStripMenuItem2});
            this.facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            this.facturaToolStripMenuItem.Size = new System.Drawing.Size(180, 34);
            this.facturaToolStripMenuItem.Text = "Factura";
            this.facturaToolStripMenuItem.Click += new System.EventHandler(this.facturaToolStripMenuItem_Click);
            // 
            // crearToolStripMenuItem2
            // 
            this.crearToolStripMenuItem2.Name = "crearToolStripMenuItem2";
            this.crearToolStripMenuItem2.Size = new System.Drawing.Size(180, 34);
            this.crearToolStripMenuItem2.Text = "Crear";
            this.crearToolStripMenuItem2.Click += new System.EventHandler(this.crearToolStripMenuItem2_Click);
            // 
            // verToolStripMenuItem2
            // 
            this.verToolStripMenuItem2.Name = "verToolStripMenuItem2";
            this.verToolStripMenuItem2.Size = new System.Drawing.Size(180, 34);
            this.verToolStripMenuItem2.Text = "Ver";
            // 
            // notaCreditoToolStripMenuItem
            // 
            this.notaCreditoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem3,
            this.verToolStripMenuItem3});
            this.notaCreditoToolStripMenuItem.Name = "notaCreditoToolStripMenuItem";
            this.notaCreditoToolStripMenuItem.Size = new System.Drawing.Size(180, 34);
            this.notaCreditoToolStripMenuItem.Text = "Nota Credito";
            // 
            // crearToolStripMenuItem3
            // 
            this.crearToolStripMenuItem3.Name = "crearToolStripMenuItem3";
            this.crearToolStripMenuItem3.Size = new System.Drawing.Size(124, 34);
            this.crearToolStripMenuItem3.Text = "Crear";
            // 
            // verToolStripMenuItem3
            // 
            this.verToolStripMenuItem3.Name = "verToolStripMenuItem3";
            this.verToolStripMenuItem3.Size = new System.Drawing.Size(124, 34);
            this.verToolStripMenuItem3.Text = "Ver";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(10, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1332, 60);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::proyectFactura.Properties.Resources.grupo;
            this.pictureBox2.Location = new System.Drawing.Point(84, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proyectFactura.Properties.Resources.referencias;
            this.pictureBox1.Location = new System.Drawing.Point(17, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(12, 112);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(115, 20);
            this.txtBusqueda.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 20);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(15, 142);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1327, 493);
            this.webBrowser1.TabIndex = 5;
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1354, 647);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "principal";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem usuarioToolStripMenuItem;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem crearToolStripMenuItem;
        private ToolStripMenuItem verToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem referenciaToolStripMenuItem;
        private ToolStripMenuItem crearToolStripMenuItem1;
        private ToolStripMenuItem verToolStripMenuItem1;
        private ToolStripMenuItem eliminarToolStripMenuItem1;
        private ToolStripMenuItem movimientosToolStripMenuItem;
        private ToolStripMenuItem facturaToolStripMenuItem;
        private ToolStripMenuItem crearToolStripMenuItem2;
        private ToolStripMenuItem verToolStripMenuItem2;
        private ToolStripMenuItem notaCreditoToolStripMenuItem;
        private ToolStripMenuItem crearToolStripMenuItem3;
        private ToolStripMenuItem verToolStripMenuItem3;
        private Panel panel1;
        private TextBox txtBusqueda;
        private Button button1;
        private WebBrowser webBrowser1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}