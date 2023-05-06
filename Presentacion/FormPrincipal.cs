using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Hide();         
            FormInfoClientes formInfoClientes = new FormInfoClientes();
            formInfoClientes.ShowDialog();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            Hide();
            FormInfoProveedores formInfoProveedores = new FormInfoProveedores();
            formInfoProveedores.ShowDialog();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            Hide();
            FormInventario formInventario = new FormInventario();
            formInventario.ShowDialog();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            Hide();
            FormFactura formFactura = new FormFactura();
            formFactura.ShowDialog();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }
    }
}
