﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace CursoWindowsForm.Interface.Formulario_Curso_2_UC
{
    public partial class Frm_ValidaSenha_UC : UserControl
    {
        bool VerSenhaTxt = false;
        public Frm_ValidaSenha_UC()
        {
            InitializeComponent();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Txt_Senha.Text = "";
            Lbl_Resultado.Text = "";
        }

        private void Btn_VerSenha_Click(object sender, EventArgs e)
        {

            if (VerSenhaTxt)
            {
                Txt_Senha.PasswordChar = '*';
                Btn_VerSenha.Text = "Ver Senha";
                VerSenhaTxt = false;
            }
            else
            {
                Txt_Senha.PasswordChar = '\0';
                Btn_VerSenha.Text = "Ocultar Senha";
                VerSenhaTxt = true;
            }
        }

        private void Txt_Senha_KeyDown(object sender, KeyEventArgs e)
        {
            var senha = Txt_Senha.Text;
            var checarSenha = new Cls_Uteis.ChecaForcaSenha();
            var forca = checarSenha.GetForcaDaSenha(senha).ToString();
            Lbl_Resultado.Text = forca;
            if (forca == "Inaceitavel" || forca == "Fraca")
            {
                Lbl_Resultado.ForeColor = Color.Red;
            }
            if (forca == "Aceitavel")
            {
                Lbl_Resultado.ForeColor = Color.Blue;
            }
            if (forca == "Forte" || forca == "Segura")
            {
                Lbl_Resultado.ForeColor = Color.Green;
            }
        }
    }
}
