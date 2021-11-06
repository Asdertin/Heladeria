using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace heladeria
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login();

        }

        private void login()
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formProductos = new FormProductos();
            formProductos.MdiParent = this;
            formProductos.Show();
        }

        private void reporteDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formRVentas = new FormRVentas();
            formRVentas.MdiParent = this;
            formRVentas.Show();
        }

        private void reporteDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formClientes = new FormClientes();
            formClientes.MdiParent = this;
            formClientes.Show();
        }

        private void accesoRapidoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void facturaDeudoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formVentas = new FormVentas();
            formVentas.MdiParent = this;
            formVentas.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            login();
        }

        private void almacenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reporteDeEfectivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formREfectivo = new FormREfectivo();
            formREfectivo.MdiParent = this;
            formREfectivo.Show();
        }

        private void heladeriaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
