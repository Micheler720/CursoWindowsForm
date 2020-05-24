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
    public partial class Frm_Principal_Menu : Form
    {
        public Frm_Principal_Menu()
        {
            InitializeComponent();
        }

        private void projetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Frm_DemonstracaoKey();
            f.ShowDialog();
        }

        private void progToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Frm_HelloWord();
            f.ShowDialog();
        }

        private void mascáraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Frm_Mascara();
            f.ShowDialog();
        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Frm_ValidaCPF();
            f.ShowDialog();
        }

        private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Frm_ValidaCPF2();
            f.ShowDialog();
        }

        private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Frm_ValidaSenha();
            f.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frm_Principal_Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
