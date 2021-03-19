using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PostoPOO;

namespace PostoPOO_WF
{
    public partial class FormGerenciamentoPosto : Form
    {
        PostoCombustivel posto;
        List<BombaCombustivel> bombas;
        public FormGerenciamentoPosto()
        {
            InitializeComponent();
        }

        private void btAplicarPrecos_Click(object sender, EventArgs e)
        {
            float precoGasolina, precoEtanol;
            try
            {
                precoGasolina = float.Parse(tbPrecoGasolina.Text);
                precoEtanol = float.Parse(tbPrecoEtanol.Text);
                tbPrecoGasolina.Enabled = false;
                tbPrecoEtanol.Enabled = false;
                btAplicarPrecos.Enabled = false;
                btModificar.Enabled = true;
            }
            catch(Exception exception)
            {
                MessageBox.Show("Valores de preços inválidos!");
                tbPrecoGasolina.Text = "";
                tbPrecoEtanol.Text = "";
            }
            
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            tbPrecoGasolina.Enabled = true;
            tbPrecoEtanol.Enabled = true;
            btAplicarPrecos.Enabled = true;
            btModificar.Enabled = false;
        }

        private void btAdicionarBomba_Click(object sender, EventArgs e)
        {
            if(cbTipoCombustivel.Text.Length == 0)
            {
                MessageBox.Show("Selecione o tipo de combustível!");
            }
            else
            {
                int numero = (int)nudNumero.Value;
                float capacidade = (float)nudCapacidade.Value;
                string tipoCombustivel = cbTipoCombustivel.Text;

                bool numeroExistente = false;
                foreach(ListViewItem item in lvBombas.Items)
                {
                    if(int.Parse(item.Text) == numero)
                    {
                        numeroExistente = true;
                        break;
                    }
                }
                if (numeroExistente)
                {
                    MessageBox.Show("Número de bomba já existente!");
                }
                else
                {
                    ListViewItem listViewItem = new ListViewItem(numero.ToString());
                    listViewItem.SubItems.Add(capacidade.ToString());
                    listViewItem.SubItems.Add(tipoCombustivel);
                    lvBombas.Items.Add(listViewItem);
                    nudNumero.Value++;
                }
            }
        }

        private void btRemoverBomba_Click(object sender, EventArgs e)
        {
            if(lvBombas.Items.Count > 0)
            {
                btRemoverBomba.Enabled = false;
                DialogResult resultado = MessageBox.Show("" +
                    "Tem certeza que deseja remover a bomba selecionada?", "Confirme",
                    MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    lvBombas.Items.Remove(lvBombas.SelectedItems[0]);
                    btRemoverBomba.Enabled = false;
                }
            }
        }

        private void lvBombas_ItemActivate(object sender, EventArgs e)
        {
            
        }

        private void lvBombas_SelectedIndexChanged(object sender, EventArgs e)
        {
            btRemoverBomba.Enabled = true;
        }

        private void lvBombas_Leave(object sender, EventArgs e)
        {
            
        }

        private void btCriarPosto_Click(object sender, EventArgs e)
        {
            bool nomePosto = true;
            bool precos = true;
            bool bombas = true;
            if (tbNomePosto.Text.Length == 0)
            {
                nomePosto = false;
                MessageBox.Show("Digite o nome do posto!");
            }
            if (btAplicarPrecos.Enabled)
            {
                precos = false;
                MessageBox.Show("Aplique os preços dos combustíveis!");
            }
            if(lvBombas.Items.Count <= 0)
            {
                bombas = false;
                MessageBox.Show("Adicione pelo menos uma bomba ao posto!");
            }
            if(nomePosto && precos && bombas)
            {
                if(posto == null || bombas == null)
                {
                    string nome = tbNomePosto.Text;
                    this.bombas = new List<BombaCombustivel>();
                    float precoGasolina = float.Parse(tbPrecoGasolina.Text);
                    float precoEtanol = float.Parse(tbPrecoEtanol.Text);
                    foreach (ListViewItem item in lvBombas.Items)
                    {
                        int num = int.Parse(item.Text);
                        float capacidade = float.Parse(item.SubItems[1].Text);
                        string sTipo = item.SubItems[2].Text;
                        TipoCombustivel tipo;
                        if (sTipo.Equals("Gasolina")) tipo = TipoCombustivel.Gasolina;
                        else tipo = TipoCombustivel.Etanol;
                        BombaCombustivel b = new BombaCombustivel(num, tipo, capacidade);
                        this.bombas.Add(b);
                    }

                    this.posto = new PostoCombustivel(nome, this.bombas, precoGasolina, precoEtanol);
                }

                FormPainelDeControle formPainelDeControle = new FormPainelDeControle(this, this.posto);
                formPainelDeControle.Show();
                this.Hide();
            }
                
        }
    }
}
