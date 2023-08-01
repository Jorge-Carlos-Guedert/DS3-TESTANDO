using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testando
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }



        private void usuárioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmUsuario usuario = new FrmUsuario();
            usuario.MdiParent = this;
            usuario.Show();
        }

        private void usuárioToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            FrmListarUsuario frmListar = new FrmListarUsuario();
            frmListar.MdiParent = this;
            frmListar.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
