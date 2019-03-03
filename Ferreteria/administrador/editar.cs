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
    public partial class editar : Form
    {
        public editar()
        {
            InitializeComponent();
        }

        private void PictureBoxmodifica(object sender, EventArgs e)
            
        {
            int skum;
       
            try
            {
                skum = Convert.ToInt16(textBoxinsku.Text);
                
            }
            catch (Exception)
            {
                MessageBox.Show("Error","aviso",MessageBoxButtons.OK);
                return;
            }

            MessageBox.Show("Producto modificado","aviso",MessageBoxButtons.OK);

        }

        private void pictureBoxborramo_Click(object sender, EventArgs e)
        {
            textBoxinsku.Clear();
            textBoxnombre.Clear();
            textBoxprecio.Clear();
            textBoxsku.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
