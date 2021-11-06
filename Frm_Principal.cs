using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturacionFront
{
    public partial class Frm_Principal : Form
    {
        private Frm_Login login;
        public Frm_Principal()
        {
            InitializeComponent();
            Desactivar();

        }

        private void Desactivar()
        {
            facturacionToolStripMenuItem.Enabled = false;
            clientesToolStripMenuItem.Enabled = false;
            productosToolStripMenuItem.Enabled = false;
            logoutToolStripMenuItem.Text = "Iniciar Sesion";
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            
           

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login = new Frm_Login();
            login.ShowDialog();
        }
    }
}
