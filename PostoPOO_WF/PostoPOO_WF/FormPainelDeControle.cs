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
    public partial class FormPainelDeControle : Form
    {
        private Form _formAnterior;
        private PostoCombustivel _posto;
        private List<BombaCombustivel> _bombas;
        public FormPainelDeControle(Form formAnterior, PostoCombustivel posto)
        {
            this._formAnterior = formAnterior;
            this._posto = posto;
            InitializeComponent();

            _bombas = _posto.Bombas;
            foreach(BombaCombustivel b in _bombas)
            {
                ListViewItem listViewItem = new ListViewItem(b.Numero.ToString());
                listViewItem.SubItems.Add(b.Capacidade.ToString());
                listViewItem.SubItems.Add(b.Tipo.ToString());
                lvBombas.Items.Add(listViewItem);
            }
            lbNome.Text = _posto.Nome;
            tbPrecoGasolina.Text = _posto.PrecoGasolina.ToString();
            tbPrecoEtanol.Text = _posto.PrecoEtanol.ToString();
        }

        private void btCriarPosto_Click(object sender, EventArgs e)
        {
            _formAnterior.Show();
            this.Hide();
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
                this._posto.PrecoGasolina = precoGasolina;
                this._posto.PrecoEtanol = precoEtanol;
            }
            catch (Exception exception)
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

        private void btOk_Click(object sender, EventArgs e)
        {
            int numero = -1;
            float quantidade;
            if (cbNumero.Checked)
            {
                numero = (int)nudNumero.Value;
            }
            else
            {
                if(lvBombas.SelectedItems.Count > 0)
                {
                    numero = int.Parse(lvBombas.SelectedItems[0].Text);
                }
                else
                {
                    MessageBox.Show("Selecione a bomba!");
                }
            }
            quantidade = (float)nudQuantidade.Value;
            if (numero != -1)
            {
                Abastecimento a = this._posto.Abastecer(quantidade, numero);
                a.MarcarPago(cbPago.Checked);
                MessageBox.Show("Abastecimento concluído!");
                AdicionarAbastecimento(a);
                AtualizarBombas();
                AtualizarResultados();
            }
        }

        private void AdicionarAbastecimento(Abastecimento a)
        {

            ListViewItem item = new ListViewItem(a.Bomba.Numero.ToString());
            item.SubItems.Add(a.Quantidade.ToString());
            item.SubItems.Add(a.Valor.ToString());
            item.SubItems.Add(a.IsPago.ToString());
            lvAbastecimentos.Items.Add(item);
            
        }
        private void AtualizarBombas()
        {
            foreach(BombaCombustivel b in _posto.Bombas)
            {
                foreach(ListViewItem item in lvBombas.Items)
                {
                    int numeroPosto = b.Numero;
                    int numeroListView = int.Parse(item.SubItems[0].Text);
                    if(numeroPosto == numeroListView)
                    {
                        item.SubItems[1].Text = b.Capacidade.ToString();
                    }
                }
            }
        }

        private void AtualizarResultados()
        {
            float valor = 0;
            foreach(Abastecimento a in _posto.Abastecimentos)
            {
                if (a.IsPago)
                {
                    valor += a.Valor;
                }
            }
            lbResultados.Text = valor.ToString();
        }

        private void lvBombas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbNumero_CheckedChanged(object sender, EventArgs e)
        {
            lbNumero.Enabled = cbNumero.Checked;
            nudNumero.Enabled = cbNumero.Checked;
        }
    }
}
