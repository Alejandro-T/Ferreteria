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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            INVITADO a = new INVITADO();
            a.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int contador = 0;

            if (this.textBoxclave.Text == "alejandro")
            {
                MessageBox.Show("Avisi", "Bienvenido", MessageBoxButtons.OK);
                admin s = new admin();
                s.Show();
                this.Hide();

            }
            else
            {
                contador = contador + 1;
                if (contador == 3)
                {

                    MessageBox.Show("Aviso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
    

