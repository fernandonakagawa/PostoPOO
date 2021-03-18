
namespace PostoPOO_WF
{
    partial class FormGerenciamentoPosto
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbNomePosto = new System.Windows.Forms.TextBox();
            this.tbPrecoGasolina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPrecoEtanol = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbBombas = new System.Windows.Forms.GroupBox();
            this.btAplicarPrecos = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTipoCombustivel = new System.Windows.Forms.ComboBox();
            this.nudNumero = new System.Windows.Forms.NumericUpDown();
            this.nudCapacidade = new System.Windows.Forms.NumericUpDown();
            this.btAdicionarBomba = new System.Windows.Forms.Button();
            this.lvBombas = new System.Windows.Forms.ListView();
            this.btRemoverBomba = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btCriarPosto = new System.Windows.Forms.Button();
            this.gbBombas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidade)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do posto:";
            // 
            // tbNomePosto
            // 
            this.tbNomePosto.Location = new System.Drawing.Point(158, 50);
            this.tbNomePosto.MaxLength = 32;
            this.tbNomePosto.Name = "tbNomePosto";
            this.tbNomePosto.Size = new System.Drawing.Size(369, 20);
            this.tbNomePosto.TabIndex = 1;
            // 
            // tbPrecoGasolina
            // 
            this.tbPrecoGasolina.Location = new System.Drawing.Point(158, 90);
            this.tbPrecoGasolina.MaxLength = 32;
            this.tbPrecoGasolina.Name = "tbPrecoGasolina";
            this.tbPrecoGasolina.Size = new System.Drawing.Size(102, 20);
            this.tbPrecoGasolina.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Preço da Gasolina:";
            // 
            // tbPrecoEtanol
            // 
            this.tbPrecoEtanol.Location = new System.Drawing.Point(158, 127);
            this.tbPrecoEtanol.MaxLength = 32;
            this.tbPrecoEtanol.Name = "tbPrecoEtanol";
            this.tbPrecoEtanol.Size = new System.Drawing.Size(102, 20);
            this.tbPrecoEtanol.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Preço do Etanol:";
            // 
            // gbBombas
            // 
            this.gbBombas.Controls.Add(this.btRemoverBomba);
            this.gbBombas.Controls.Add(this.lvBombas);
            this.gbBombas.Controls.Add(this.btAdicionarBomba);
            this.gbBombas.Controls.Add(this.nudCapacidade);
            this.gbBombas.Controls.Add(this.nudNumero);
            this.gbBombas.Controls.Add(this.cbTipoCombustivel);
            this.gbBombas.Controls.Add(this.label6);
            this.gbBombas.Controls.Add(this.label5);
            this.gbBombas.Controls.Add(this.label4);
            this.gbBombas.Location = new System.Drawing.Point(62, 211);
            this.gbBombas.Name = "gbBombas";
            this.gbBombas.Size = new System.Drawing.Size(465, 357);
            this.gbBombas.TabIndex = 6;
            this.gbBombas.TabStop = false;
            this.gbBombas.Text = "Bombas";
            // 
            // btAplicarPrecos
            // 
            this.btAplicarPrecos.Location = new System.Drawing.Point(158, 163);
            this.btAplicarPrecos.Name = "btAplicarPrecos";
            this.btAplicarPrecos.Size = new System.Drawing.Size(102, 23);
            this.btAplicarPrecos.TabIndex = 7;
            this.btAplicarPrecos.Text = "Aplicar Preços";
            this.btAplicarPrecos.UseVisualStyleBackColor = true;
            this.btAplicarPrecos.Click += new System.EventHandler(this.btAplicarPrecos_Click);
            // 
            // btModificar
            // 
            this.btModificar.Enabled = false;
            this.btModificar.Location = new System.Drawing.Point(281, 163);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(102, 23);
            this.btModificar.TabIndex = 8;
            this.btModificar.Text = "Modificar Preços";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo de Combustível:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Número";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Capacidade:";
            // 
            // cbTipoCombustivel
            // 
            this.cbTipoCombustivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoCombustivel.FormattingEnabled = true;
            this.cbTipoCombustivel.Items.AddRange(new object[] {
            "Gasolina",
            "Etanol"});
            this.cbTipoCombustivel.Location = new System.Drawing.Point(131, 105);
            this.cbTipoCombustivel.Name = "cbTipoCombustivel";
            this.cbTipoCombustivel.Size = new System.Drawing.Size(121, 21);
            this.cbTipoCombustivel.TabIndex = 12;
            // 
            // nudNumero
            // 
            this.nudNumero.Location = new System.Drawing.Point(132, 26);
            this.nudNumero.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudNumero.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumero.Name = "nudNumero";
            this.nudNumero.Size = new System.Drawing.Size(120, 20);
            this.nudNumero.TabIndex = 13;
            this.nudNumero.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudCapacidade
            // 
            this.nudCapacidade.DecimalPlaces = 1;
            this.nudCapacidade.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudCapacidade.Location = new System.Drawing.Point(132, 65);
            this.nudCapacidade.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudCapacidade.Name = "nudCapacidade";
            this.nudCapacidade.Size = new System.Drawing.Size(120, 20);
            this.nudCapacidade.TabIndex = 14;
            this.nudCapacidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btAdicionarBomba
            // 
            this.btAdicionarBomba.Location = new System.Drawing.Point(132, 141);
            this.btAdicionarBomba.Name = "btAdicionarBomba";
            this.btAdicionarBomba.Size = new System.Drawing.Size(102, 23);
            this.btAdicionarBomba.TabIndex = 9;
            this.btAdicionarBomba.Text = "Adicionar Bomba";
            this.btAdicionarBomba.UseVisualStyleBackColor = true;
            this.btAdicionarBomba.Click += new System.EventHandler(this.btAdicionarBomba_Click);
            // 
            // lvBombas
            // 
            this.lvBombas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvBombas.FullRowSelect = true;
            this.lvBombas.GridLines = true;
            this.lvBombas.HideSelection = false;
            this.lvBombas.Location = new System.Drawing.Point(7, 170);
            this.lvBombas.Name = "lvBombas";
            this.lvBombas.Size = new System.Drawing.Size(452, 156);
            this.lvBombas.TabIndex = 15;
            this.lvBombas.UseCompatibleStateImageBehavior = false;
            this.lvBombas.View = System.Windows.Forms.View.Details;
            this.lvBombas.ItemActivate += new System.EventHandler(this.lvBombas_ItemActivate);
            this.lvBombas.SelectedIndexChanged += new System.EventHandler(this.lvBombas_SelectedIndexChanged);
            this.lvBombas.Leave += new System.EventHandler(this.lvBombas_Leave);
            // 
            // btRemoverBomba
            // 
            this.btRemoverBomba.Enabled = false;
            this.btRemoverBomba.Location = new System.Drawing.Point(6, 328);
            this.btRemoverBomba.Name = "btRemoverBomba";
            this.btRemoverBomba.Size = new System.Drawing.Size(102, 23);
            this.btRemoverBomba.TabIndex = 16;
            this.btRemoverBomba.Text = "Remover Bomba";
            this.btRemoverBomba.UseVisualStyleBackColor = true;
            this.btRemoverBomba.Click += new System.EventHandler(this.btRemoverBomba_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Número";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Capacidade";
            this.columnHeader2.Width = 81;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tipo de Combustível";
            this.columnHeader3.Width = 303;
            // 
            // btCriarPosto
            // 
            this.btCriarPosto.Location = new System.Drawing.Point(549, 504);
            this.btCriarPosto.Name = "btCriarPosto";
            this.btCriarPosto.Size = new System.Drawing.Size(189, 64);
            this.btCriarPosto.TabIndex = 17;
            this.btCriarPosto.Text = "Criar Posto";
            this.btCriarPosto.UseVisualStyleBackColor = true;
            this.btCriarPosto.Click += new System.EventHandler(this.btCriarPosto_Click);
            // 
            // FormGerenciamentoPosto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 616);
            this.Controls.Add(this.btCriarPosto);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.btAplicarPrecos);
            this.Controls.Add(this.gbBombas);
            this.Controls.Add(this.tbPrecoEtanol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPrecoGasolina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNomePosto);
            this.Controls.Add(this.label1);
            this.Name = "FormGerenciamentoPosto";
            this.Text = "Gerenciamento do Posto";
            this.gbBombas.ResumeLayout(false);
            this.gbBombas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNomePosto;
        private System.Windows.Forms.TextBox tbPrecoGasolina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPrecoEtanol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbBombas;
        private System.Windows.Forms.Button btAplicarPrecos;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.ComboBox cbTipoCombustivel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudNumero;
        private System.Windows.Forms.Button btRemoverBomba;
        private System.Windows.Forms.ListView lvBombas;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btAdicionarBomba;
        private System.Windows.Forms.NumericUpDown nudCapacidade;
        private System.Windows.Forms.Button btCriarPosto;
    }
}

