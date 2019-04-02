using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp.Empleados
{
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();

            FotoBtn.Click += imageClick;
            GuardarBtn.Click += saveClick;
        }
        private void imageClick(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                Foto.ImageLocation = dialog.FileName;
            }
        }
        private void saveClick(object sender, EventArgs e)
        {
            var empleado = new Empleado();
            empleado.EmpleadoID = Guid.NewGuid();
            empleado.Nombre = Nombre.Text;
            empleado.Direccion = Direccion.Text;
            empleado.Edad = (int)Edad.Value;
            empleado.Foto = ImageToByte(Foto.Image);

            EmpleadosDbContext.Add(empleado);
            this.Close();
        }
        public static byte[] ImageToByte(Image file)
        {
            MemoryStream ms = new MemoryStream();
            file.Save(ms, file.RawFormat);
            return ms.ToArray();
        }
    }
}
