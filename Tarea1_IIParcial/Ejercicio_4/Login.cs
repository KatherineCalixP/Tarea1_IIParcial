using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_4
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private async void AceptarButton_Click(object sender, EventArgs e)
        {
            if (CorreoTextBox.Text == String.Empty)
            {
                errorProvider1.SetError(CorreoTextBox, "Ingrese un código de usuario");
                CorreoTextBox.Focus();
                return;
            }
            errorProvider1.Clear();
            if (ContraseniaTextBox.Text == String.Empty)
            {
                errorProvider1.SetError(ContraseniaTextBox, "Ingrese una clave");
                ContraseniaTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            UsuarioDatos userDatos = new UsuarioDatos();

            bool validar = await userDatos.LoginAsync(CorreoTextBox.Text, ContraseniaTextBox.Text);
            if (validar)
            {
                FormularioForms formulario = new FormularioForms();
                Hide();
                formulario.Show();
            }
            else
            {
                MessageBox.Show("Los Datos ingresados son incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
