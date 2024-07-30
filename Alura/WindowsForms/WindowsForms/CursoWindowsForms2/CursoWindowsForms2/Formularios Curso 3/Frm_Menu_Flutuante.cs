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
    public partial class Frm_Menu_Flutuante : Form
    {
        public Frm_Menu_Flutuante()
        {
            InitializeComponent();
        }

        private void Frm_Menu_Flutuante_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                var PosicaoX= e.X;
                var PosicaoY= e.Y;


                //MessageBox.Show("cliquei o botao da direita do mouse. A posição relativa foi (" + PosicaoX.ToString()+ " , " + PosicaoY + ")" );
            
                var ContextMenu = new  ContextMenuStrip();
                var vToolTip001 = DesenhaItemMenu("item do menu 1", "key");
                var vToolTip002 = DesenhaItemMenu("item do menu 2", "Frm_ValidaSenha");

                ContextMenu.Items.Add(vToolTip001);
                ContextMenu.Items.Add(vToolTip002);

                ContextMenu.Show(this, new Point(PosicaoX, PosicaoY));
                vToolTip001.Click += new System.EventHandler(vToolTip001_Click);
                vToolTip002.Click += new System.EventHandler(vToolTip002_Click);


            }


            void vToolTip001_Click(object sender1, EventArgs e1)
            {
                MessageBox.Show("selecionei a opçaõ do menu 001");
            }

            void vToolTip002_Click(object sender1, EventArgs e1)
            {
                MessageBox.Show("selecionei a opçaõ do menu 0002");
            }


            ToolStripMenuItem DesenhaItemMenu(string text, string nomeImagem)
            {
                var vToolTip= new ToolStripMenuItem();
                vToolTip.Text = text;
                

                Image MyImage = (Image)global::CursoWindowsForms2.Properties.Resources.ResourceManager.GetObject(nomeImagem);
                vToolTip.Image = MyImage;

                return vToolTip;
            }

        }
    }
}
