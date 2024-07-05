
namespace PIDETEC
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbAcceso = new System.Windows.Forms.GroupBox();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.invitado = new System.Windows.Forms.CheckBox();
            this.gbAcceso.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAcceso
            // 
            this.gbAcceso.BackColor = System.Drawing.Color.White;
            this.gbAcceso.Controls.Add(this.textUsuario);
            this.gbAcceso.Controls.Add(this.btnCancelar);
            this.gbAcceso.Controls.Add(this.btnAceptar);
            this.gbAcceso.Controls.Add(this.invitado);
            this.gbAcceso.Location = new System.Drawing.Point(0, 0);
            this.gbAcceso.Name = "gbAcceso";
            this.gbAcceso.Size = new System.Drawing.Size(355, 189);
            this.gbAcceso.TabIndex = 1;
            this.gbAcceso.TabStop = false;
            this.gbAcceso.Text = "Acceso";
            // 
            // textUsuario
            // 
            this.textUsuario.ForeColor = System.Drawing.Color.Gray;
            this.textUsuario.Location = new System.Drawing.Point(25, 19);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(291, 20);
            this.textUsuario.TabIndex = 4;
            this.textUsuario.Text = "Ingresa Usuario";
            this.textUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textUsuario.Click += new System.EventHandler(this.textUsuario_Click);
            this.textUsuario.TextChanged += new System.EventHandler(this.textUsuario_TextChanged);
            this.textUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textUsuario_KeyPress);
            this.textUsuario.Leave += new System.EventHandler(this.textUsuario_Leave);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.BackgroundImage = global::PIDETEC.Properties.Resources.tap;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelar.Location = new System.Drawing.Point(241, 92);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 34);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.White;
            this.btnAceptar.BackgroundImage = global::PIDETEC.Properties.Resources.click;
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAceptar.ForeColor = System.Drawing.Color.Black;
            this.btnAceptar.Location = new System.Drawing.Point(160, 92);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 34);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            this.btnAceptar.MouseLeave += new System.EventHandler(this.btnAceptar_MouseLeave);
            this.btnAceptar.MouseHover += new System.EventHandler(this.btnAceptar_MouseHover);
            // 
            // invitado
            // 
            this.invitado.AutoSize = true;
            this.invitado.Location = new System.Drawing.Point(25, 109);
            this.invitado.Name = "invitado";
            this.invitado.Size = new System.Drawing.Size(64, 17);
            this.invitado.TabIndex = 2;
            this.invitado.Text = "Invitado";
            this.invitado.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 177);
            this.ControlBox = false;
            this.Controls.Add(this.gbAcceso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.gbAcceso.ResumeLayout(false);
            this.gbAcceso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAcceso;
        private System.Windows.Forms.CheckBox invitado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox textUsuario;
    }
}

