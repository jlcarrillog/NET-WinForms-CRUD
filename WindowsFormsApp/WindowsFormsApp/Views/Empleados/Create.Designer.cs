namespace WindowsFormsApp.Empleados
{
    partial class Create
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
            this.Nombre = new System.Windows.Forms.TextBox();
            this.TNombre = new System.Windows.Forms.Label();
            this.TEdad = new System.Windows.Forms.Label();
            this.Edad = new System.Windows.Forms.NumericUpDown();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.TDireccion = new System.Windows.Forms.Label();
            this.Direccion = new System.Windows.Forms.TextBox();
            this.FotoBtn = new System.Windows.Forms.Button();
            this.Foto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Edad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Foto)).BeginInit();
            this.SuspendLayout();
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(92, 146);
            this.Nombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(242, 20);
            this.Nombre.TabIndex = 0;
            // 
            // TNombre
            // 
            this.TNombre.AutoSize = true;
            this.TNombre.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TNombre.Location = new System.Drawing.Point(44, 153);
            this.TNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(44, 13);
            this.TNombre.TabIndex = 2;
            this.TNombre.Text = "Nombre";
            // 
            // TEdad
            // 
            this.TEdad.AutoSize = true;
            this.TEdad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TEdad.Location = new System.Drawing.Point(56, 226);
            this.TEdad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TEdad.Name = "TEdad";
            this.TEdad.Size = new System.Drawing.Size(32, 13);
            this.TEdad.TabIndex = 3;
            this.TEdad.Text = "Edad";
            // 
            // Edad
            // 
            this.Edad.Location = new System.Drawing.Point(92, 219);
            this.Edad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Edad.Name = "Edad";
            this.Edad.Size = new System.Drawing.Size(74, 20);
            this.Edad.TabIndex = 4;
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(92, 297);
            this.GuardarBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(62, 23);
            this.GuardarBtn.TabIndex = 5;
            this.GuardarBtn.Text = "Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            // 
            // TDireccion
            // 
            this.TDireccion.AutoSize = true;
            this.TDireccion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TDireccion.Location = new System.Drawing.Point(36, 190);
            this.TDireccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TDireccion.Name = "TDireccion";
            this.TDireccion.Size = new System.Drawing.Size(52, 13);
            this.TDireccion.TabIndex = 7;
            this.TDireccion.Text = "Dirección";
            // 
            // Direccion
            // 
            this.Direccion.Location = new System.Drawing.Point(92, 183);
            this.Direccion.Margin = new System.Windows.Forms.Padding(2);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(242, 20);
            this.Direccion.TabIndex = 6;
            // 
            // FotoBtn
            // 
            this.FotoBtn.Location = new System.Drawing.Point(144, 109);
            this.FotoBtn.Margin = new System.Windows.Forms.Padding(2);
            this.FotoBtn.Name = "FotoBtn";
            this.FotoBtn.Size = new System.Drawing.Size(59, 22);
            this.FotoBtn.TabIndex = 10;
            this.FotoBtn.Text = "Foto";
            this.FotoBtn.UseVisualStyleBackColor = true;
            // 
            // Foto
            // 
            this.Foto.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Foto.Location = new System.Drawing.Point(39, 30);
            this.Foto.Name = "Foto";
            this.Foto.Size = new System.Drawing.Size(100, 100);
            this.Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Foto.TabIndex = 11;
            this.Foto.TabStop = false;
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.Foto);
            this.Controls.Add(this.FotoBtn);
            this.Controls.Add(this.TDireccion);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.Edad);
            this.Controls.Add(this.TEdad);
            this.Controls.Add(this.TNombre);
            this.Controls.Add(this.Nombre);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Create";
            this.Text = "Create";
            ((System.ComponentModel.ISupportInitialize)(this.Edad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label TNombre;
        private System.Windows.Forms.Label TEdad;
        private System.Windows.Forms.NumericUpDown Edad;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.Label TDireccion;
        private System.Windows.Forms.TextBox Direccion;
        private System.Windows.Forms.Button FotoBtn;
        private System.Windows.Forms.PictureBox Foto;
    }
}