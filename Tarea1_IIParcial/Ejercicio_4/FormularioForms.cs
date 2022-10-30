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
    public partial class FormularioForms : Form
    {
        public FormularioForms()
        {
            InitializeComponent();
        }
        UsuarioDatos userDatos = new UsuarioDatos();
        private void FormularioForms_Load(object sender, EventArgs e)
        {
            LlenarDataGrid();
        }

        private async void LlenarDataGrid()
        {
            UsuariosDataGridView.DataSource = await userDatos.DevolverListaAsync();
        }
    }
}
