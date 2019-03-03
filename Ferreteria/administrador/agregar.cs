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
    public partial class agregar : Form
    {
        public agregar()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            double precio;
            double sku;
            string nombre;
            try
            {
                sku = Convert.ToDouble(textBox3.Text);
                precio = Convert.ToDouble(textBox4.Text);
                nombre = Convert.ToString(textBox2.Text);
            }

            catch (Exception)
            {
                MessageBox.Show("error","error");
                return;
            }
            MessageBox.Show("Producto agregado con exito", "Aviso", MessageBoxButtons.OK);
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
