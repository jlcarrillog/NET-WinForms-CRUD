using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp.Empleados
{
    public partial class Edit : Form
    {
        Empleado data = new Empleado();
        Guid id;
        public Edit(Guid Id)
        {
            InitializeComponent();
            id = Id;
            data = EmpleadosDbContext.Find(Id);
            ID.Text = data.EmpleadoID.ToString();
            Nombre.Text = data.Nombre;
            Direccion.Text = data.Direccion;
            Edad.Value = (int)data.Edad;
            if (data.Foto != null)
            {
                Foto.Image = ByteToImage(data.Foto);
            }

            FotoBtn.Click += imageClick;
            GuardarBtn.Click += saveClick;
        }
        private void imageClick(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Foto.ImageLocation = dialog.FileName;
            }
        }
        private void saveClick(object sender, EventArgs e)
        {
            data.EmpleadoID = Guid.NewGuid();
            data.Nombre = Nombre.Text;
            data.Direccion = Direccion.Text;
            data.Edad = (int)Edad.Value;
            data.Foto = ImageToByte(Foto.Image);

            EmpleadosDbContext.Update(id, data);
            this.Close();
        }
        public static Image ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream(blob);
            return Image.FromStream(mStream);
        }
        public static byte[] ImageToByte(Image file)
        {
            MemoryStream ms = new MemoryStream();
            file.Save(ms, file.RawFormat);
            return ms.ToArray();
        }
    }
}
