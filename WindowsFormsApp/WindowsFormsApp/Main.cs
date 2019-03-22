using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Label Titulo = new Label();
            Titulo.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            Titulo.Location = new Point(150, 50);
            Titulo.Size = new Size(400, 50);
            Titulo.TextAlign = ContentAlignment.MiddleCenter;
            Titulo.Text = "Sistema Informatico";

            this.panelMain.Controls.Add(Titulo);
        }
        private void Panel(Form f)
        {
            f.TopLevel = false;
            f.AutoScroll = true;
            this.panelMain.Controls.Clear();
            this.panelMain.Controls.Add(f);
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
        }
        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel(new Empleados.Index());
        }
    }
}
