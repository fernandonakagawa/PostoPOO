using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostoPOO_WF
{
    public partial class FormPainelDeControle : Form
    {
        private Form _formAnterior;
        public FormPainelDeControle(Form formAnterior)
        {
            this._formAnterior = formAnterior;
            InitializeComponent();
        }

        private void btCriarPosto_Click(object sender, EventArgs e)
        {
            _formAnterior.Show();
            this.Hide();
        }
    }
}
