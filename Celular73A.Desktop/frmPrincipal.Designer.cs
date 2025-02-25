namespace Celular73A.Desktop
{
    partial class frmPrincipal
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstAparelho = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.cmbFabricante = new System.Windows.Forms.ComboBox();
            this.btnPesquisarFabricantt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPesquisarModelo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPesquisarPreco = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numPrecoMax = new System.Windows.Forms.NumericUpDown();
            this.numPrecoMin = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoMin)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnNovo);
            this.groupBox3.Controls.Add(this.btnComprar);
            this.groupBox3.Location = new System.Drawing.Point(13, 466);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(466, 47);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(129, 16);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(86, 22);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(23, 16);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(86, 22);
            this.btnComprar.TabIndex = 0;
            this.btnComprar.Text = "&Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstAparelho);
            this.groupBox2.Location = new System.Drawing.Point(13, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(466, 322);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Celulares: ";
            // 
            // lstAparelho
            // 
            this.lstAparelho.FormattingEnabled = true;
            this.lstAparelho.Location = new System.Drawing.Point(21, 32);
            this.lstAparelho.Name = "lstAparelho";
            this.lstAparelho.Size = new System.Drawing.Size(433, 264);
            this.lstAparelho.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtModelo);
            this.groupBox1.Controls.Add(this.cmbFabricante);
            this.groupBox1.Controls.Add(this.btnPesquisarFabricantt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnPesquisarModelo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnPesquisarPreco);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numPrecoMax);
            this.groupBox1.Controls.Add(this.numPrecoMin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 126);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar por:";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(85, 57);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(272, 20);
            this.txtModelo.TabIndex = 10;
            // 
            // cmbFabricante
            // 
            this.cmbFabricante.FormattingEnabled = true;
            this.cmbFabricante.Location = new System.Drawing.Point(85, 88);
            this.cmbFabricante.Name = "cmbFabricante";
            this.cmbFabricante.Size = new System.Drawing.Size(273, 21);
            this.cmbFabricante.TabIndex = 9;
            // 
            // btnPesquisarFabricantt
            // 
            this.btnPesquisarFabricantt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarFabricantt.Location = new System.Drawing.Point(393, 88);
            this.btnPesquisarFabricantt.Name = "btnPesquisarFabricantt";
            this.btnPesquisarFabricantt.Size = new System.Drawing.Size(47, 22);
            this.btnPesquisarFabricantt.TabIndex = 8;
            this.btnPesquisarFabricantt.Text = ">";
            this.btnPesquisarFabricantt.UseVisualStyleBackColor = true;
            this.btnPesquisarFabricantt.Click += new System.EventHandler(this.btnPesquisarFabricantt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fabricante:";
            // 
            // btnPesquisarModelo
            // 
            this.btnPesquisarModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarModelo.Location = new System.Drawing.Point(393, 57);
            this.btnPesquisarModelo.Name = "btnPesquisarModelo";
            this.btnPesquisarModelo.Size = new System.Drawing.Size(47, 22);
            this.btnPesquisarModelo.TabIndex = 6;
            this.btnPesquisarModelo.Text = ">";
            this.btnPesquisarModelo.UseVisualStyleBackColor = true;
            this.btnPesquisarModelo.Click += new System.EventHandler(this.btnPesquisarModelo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Modelo:";
            // 
            // btnPesquisarPreco
            // 
            this.btnPesquisarPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarPreco.Location = new System.Drawing.Point(393, 23);
            this.btnPesquisarPreco.Name = "btnPesquisarPreco";
            this.btnPesquisarPreco.Size = new System.Drawing.Size(47, 22);
            this.btnPesquisarPreco.TabIndex = 4;
            this.btnPesquisarPreco.Text = ">";
            this.btnPesquisarPreco.UseVisualStyleBackColor = true;
            this.btnPesquisarPreco.Click += new System.EventHandler(this.btnPesquisarPreco_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "a";
            // 
            // numPrecoMax
            // 
            this.numPrecoMax.DecimalPlaces = 2;
            this.numPrecoMax.Location = new System.Drawing.Point(245, 22);
            this.numPrecoMax.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.numPrecoMax.Name = "numPrecoMax";
            this.numPrecoMax.Size = new System.Drawing.Size(113, 20);
            this.numPrecoMax.TabIndex = 2;
            this.numPrecoMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPrecoMax.ThousandsSeparator = true;
            // 
            // numPrecoMin
            // 
            this.numPrecoMin.DecimalPlaces = 2;
            this.numPrecoMin.Location = new System.Drawing.Point(85, 22);
            this.numPrecoMin.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.numPrecoMin.Name = "numPrecoMin";
            this.numPrecoMin.Size = new System.Drawing.Size(113, 20);
            this.numPrecoMin.TabIndex = 1;
            this.numPrecoMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPrecoMin.ThousandsSeparator = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Preço:";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 523);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.frmPrincipal_Activated);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoMin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstAparelho;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.ComboBox cmbFabricante;
        private System.Windows.Forms.Button btnPesquisarFabricantt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPesquisarModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPesquisarPreco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numPrecoMax;
        private System.Windows.Forms.NumericUpDown numPrecoMin;
        private System.Windows.Forms.Label label1;
    }
}

