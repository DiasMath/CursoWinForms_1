using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CWinForms_1
{
    public partial class Frm_ValidaCPF2 : Form
    {
        public Frm_ValidaCPF2()
        {
            InitializeComponent();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Msk_CPF.Text = "";
        }

        private void Btn_Valida_Click(object sender, EventArgs e)
        {
            string vConteudo;
            vConteudo = Msk_CPF.Text;
            vConteudo = vConteudo.Replace(".", "").Replace("-", "");
            vConteudo = vConteudo.Trim();

            if( vConteudo == "")
            {
                MessageBox.Show("Voce deve digitar um CPF", "Mensagem de Validacao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if( vConteudo.Length != 11)
                {
                    MessageBox.Show("O CPF deve conter 11 digitos", "Mensagem de Validacao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Voce deseja validar o CPF?", "Mensagem de validacao",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bool validaCPF = false;
                        validaCPF = Cls_Uteis.Valida(Msk_CPF.Text);
                        if (validaCPF == true)
                        {
                            MessageBox.Show("CPF VALIDO", "Mensagem de Validacao", MessageBoxButtons.OK, MessageBoxIcon.Information);  
                        }
                        else
                        {
                            MessageBox.Show("CPF INVALIDO", "Mensagem de Validacao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
             }
        }
    }
}
