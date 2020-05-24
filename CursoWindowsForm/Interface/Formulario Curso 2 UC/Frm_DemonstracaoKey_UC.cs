using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForm.Interface.Formulario_Curso_2_UC
{
    public partial class Frm_DemonstracaoKey_UC : UserControl
    {
        public Frm_DemonstracaoKey_UC()
        {
            InitializeComponent();
        }

        private void Frm_DemonstracaoKey_UC_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Txt_Input.Text = "";
            Txt_Msg.Text = "";
            Lbl_Upper.Text = "";
            Lbl_Lower.Text = "";
        }

        private void Txt_Input_KeyDown(object sender, KeyEventArgs e)
        {
            Txt_Msg.AppendText("\r\n" + "Pressionei uma tecla:" + "\r\n");
            Txt_Msg.AppendText("\t" + "Pressionei a tecla: " + (int)e.KeyCode + "\r\n");
            Txt_Msg.AppendText("\t" + "O nome da tecla é: " + e.KeyData + "\r\n");
            Lbl_Lower.Text = e.KeyCode.ToString().ToLower();
            Lbl_Upper.Text = e.KeyCode.ToString().ToUpper();
        }
    }
}
