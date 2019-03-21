using System;
using System.Windows.Forms;

namespace WindowsFormsApp.Empleados
{
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            var empleado = new Empleado();
            empleado.EmpleadoID = Guid.NewGuid();
            empleado.Nombre = textBoxNombre.Text;
            empleado.Edad = (int)numericUpDownEdad.Value;
            try
            {
                EmpleadosDbContext.Add(empleado);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
