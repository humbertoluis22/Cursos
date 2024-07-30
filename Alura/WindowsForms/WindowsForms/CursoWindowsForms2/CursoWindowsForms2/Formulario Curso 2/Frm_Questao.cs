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
    public partial class Frm_Questao : Form
    {
        public Frm_Questao(String nomeImagem, string mensagem)
        {
            InitializeComponent();

            Image MyImage = (Image)global::CursoWindowsForms2.Properties.Resources.ResourceManager.GetObject(nomeImagem);
            Pic_Imagem.Image = MyImage;
            Lbl_Questão.Text = mensagem;


        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
