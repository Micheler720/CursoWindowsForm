using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForm
{
    public partial class Frm_Principal_Mdi : Form
    {
        public Frm_Principal_Mdi()
        {
            InitializeComponent();
        }

        private void projetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Frm_DemonstracaoKey();
            f.MdiParent = this;
            f.Show();
        }

        private void progToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Frm_HelloWord();
            f.MdiParent = this;
            f.Show();
        }

        private void mascáraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Frm_Mascara();
            f.MdiParent = this;
            f.Show();
        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Frm_ValidaCPF();
            f.MdiParent = this;
            f.Show();
        }

        private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Frm_ValidaCPF2();
            f.MdiParent = this;
            f.Show();
        }

        private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Frm_ValidaSenha();
            f.MdiParent = this;
            f.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirma = MessageBox.Show("Deseja realmente sair do sistema?", "Messagem aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirma == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }

        private void Frm_Principal_Mdi_Load(object sender, EventArgs e)
        {

        }
    }
}
