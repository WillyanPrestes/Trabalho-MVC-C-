namespace Celular73A.Desktop
{
    partial class frmNovo
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
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.cmbFabricante = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCriar = new System.Windows.Forms.Button();
            this.numDesconto = new System.Windows.Forms.NumericUpDown();
            this.nunQuantidade = new System.Windows.Forms.NumericUpDown();
            this.numPeso = new System.Windows.Forms.NumericUpDown();
            this.nunEspessura = new System.Windows.Forms.NumericUpDown();
            this.nunAltura = new System.Windows.Forms.NumericUpDown();
            this.nunLargura = new System.Windows.Forms.NumericUpDown();
            this.numPreco = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPesott = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numDesconto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nunQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nunEspessura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nunAltura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nunLargura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPreco)).BeginInit();
            this.SuspendLayout();
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(106, 52);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(272, 20);
            this.txtModelo.TabIndex = 16;
            // 
            // cmbFabricante
            // 
            this.cmbFabricante.FormattingEnabled = true;
            this.cmbFabricante.Location = new System.Drawing.Point(106, 83);
            this.cmbFabricante.Name = "cmbFabricante";
            this.cmbFabricante.Size = new System.Drawing.Size(273, 21);
            this.cmbFabricante.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Fabricante:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Modelo:";
            // 
            // btnCriar
            // 
            this.btnCriar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriar.Location = new System.Drawing.Point(279, 299);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(99, 32);
            this.btnCriar.TabIndex = 27;
            this.btnCriar.Text = "Cadastrar";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // numDesconto
            // 
            this.numDesconto.DecimalPlaces = 2;
            this.numDesconto.Location = new System.Drawing.Point(106, 316);
            this.numDesconto.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.numDesconto.Name = "numDesconto";
            this.numDesconto.Size = new System.Drawing.Size(113, 20);
            this.numDesconto.TabIndex = 63;
            this.numDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDesconto.ThousandsSeparator = true;
            // 
            // nunQuantidade
            // 
            this.nunQuantidade.DecimalPlaces = 2;
            this.nunQuantidade.Location = new System.Drawing.Point(106, 284);
            this.nunQuantidade.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.nunQuantidade.Name = "nunQuantidade";
            this.nunQuantidade.Size = new System.Drawing.Size(113, 20);
            this.nunQuantidade.TabIndex = 62;
            this.nunQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nunQuantidade.ThousandsSeparator = true;
            // 
            // numPeso
            // 
            this.numPeso.DecimalPlaces = 2;
            this.numPeso.Location = new System.Drawing.Point(106, 249);
            this.numPeso.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.numPeso.Name = "numPeso";
            this.numPeso.Size = new System.Drawing.Size(113, 20);
            this.numPeso.TabIndex = 61;
            this.numPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPeso.ThousandsSeparator = true;
            // 
            // nunEspessura
            // 
            this.nunEspessura.DecimalPlaces = 2;
            this.nunEspessura.Location = new System.Drawing.Point(106, 217);
            this.nunEspessura.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.nunEspessura.Name = "nunEspessura";
            this.nunEspessura.Size = new System.Drawing.Size(113, 20);
            this.nunEspessura.TabIndex = 60;
            this.nunEspessura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nunEspessura.ThousandsSeparator = true;
            // 
            // nunAltura
            // 
            this.nunAltura.DecimalPlaces = 2;
            this.nunAltura.Location = new System.Drawing.Point(106, 182);
            this.nunAltura.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.nunAltura.Name = "nunAltura";
            this.nunAltura.Size = new System.Drawing.Size(113, 20);
            this.nunAltura.TabIndex = 59;
            this.nunAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nunAltura.ThousandsSeparator = true;
            // 
            // nunLargura
            // 
            this.nunLargura.DecimalPlaces = 2;
            this.nunLargura.Location = new System.Drawing.Point(106, 154);
            this.nunLargura.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.nunLargura.Name = "nunLargura";
            this.nunLargura.Size = new System.Drawing.Size(113, 20);
            this.nunLargura.TabIndex = 58;
            this.nunLargura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nunLargura.ThousandsSeparator = true;
            // 
            // numPreco
            // 
            this.numPreco.DecimalPlaces = 2;
            this.numPreco.Location = new System.Drawing.Point(106, 119);
            this.numPreco.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.numPreco.Name = "numPreco";
            this.numPreco.Size = new System.Drawing.Size(113, 20);
            this.numPreco.TabIndex = 57;
            this.numPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPreco.ThousandsSeparator = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 56;
            this.label9.Text = "Desconto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Quantidade:";
            // 
            // txtPesott
            // 
            this.txtPesott.AutoSize = true;
            this.txtPesott.Location = new System.Drawing.Point(26, 251);
            this.txtPesott.Name = "txtPesott";
            this.txtPesott.Size = new System.Drawing.Size(34, 13);
            this.txtPesott.TabIndex = 54;
            this.txtPesott.Text = "Peso:";
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Location = new System.Drawing.Point(26, 219);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(59, 13);
            this.text.TabIndex = 53;
            this.text.Text = "Espessura:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Altura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Largura:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Preço:";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(411, 299);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(76, 32);
            this.btnSair.TabIndex = 64;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 361);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.numDesconto);
            this.Controls.Add(this.nunQuantidade);
            this.Controls.Add(this.numPeso);
            this.Controls.Add(this.nunEspessura);
            this.Controls.Add(this.nunAltura);
            this.Controls.Add(this.nunLargura);
            this.Controls.Add(this.numPreco);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPesott);
            this.Controls.Add(this.text);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.cmbFabricante);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "frmNovo";
            this.Text = "frmNovo";
            this.Load += new System.EventHandler(this.frmNovo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numDesconto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nunQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nunEspessura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nunAltura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nunLargura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPreco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.ComboBox cmbFabricante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.NumericUpDown numDesconto;
        private System.Windows.Forms.NumericUpDown nunQuantidade;
        private System.Windows.Forms.NumericUpDown numPeso;
        private System.Windows.Forms.NumericUpDown nunEspessura;
        private System.Windows.Forms.NumericUpDown nunAltura;
        private System.Windows.Forms.NumericUpDown nunLargura;
        private System.Windows.Forms.NumericUpDown numPreco;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtPesott;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSair;
    }
}