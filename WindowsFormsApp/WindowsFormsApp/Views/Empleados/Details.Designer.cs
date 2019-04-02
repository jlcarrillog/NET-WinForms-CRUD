namespace WindowsFormsApp.Empleados
{
    partial class Details
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
            this.TNombre = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.Direccion = new System.Windows.Forms.Label();
            this.TDireccion = new System.Windows.Forms.Label();
            this.Edad = new System.Windows.Forms.Label();
            this.TEdad = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.TId = new System.Windows.Forms.Label();
            this.Foto = new System.Windows.Forms.PictureBox();
            this.EditarBtn = new System.Windows.Forms.Button();
            this.EliminarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Foto)).BeginInit();
            this.SuspendLayout();
            // 
            // TNombre
            // 
            this.TNombre.AutoSize = true;
            this.TNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TNombre.Location = new System.Drawing.Point(195, 69);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(54, 13);
            this.TNombre.TabIndex = 0;
            this.TNombre.Text = "Nombre:";
            this.TNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(250, 69);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(42, 13);
            this.Nombre.TabIndex = 1;
            this.Nombre.Text = "nombre";
            this.Nombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Direccion
            // 
            this.Direccion.AutoSize = true;
            this.Direccion.Location = new System.Drawing.Point(250, 103);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(50, 13);
            this.Direccion.TabIndex = 3;
            this.Direccion.Text = "direccion";
            this.Direccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TDireccion
            // 
            this.TDireccion.AutoSize = true;
            this.TDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TDireccion.Location = new System.Drawing.Point(187, 103);
            this.TDireccion.Name = "TDireccion";
            this.TDireccion.Size = new System.Drawing.Size(65, 13);
            this.TDireccion.TabIndex = 2;
            this.TDireccion.Text = "Dirección:";
            this.TDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Edad
            // 
            this.Edad.AutoSize = true;
            this.Edad.Location = new System.Drawing.Point(250, 138);
            this.Edad.Name = "Edad";
            this.Edad.Size = new System.Drawing.Size(31, 13);
            this.Edad.TabIndex = 5;
            this.Edad.Text = "edad";
            this.Edad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TEdad
            // 
            this.TEdad.AutoSize = true;
            this.TEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEdad.Location = new System.Drawing.Point(207, 138);
            this.TEdad.Name = "TEdad";
            this.TEdad.Size = new System.Drawing.Size(40, 13);
            this.TEdad.TabIndex = 4;
            this.TEdad.Text = "Edad:";
            this.TEdad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(250, 36);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(15, 13);
            this.ID.TabIndex = 7;
            this.ID.Text = "id";
            this.ID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TId
            // 
            this.TId.AutoSize = true;
            this.TId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TId.Location = new System.Drawing.Point(223, 36);
            this.TId.Name = "TId";
            this.TId.Size = new System.Drawing.Size(22, 13);
            this.TId.TabIndex = 6;
            this.TId.Text = "Id:";
            this.TId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Foto
            // 
            this.Foto.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Foto.Location = new System.Drawing.Point(45, 49);
            this.Foto.Name = "Foto";
            this.Foto.Size = new System.Drawing.Size(100, 100);
            this.Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Foto.TabIndex = 8;
            this.Foto.TabStop = false;
            // 
            // EditarBtn
            // 
            this.EditarBtn.Location = new System.Drawing.Point(159, 202);
            this.EditarBtn.Name = "EditarBtn";
            this.EditarBtn.Size = new System.Drawing.Size(75, 23);
            this.EditarBtn.TabIndex = 9;
            this.EditarBtn.Text = "Editar";
            this.EditarBtn.UseVisualStyleBackColor = true;
            // 
            // EliminarBtn
            // 
            this.EliminarBtn.Location = new System.Drawing.Point(253, 202);
            this.EliminarBtn.Name = "EliminarBtn";
            this.EliminarBtn.Size = new System.Drawing.Size(75, 23);
            this.EliminarBtn.TabIndex = 10;
            this.EliminarBtn.Text = "Eliminar";
            this.EliminarBtn.UseVisualStyleBackColor = true;
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 281);
            this.Controls.Add(this.EliminarBtn);
            this.Controls.Add(this.EditarBtn);
            this.Controls.Add(this.Foto);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.TId);
            this.Controls.Add(this.Edad);
            this.Controls.Add(this.TEdad);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.TDireccion);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.TNombre);
            this.Name = "Details";
            this.Text = "Details";
            ((System.ComponentModel.ISupportInitialize)(this.Foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TNombre;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Direccion;
        private System.Windows.Forms.Label TDireccion;
        private System.Windows.Forms.Label Edad;
        private System.Windows.Forms.Label TEdad;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label TId;
        private System.Windows.Forms.PictureBox Foto;
        private System.Windows.Forms.Button EditarBtn;
        private System.Windows.Forms.Button EliminarBtn;
    }
}