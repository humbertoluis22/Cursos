using CursoWindowsFormsBiblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms2
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

        private void button1_Click(object sender, EventArgs e)
        {
            string vConteudo;
            vConteudo = Msk_CPF.Text;
            vConteudo = vConteudo.Trim();
            vConteudo = vConteudo.Replace(".", "").Replace("-", "");
            if(vConteudo == "")
            {
                MessageBox.Show("Voce deve digitar um cpf ", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(vConteudo.Length !=11)
                {
                    MessageBox.Show("CPf precisa conter 11 digitos ", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Você deseja validar o CPF? ", "mensagem de validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bool validaCpf = false;
                        validaCpf = Cls_Uteis.Valida(Msk_CPF.Text);
                        if (validaCpf == true)
                        {
                            MessageBox.Show("CPF VALIDO", "Mensagem de validação", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }
                        else
                        {
                            MessageBox.Show("CPF invalido", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }

              
            }
   
            
        }
    }
}
