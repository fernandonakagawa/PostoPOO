
namespace PostoPOO_WF
{
    partial class FormPainelDeControle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btModificar = new System.Windows.Forms.Button();
            this.btAplicarPrecos = new System.Windows.Forms.Button();
            this.tbPrecoEtanol = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPrecoGasolina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbNumero = new System.Windows.Forms.Label();
            this.nudNumero = new System.Windows.Forms.NumericUpDown();
            this.lvBombas = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPago = new System.Windows.Forms.CheckBox();
            this.btOk = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lvAbastecimentos = new System.Windows.Forms.ListView();
            this.cbNumero = new System.Windows.Forms.CheckBox();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbNome = new System.Windows.Forms.Label();
            this.lbResultados = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btModificar);
            this.groupBox1.Controls.Add(this.tbPrecoGasolina);
            this.groupBox1.Controls.Add(this.btAplicarPrecos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbPrecoEtanol);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(429, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 166);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificar Preços";
            // 
            // btModificar
            // 
            this.btModificar.Enabled = false;
            this.btModificar.Location = new System.Drawing.Point(236, 109);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(102, 23);
            this.btModificar.TabIndex = 14;
            this.btModificar.Text = "Modificar Preços";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btAplicarPrecos
            // 
            this.btAplicarPrecos.Location = new System.Drawing.Point(113, 109);
            this.btAplicarPrecos.Name = "btAplicarPrecos";
            this.btAplicarPrecos.Size = new System.Drawing.Size(102, 23);
            this.btAplicarPrecos.TabIndex = 13;
            this.btAplicarPrecos.Text = "Aplicar Preços";
            this.btAplicarPrecos.UseVisualStyleBackColor = true;
            this.btAplicarPrecos.Click += new System.EventHandler(this.btAplicarPrecos_Click);
            // 
            // tbPrecoEtanol
            // 
            this.tbPrecoEtanol.Location = new System.Drawing.Point(113, 73);
            this.tbPrecoEtanol.MaxLength = 32;
            this.tbPrecoEtanol.Name = "tbPrecoEtanol";
            this.tbPrecoEtanol.Size = new System.Drawing.Size(102, 20);
            this.tbPrecoEtanol.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Preço do Etanol:";
            // 
            // tbPrecoGasolina
            // 
            this.tbPrecoGasolina.Location = new System.Drawing.Point(113, 36);
            this.tbPrecoGasolina.MaxLength = 32;
            this.tbPrecoGasolina.Name = "tbPrecoGasolina";
            this.tbPrecoGasolina.Size = new System.Drawing.Size(102, 20);
            this.tbPrecoGasolina.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Preço da Gasolina:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbNumero);
            this.groupBox2.Controls.Add(this.btOk);
            this.groupBox2.Controls.Add(this.cbPago);
            this.groupBox2.Controls.Add(this.nudQuantidade);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lvBombas);
            this.groupBox2.Controls.Add(this.nudNumero);
            this.groupBox2.Controls.Add(this.lbNumero);
            this.groupBox2.Location = new System.Drawing.Point(23, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 468);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Abastecimento";
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Enabled = false;
            this.lbNumero.Location = new System.Drawing.Point(10, 43);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(98, 13);
            this.lbNumero.TabIndex = 15;
            this.lbNumero.Text = "Número da Bomba:";
            // 
            // nudNumero
            // 
            this.nudNumero.Enabled = false;
            this.nudNumero.Location = new System.Drawing.Point(127, 41);
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
            this.nudNumero.Size = new System.Drawing.Size(68, 20);
            this.nudNumero.TabIndex = 17;
            this.nudNumero.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.lvBombas.Location = new System.Drawing.Point(13, 87);
            this.lvBombas.Name = "lvBombas";
            this.lvBombas.Size = new System.Drawing.Size(366, 156);
            this.lvBombas.TabIndex = 18;
            this.lvBombas.UseCompatibleStateImageBehavior = false;
            this.lvBombas.View = System.Windows.Forms.View.Details;
            this.lvBombas.SelectedIndexChanged += new System.EventHandler(this.lvBombas_SelectedIndexChanged);
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
            this.columnHeader3.Width = 179;
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.DecimalPlaces = 2;
            this.nudQuantidade.Location = new System.Drawing.Point(137, 270);
            this.nudQuantidade.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(120, 20);
            this.nudQuantidade.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Quantidade Abastecida:";
            // 
            // cbPago
            // 
            this.cbPago.AutoSize = true;
            this.cbPago.Location = new System.Drawing.Point(13, 308);
            this.cbPago.Name = "cbPago";
            this.cbPago.Size = new System.Drawing.Size(51, 17);
            this.cbPago.TabIndex = 21;
            this.cbPago.Text = "Pago";
            this.cbPago.UseVisualStyleBackColor = true;
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(127, 351);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(102, 49);
            this.btOk.TabIndex = 15;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbResultados);
            this.groupBox3.Controls.Add(this.lvAbastecimentos);
            this.groupBox3.Location = new System.Drawing.Point(430, 219);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(360, 296);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Abastecimentos";
            // 
            // lvAbastecimentos
            // 
            this.lvAbastecimentos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvAbastecimentos.HideSelection = false;
            this.lvAbastecimentos.Location = new System.Drawing.Point(6, 19);
            this.lvAbastecimentos.Name = "lvAbastecimentos";
            this.lvAbastecimentos.Size = new System.Drawing.Size(348, 209);
            this.lvAbastecimentos.TabIndex = 0;
            this.lvAbastecimentos.UseCompatibleStateImageBehavior = false;
            this.lvAbastecimentos.View = System.Windows.Forms.View.Details;
            // 
            // cbNumero
            // 
            this.cbNumero.AutoSize = true;
            this.cbNumero.Location = new System.Drawing.Point(226, 43);
            this.cbNumero.Name = "cbNumero";
            this.cbNumero.Size = new System.Drawing.Size(153, 17);
            this.cbNumero.TabIndex = 22;
            this.cbNumero.Text = "Digitar o número da bomba";
            this.cbNumero.UseVisualStyleBackColor = true;
            this.cbNumero.CheckedChanged += new System.EventHandler(this.cbNumero_CheckedChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "N. Bomba";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Quantidade";
            this.columnHeader5.Width = 106;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Valor";
            this.columnHeader6.Width = 113;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Pago";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(339, -7);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(125, 51);
            this.lbNome.TabIndex = 4;
            this.lbNome.Text = "POSTO";
            this.lbNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbResultados
            // 
            this.lbResultados.AutoSize = true;
            this.lbResultados.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultados.Location = new System.Drawing.Point(6, 246);
            this.lbResultados.Name = "lbResultados";
            this.lbResultados.Size = new System.Drawing.Size(93, 37);
            this.lbResultados.TabIndex = 5;
            this.lbResultados.Text = "POSTO";
            this.lbResultados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormPainelDeControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPainelDeControle";
            this.Text = "FormPainelDeControle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.TextBox tbPrecoGasolina;
        private System.Windows.Forms.Button btAplicarPrecos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPrecoEtanol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.NumericUpDown nudNumero;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvBombas;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.CheckBox cbPago;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lvAbastecimentos;
        private System.Windows.Forms.CheckBox cbNumero;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbResultados;
    }
}