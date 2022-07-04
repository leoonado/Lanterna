namespace ex._02._2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLigarDesligar = new System.Windows.Forms.Button();
            this.btnTrocarBateria = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLigarDesligar
            // 
            this.btnLigarDesligar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLigarDesligar.Location = new System.Drawing.Point(12, 12);
            this.btnLigarDesligar.Name = "btnLigarDesligar";
            this.btnLigarDesligar.Size = new System.Drawing.Size(108, 23);
            this.btnLigarDesligar.TabIndex = 0;
            this.btnLigarDesligar.Text = "Desligada";
            this.btnLigarDesligar.UseVisualStyleBackColor = true;
            this.btnLigarDesligar.Click += new System.EventHandler(this.btnLigarDesligar_Click_1);
            // 
            // btnTrocarBateria
            // 
            this.btnTrocarBateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrocarBateria.Location = new System.Drawing.Point(12, 205);
            this.btnTrocarBateria.Name = "btnTrocarBateria";
            this.btnTrocarBateria.Size = new System.Drawing.Size(108, 23);
            this.btnTrocarBateria.TabIndex = 1;
            this.btnTrocarBateria.Text = "Trocar Bateria";
            this.btnTrocarBateria.UseVisualStyleBackColor = true;
            this.btnTrocarBateria.Click += new System.EventHandler(this.btnTrocarBateria_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "100 %";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(326, 253);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTrocarBateria);
            this.Controls.Add(this.btnLigarDesligar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Lanterna";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLigarDesligar;
        private System.Windows.Forms.Button btnTrocarBateria;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

