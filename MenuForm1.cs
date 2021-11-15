using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2_Deybi_R_Martines
{
    public partial class MenuForm1 : Form
    {
        public MenuForm1()
        {
            InitializeComponent();
        }
        List<Cliente> clienteList = new List<Cliente>();

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Porfavor llenar el espacio en blanco");
                textBox1.Focus();
                return;
            }

            if (textBox2.Text == "")
            {
                errorProvider1.SetError(textBox2, "Porfavor llenar el espacio en blanco");
                textBox2.Focus();
                return;
            }

            if (textBox3.Text == "")
            {
                errorProvider1.SetError(textBox3, "Porfavor llenar el espacio en blanco");
                textBox3.Focus();
                return;
            }

            if (textBox4.Text == "")
            {
                errorProvider1.SetError(textBox4, "Porfavor llenar el espacio en blanco");
                textBox4.Focus();
                return;
            }

            if (textBox5.Text == "")
            {
                errorProvider1.SetError(textBox5, "Porfavor llenar el espacio en blanco");
                textBox5.Focus();
                return;
            }

            if (textBox6.Text == "")
            {
                errorProvider1.SetError(textBox6, "Porfavor llenar el espacio en blanco");
                textBox6.Focus();
                return;
            }

            if (textBox7.Text == "")
            {
                errorProvider1.SetError(textBox7, "Porfavor llenar el espacio en blanco");
                textBox7.Focus();
                return;
            }


            int Total = Convert.ToInt32(textBox4.Text) * Convert.ToInt32(textBox5.Text);
            Cliente _cliente = new Cliente(textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), textBox6.Text, textBox7.Text, Total);

            clienteList.Add(_cliente);

            dataGridView1.DataSource = null;
            DialogResult r = MessageBox.Show(" Esta Seguro de su Tickets", " Equipos y Repuestos Tecnologicos ROY", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                dataGridView1.DataSource = clienteList;
            }

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           dataGridView1.Columns.Clear();
        }
    }
}

