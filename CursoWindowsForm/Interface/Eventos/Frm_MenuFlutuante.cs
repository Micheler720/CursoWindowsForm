using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForm
{
    public partial class Frm_MenuFlutuante : Form
    {
        public Frm_MenuFlutuante()
        {
            InitializeComponent();
        }

        private void Frm_MenuFlutuante_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                //var PosicaoX = e.X;
                //var PosicaoY = e.Y;
                //MessageBox.Show($"A posição X: {PosicaoX}, posição Y: {PosicaoY}.", "teste");
                var ContextMenu = new ContextMenuStrip();
                var vToolTip001 = IncluirItemMenu("Menu 1", "folder", "Teste 1", "Teste 2");
                var vToolTip002 = IncluirItemMenu("Menu 2", "folder", "Teste 3", "Teste 4");
                var vToolTip003 = IncluirItemMenu("Menu 3", "folder", "Teste 5", "Teste 6");
                ContextMenu.Items.Add(vToolTip001);
                ContextMenu.Items.Add( vToolTip002);
                ContextMenu.Items.Add(vToolTip003);
                ContextMenu.Show(this, new Point(e.X,e.Y));
                vToolTip001.Click += new EventHandler(vToolTip001_Click);
                vToolTip002.Click += new EventHandler(vToolTip002_Click);
            }
        }
        private void vToolTip001_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selecionei menu 1", "Teste");
        } 
        private void vToolTip002_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selecionei menu 2", "Teste");

        }
        private ToolStripMenuItem IncluirItemMenu(string texto , string nomeImagem ,params string[] menuDropDown)
        {
            var vToolTip = new ToolStripMenuItem();
            vToolTip.Text = texto;
            Image MyImage = (Image)global::CursoWindowsForm.Properties.Resources.ResourceManager.GetObject(nomeImagem);
            vToolTip.Image = MyImage;
            foreach(string menu in menuDropDown)
            {
                vToolTip.DropDownItems.Add(menu);
            }
            return vToolTip;
        }

        private void Frm_MenuFlutuante_Load(object sender, EventArgs e)
        {

        }
    }
}
