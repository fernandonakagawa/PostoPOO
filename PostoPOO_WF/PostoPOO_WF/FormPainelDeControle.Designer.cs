
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
            this.btCriarPosto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCriarPosto
            // 
            this.btCriarPosto.Location = new System.Drawing.Point(36, 400);
            this.btCriarPosto.Name = "btCriarPosto";
            this.btCriarPosto.Size = new System.Drawing.Size(75, 23);
            this.btCriarPosto.TabIndex = 0;
            this.btCriarPosto.Text = "Voltar";
            this.btCriarPosto.UseVisualStyleBackColor = true;
            this.btCriarPosto.Click += new System.EventHandler(this.btCriarPosto_Click);
            // 
            // FormPainelDeControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCriarPosto);
            this.Name = "FormPainelDeControle";
            this.Text = "FormPainelDeControle";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCriarPosto;
    }
}