namespace exAREA
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
            this.lblTittulo = new System.Windows.Forms.Label();
            this.lblN1 = new System.Windows.Forms.Label();
            this.txbBase = new System.Windows.Forms.NumericUpDown();
            this.txbAltura = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txbResultado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txbBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbAltura)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTittulo
            // 
            this.lblTittulo.AutoSize = true;
            this.lblTittulo.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittulo.Location = new System.Drawing.Point(132, 9);
            this.lblTittulo.Name = "lblTittulo";
            this.lblTittulo.Size = new System.Drawing.Size(178, 16);
            this.lblTittulo.TabIndex = 0;
            this.lblTittulo.Text = "Calculadora de area";
            // 
            // lblN1
            // 
            this.lblN1.AutoSize = true;
            this.lblN1.Location = new System.Drawing.Point(74, 107);
            this.lblN1.Name = "lblN1";
            this.lblN1.Size = new System.Drawing.Size(31, 13);
            this.lblN1.TabIndex = 1;
            this.lblN1.Text = "Base";
            // 
            // txbBase
            // 
            this.txbBase.Location = new System.Drawing.Point(134, 105);
            this.txbBase.Name = "txbBase";
            this.txbBase.Size = new System.Drawing.Size(120, 20);
            this.txbBase.TabIndex = 2;
            this.txbBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbAltura
            // 
            this.txbAltura.Location = new System.Drawing.Point(134, 137);
            this.txbAltura.Name = "txbAltura";
            this.txbAltura.Size = new System.Drawing.Size(120, 20);
            this.txbAltura.TabIndex = 4;
            this.txbAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Altura";
            // 
            // btnCalcular
            // 
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(290, 118);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(83, 34);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("PanRoman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblResultado.Location = new System.Drawing.Point(74, 215);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(66, 15);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "Resultado";
            // 
            // txbResultado
            // 
            this.txbResultado.Location = new System.Drawing.Point(58, 249);
            this.txbResultado.Name = "txbResultado";
            this.txbResultado.ReadOnly = true;
            this.txbResultado.Size = new System.Drawing.Size(100, 20);
            this.txbResultado.TabIndex = 7;
            this.txbResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 450);
            this.Controls.Add(this.txbResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txbAltura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbBase);
            this.Controls.Add(this.lblN1);
            this.Controls.Add(this.lblTittulo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.txbBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbAltura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTittulo;
        private System.Windows.Forms.Label lblN1;
        private System.Windows.Forms.NumericUpDown txbBase;
        private System.Windows.Forms.NumericUpDown txbAltura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txbResultado;
    }
}

