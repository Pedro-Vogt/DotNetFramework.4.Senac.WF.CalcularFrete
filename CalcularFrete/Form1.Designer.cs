namespace CalcularFrete
{
    partial class Form1
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
            this.CALCULARFRETE = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotalFrete = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.txtFreteMinimo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcularFrete = new System.Windows.Forms.Button();
            this.CALCULARFRETE.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CALCULARFRETE
            // 
            this.CALCULARFRETE.Controls.Add(this.groupBox1);
            this.CALCULARFRETE.Controls.Add(this.groupBox2);
            this.CALCULARFRETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CALCULARFRETE.Location = new System.Drawing.Point(12, 12);
            this.CALCULARFRETE.Name = "CALCULARFRETE";
            this.CALCULARFRETE.Size = new System.Drawing.Size(527, 601);
            this.CALCULARFRETE.TabIndex = 1;
            this.CALCULARFRETE.TabStop = false;
            this.CALCULARFRETE.Text = "CALCULAR FRETE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTotalFrete);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(6, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 222);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DADOS DO FRETE";
            // 
            // txtTotalFrete
            // 
            this.txtTotalFrete.Location = new System.Drawing.Point(141, 47);
            this.txtTotalFrete.Name = "txtTotalFrete";
            this.txtTotalFrete.Size = new System.Drawing.Size(166, 29);
            this.txtTotalFrete.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Frete";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtUf);
            this.groupBox2.Controls.Add(this.txtFreteMinimo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnCalcularFrete);
            this.groupBox2.Location = new System.Drawing.Point(6, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(515, 222);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DADOS DO PACOTE";
            // 
            // txtUf
            // 
            this.txtUf.Location = new System.Drawing.Point(186, 106);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(166, 29);
            this.txtUf.TabIndex = 4;
            // 
            // txtFreteMinimo
            // 
            this.txtFreteMinimo.Location = new System.Drawing.Point(186, 50);
            this.txtFreteMinimo.Name = "txtFreteMinimo";
            this.txtFreteMinimo.Size = new System.Drawing.Size(166, 29);
            this.txtFreteMinimo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "UF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Frete mínimo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCalcularFrete
            // 
            this.btnCalcularFrete.Location = new System.Drawing.Point(34, 161);
            this.btnCalcularFrete.Name = "btnCalcularFrete";
            this.btnCalcularFrete.Size = new System.Drawing.Size(243, 46);
            this.btnCalcularFrete.TabIndex = 0;
            this.btnCalcularFrete.Text = "CALCULAR FRETE";
            this.btnCalcularFrete.UseVisualStyleBackColor = true;
            this.btnCalcularFrete.Click += new System.EventHandler(this.btnCalcularFrete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 625);
            this.Controls.Add(this.CALCULARFRETE);
            this.Name = "Form1";
            this.Text = "Form1";
            this.CALCULARFRETE.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CALCULARFRETE;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCalcularFrete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.TextBox txtFreteMinimo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalFrete;
    }
}

