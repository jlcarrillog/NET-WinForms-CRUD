using System;
using System.Windows.Forms;

namespace WindowsFormsApp.Empleados
{
    public partial class Edit : Form
    {
        Empleado data;
        public Edit(Guid Id)
        {
            InitializeComponent();
            data = EmpleadosDbContext.Find(Id);
            textBoxID.Text = data.EmpleadoID.ToString();
            textBoxNombre.Text = data.Nombre;
            numericUpDownEdad.Value = data.Edad;
        }
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            var empleado = new Empleado();
            empleado.EmpleadoID = Guid.NewGuid();
            empleado.Nombre = textBoxNombre.Text;
            empleado.Edad = (int)numericUpDownEdad.Value;

            EmpleadosDbContext.Update(data.EmpleadoID, empleado);
            MessageBox.Show("Editado");
            this.Close();
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("¿Eliminar?", "Eliminar", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                EmpleadosDbContext.Remove(data.EmpleadoID);
                MessageBox.Show("Borrado");
                this.Close();
            }
        }
    }
}
