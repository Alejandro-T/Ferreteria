using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria.administrador
{
    public partial class clientes : Form
    {
        public clientes()
        {
            InitializeComponent();
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personasDataSet);

        }

        private void clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'personasDataSet.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.personasDataSet.clientes);
            limpear();

        }
        private void limpear()
        {
            nombreTextBox.Text="";
            apeidoTextBox.Text = "";
            correoTextBox.Text = "";
            telefonoTextBox.Text = "";

        }
        personasDataSet bd = new personasDataSet();
        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
