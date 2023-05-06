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
    public partial class FormInfoClientes : Form
    {
        public FormInfoClientes()
        {
            InitializeComponent();
        }

        private void FormInfoClientes_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void cbTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectDocument = cbTipoDocumento.SelectedItem.ToString();
        }

        private void cbTipoPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectPerson = cbTipoPersona.SelectedItem.ToString();
        }

        private void cbCodigoTel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectCodeTel = cbCodigoTel.SelectedItem.ToString();
        }

        private void FormInfoClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            FormPrincipal formPrincipal = new FormPrincipal();
            formPrincipal.ShowDialog();
        }
    }
}
