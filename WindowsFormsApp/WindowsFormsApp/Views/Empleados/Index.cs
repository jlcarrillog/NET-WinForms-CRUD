using System;
using System.Windows.Forms;

namespace WindowsFormsApp.Empleados
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();

            try
            {
                dataGridViewEmpleados.DataSource = EmpleadosDbContext.ToList(); ;

                dataGridViewEmpleados.Columns["EmpleadoID"].Visible = false;
                dataGridViewEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridViewEmpleados.CellClick += editarClick;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void editarClick(object sender, EventArgs e)
        {
            var d = (Guid)dataGridViewEmpleados.CurrentRow.Cells[0].Value;
            Edit editar = new Edit(d);
            editar.ShowDialog();
            try
            {
                dataGridViewEmpleados.DataSource = EmpleadosDbContext.ToList(); ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButtonNuevo_Click(object sender, EventArgs e)
        {
            Create Create = new Create();
            Create.ShowDialog();
            try
            {
                dataGridViewEmpleados.DataSource = EmpleadosDbContext.ToList(); ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
