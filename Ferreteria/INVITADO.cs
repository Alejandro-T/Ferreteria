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
    public partial class INVITADO : Form
    {
        public INVITADO()
        {
            InitializeComponent();
        }

        private void INVITADO_Load(object sender, EventArgs e)
        {
            //inicia el menu o splash aqui se acivan cosas como el timer o posicion de los paneles.
            Size desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;
            Int32 ancho = (this.Width - panel3.Width) / 2;
            panel3.Location = new Point(ancho, panel3.Location.Y);
            timer1.Enabled=true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            listBox1.Items.Add(textBox1.Text+(" :SKU"));
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult yes1;
            yes1 = MessageBox.Show("¿desea salir?","aviso",MessageBoxButtons.YesNo);

            if (yes1==DialogResult.Yes)
            {
                Application.Exit();
            }
            if(yes1==DialogResult.No)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
    }
}
