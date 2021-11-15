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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, " Ingrese el Usuario");
                textBox1.Focus();
                return;

            }
            errorProvider1.SetError(textBox1, "");

            if (textBox2.Text == "")
            {
                errorProvider1.SetError(textBox2, " Ingrese la Contraseña");
                textBox2.Focus();
                return;

            }
            errorProvider1.SetError(textBox2, "");

            MenuForm1 formulario = new MenuForm1 ();
            formulario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
