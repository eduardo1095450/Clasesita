using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase1
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Show();
            this.Hide();
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox1.Items.Add(textBox2.Text);
            listBox1.Items.Add(textBox3.Text);
            MessageBox.Show("Bienvenido " + textBox1.Text);
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            listBox1.Items.Clear();
        }
    }
}
