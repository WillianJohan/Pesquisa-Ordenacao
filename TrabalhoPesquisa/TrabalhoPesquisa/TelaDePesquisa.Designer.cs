namespace TrabalhoPesquisa
{
    partial class TelaDePesquisa
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
            this.caixaDeTexto = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.caixaDePesquisa = new System.Windows.Forms.TextBox();
            this.lbl_Resultados = new System.Windows.Forms.Label();
            this.cb_ResultadoPerfeito = new System.Windows.Forms.CheckBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // caixaDeTexto
            // 
            this.caixaDeTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caixaDeTexto.Location = new System.Drawing.Point(12, 148);
            this.caixaDeTexto.Name = "caixaDeTexto";
            this.caixaDeTexto.Size = new System.Drawing.Size(912, 549);
            this.caixaDeTexto.TabIndex = 0;
            this.caixaDeTexto.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(242, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Programa exemplo de Pesquisa";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1304, 72);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(580, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pesquisa:";
            // 
            // caixaDePesquisa
            // 
            this.caixaDePesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caixaDePesquisa.Location = new System.Drawing.Point(663, 102);
            this.caixaDePesquisa.Name = "caixaDePesquisa";
            this.caixaDePesquisa.Size = new System.Drawing.Size(207, 26);
            this.caixaDePesquisa.TabIndex = 4;
            this.caixaDePesquisa.TextChanged += new System.EventHandler(this.CaixaDePesquisa_TextChanged);
            // 
            // lbl_Resultados
            // 
            this.lbl_Resultados.AutoSize = true;
            this.lbl_Resultados.Location = new System.Drawing.Point(660, 132);
            this.lbl_Resultados.Name = "lbl_Resultados";
            this.lbl_Resultados.Size = new System.Drawing.Size(84, 13);
            this.lbl_Resultados.TabIndex = 5;
            this.lbl_Resultados.Text = "Resultados: 289";
            // 
            // cb_ResultadoPerfeito
            // 
            this.cb_ResultadoPerfeito.AutoSize = true;
            this.cb_ResultadoPerfeito.Location = new System.Drawing.Point(775, 131);
            this.cb_ResultadoPerfeito.Name = "cb_ResultadoPerfeito";
            this.cb_ResultadoPerfeito.Size = new System.Drawing.Size(95, 17);
            this.cb_ResultadoPerfeito.TabIndex = 6;
            this.cb_ResultadoPerfeito.Text = "Match Perfeito";
            this.cb_ResultadoPerfeito.UseVisualStyleBackColor = true;
            this.cb_ResultadoPerfeito.CheckedChanged += new System.EventHandler(this.Cb_ResultadoPerfeito_CheckedChanged);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(876, 102);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(48, 43);
            this.button_Clear.TabIndex = 7;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.Button_Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(936, 709);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.cb_ResultadoPerfeito);
            this.Controls.Add(this.lbl_Resultados);
            this.Controls.Add(this.caixaDePesquisa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.caixaDeTexto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox caixaDeTexto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox caixaDePesquisa;
        private System.Windows.Forms.Label lbl_Resultados;
        private System.Windows.Forms.CheckBox cb_ResultadoPerfeito;
        private System.Windows.Forms.Button button_Clear;
    }
}

