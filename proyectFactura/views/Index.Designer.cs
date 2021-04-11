
using System.Windows.Forms;

namespace proyectFactura
{
    partial class Index
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Enviar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPasword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1346, 618);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Enviar
            // 
            this.Enviar.BackColor = System.Drawing.Color.MidnightBlue;
            this.Enviar.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enviar.ForeColor = System.Drawing.Color.White;
            this.Enviar.Location = new System.Drawing.Point(80, 268);
            this.Enviar.Name = "Enviar";
            this.Enviar.Size = new System.Drawing.Size(145, 40);
            this.Enviar.TabIndex = 5;
            this.Enviar.Text = "Enviar";
            this.Enviar.UseVisualStyleBackColor = false;
            this.Enviar.Click += new System.EventHandler(this.Enviar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(108, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(108, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuario";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 62);
            this.label1.TabIndex = 2;
            this.label1.Text = "Comerssia";
            // 
            // txtPasword
            // 
            this.txtPasword.BackColor = System.Drawing.Color.OldLace;
            this.txtPasword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPasword.Location = new System.Drawing.Point(80, 214);
            this.txtPasword.Name = "txtPasword";
            this.txtPasword.Size = new System.Drawing.Size(145, 20);
            this.txtPasword.TabIndex = 1;
            this.txtPasword.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.OldLace;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.Location = new System.Drawing.Point(80, 119);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(145, 20);
            this.txtUser.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Enviar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtPasword);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtUser);
            this.panel2.Location = new System.Drawing.Point(518, 194);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(313, 337);
            this.panel2.TabIndex = 6;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 642);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Index";
            this.Text = "Aplicacion Prueba - Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Index_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPasword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Enviar;
        private Panel panel2;
    }
}

