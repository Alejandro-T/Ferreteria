using Ferreteria.administrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            //inicia el menu o splash aqui se acivan cosas como el timer o posicion de los paneles.
            Size desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;
            Int32 ancho = (this.Width - panel2.Width) / 2;
            panel2.Location = new Point(ancho, panel2.Location.Y);
            timer1.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult yes;
            yes =MessageBox.Show("¿Desea sali?","Aviso",MessageBoxButtons.YesNo);      
            if (yes == DialogResult.Yes)
            {
                Application.Exit();
            }

            if (yes == DialogResult.No)
            { }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            agregar F = new agregar();
            F.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            editar k = new editar();
            k.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            clientes c = new clientes();
            c.Show();
        }
    }
}
