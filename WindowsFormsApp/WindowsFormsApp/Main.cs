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
            Titulo.Location = new Point(200, 28);
            Titulo.Size = new Size(373, 46);
            Titulo.Text = "Sistema Informatico";
            PictureBox Logo = new PictureBox();
            Logo.ImageLocation = @"Assets\Square150x150Logo.scale-200.png";
            //Application.StartupPath + "\\Assets\\Square150x150Logo.scale-200.png";
            Logo.Location = new Point(240, 94);
            //Logo.Size = new Size(300, 300);
            Logo.SizeMode = PictureBoxSizeMode.AutoSize;


            this.panelMain.Controls.Add(Titulo);
            //this.panelMain.Controls.Add(Logo);
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleados(new Empleados.Index());
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleados.Create Create = new Empleados.Create();
            Create.ShowDialog();
            Empleados(new Empleados.Index());
        }
        private void Empleados(Form f)
        {
            f.TopLevel = false;
            f.AutoScroll = true;
            this.panelMain.Controls.Clear();
            this.panelMain.Controls.Add(f);
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
        }
    }
}
