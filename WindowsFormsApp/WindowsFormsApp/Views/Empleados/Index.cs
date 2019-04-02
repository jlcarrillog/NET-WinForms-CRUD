using System;
using System.Windows.Forms;

namespace WindowsFormsApp.Empleados
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();

            dataGridViewEmpleados.DataSource = EmpleadosDbContext.ToList();            
            dataGridViewEmpleados.Columns["EmpleadoID"].Visible = false; //Oculta la columna de ID
            dataGridViewEmpleados.Columns["Direccion"].Visible = false; //Oculta la columna de Direccion
            dataGridViewEmpleados.Columns["Edad"].Visible = false; //Oculta la columna de Edad
            dataGridViewEmpleados.Columns["Foto"].Visible = false; //Oculta la columna de Foto


            dataGridViewEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //Selección por renglón            
            dataGridViewEmpleados.CellClick += detailsClick; //Agrega el evento de clic en el renglón

            toolStripButtonNuevo.Click += nuevoClick;
        }
        private void detailsClick(object sender, EventArgs e)
        {
            var d = (Guid)dataGridViewEmpleados.CurrentRow.Cells[0].Value;
            Details editar = new Details(d);
            editar.ShowDialog();

            dataGridViewEmpleados.DataSource = EmpleadosDbContext.ToList();
        }

        private void editarClick(object sender, EventArgs e)
        {
            var d = (Guid)dataGridViewEmpleados.CurrentRow.Cells[0].Value;
            Edit f = new Edit(d);
            f.ShowDialog();

            dataGridViewEmpleados.DataSource = EmpleadosDbContext.ToList();
        }
        private void nuevoClick(object sender, EventArgs e)
        {
            Create Create = new Create();
            Create.ShowDialog();

            dataGridViewEmpleados.DataSource = EmpleadosDbContext.ToList();
        }
    }
}
