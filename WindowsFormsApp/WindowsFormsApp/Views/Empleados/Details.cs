using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp.Empleados
{
    public partial class Details : Form
    {
        Empleado data;
        public Details(Guid Id)
        {
            InitializeComponent();

            data = EmpleadosDbContext.Find(Id);
            ID.Text = data.EmpleadoID.ToString();
            Nombre.Text = data.Nombre;
            Edad.Text = data.Edad.ToString();
            if (data.Foto != null)
            {
                Foto.Image = ByteToImage(data.Foto);
            }

            EditarBtn.Click += editClick;
            EliminarBtn.Click += delClick;
        }
        public static Image ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream(blob);
            return Image.FromStream(mStream);
        }
        private void editClick(object sender, EventArgs e)
        {
            var d = data.EmpleadoID;
            Edit f = new Edit(d);
            f.ShowDialog();
            this.Close();
        }
        private void delClick(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("¿Eliminar?", "Eliminar", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                EmpleadosDbContext.Remove(data.EmpleadoID);
                this.Close();
            }
        }
    }
}
