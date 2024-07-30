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
    public partial class Frm_Busca : Form
    {
        List<List<string>> _ListaBusca = new List<List<string>>();

        public string idSelect {get;set;}



        public Frm_Busca(List<List<string>> ListaBusca)
        {
            _ListaBusca = ListaBusca;
            InitializeComponent();
            this.Text = "Busca";
            Tls_Principal.Items[0].ToolTipText = "Salvar a seleção";
            Tls_Principal.Items[1].ToolTipText = "Fechar a seleção";
            PreencherLista();
            Lst_Busca.Sorted = true;
        }

        private void PreencherLista()
        {
            Lst_Busca.Items.Clear();

            for(int i = 0; i <= _ListaBusca.Count - 1;i++)
            {
                ItemBox X = new ItemBox();
                X.id = _ListaBusca[i][0];
                X.nome = _ListaBusca[i][1];
                Lst_Busca.Items.Add(X);
                Lst_Busca.Items.Add(_ListaBusca[i][1]);
            }
        }


        private void ApagatoolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Lst_busca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            ItemBox itemSelecionado = (ItemBox)Lst_Busca.Items[Lst_Busca.SelectedIndex];
            idSelect = itemSelecionado.id;
            this.Close();
        }

        class ItemBox
        {
            public string id { get; set; }
            public String nome { get; set; }

            public override string ToString()
            {
                return nome; 
            }

        }
    }
}
