namespace PesquisaOrdenacao
{
    partial class MainWindow
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.CheckBoxInsertion = new System.Windows.Forms.CheckBox();
            this.checkBoxSelection = new System.Windows.Forms.CheckBox();
            this.checkBoxBubble = new System.Windows.Forms.CheckBox();
            this.checkBoxShake = new System.Windows.Forms.CheckBox();
            this.lbl_StatusInsertion = new System.Windows.Forms.Label();
            this.lbl_StatusSelection = new System.Windows.Forms.Label();
            this.lbl_StatusBubble = new System.Windows.Forms.Label();
            this.lbl_StatusShake = new System.Windows.Forms.Label();
            this.totGerados = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.totGerados)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 107);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(400, 33);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Executar Ordenacao";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // CheckBoxInsertion
            // 
            this.CheckBoxInsertion.AutoSize = true;
            this.CheckBoxInsertion.Checked = true;
            this.CheckBoxInsertion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxInsertion.Location = new System.Drawing.Point(12, 12);
            this.CheckBoxInsertion.Name = "CheckBoxInsertion";
            this.CheckBoxInsertion.Size = new System.Drawing.Size(94, 17);
            this.CheckBoxInsertion.TabIndex = 1;
            this.CheckBoxInsertion.Text = "InsertionSorter";
            this.CheckBoxInsertion.UseVisualStyleBackColor = true;
            this.CheckBoxInsertion.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // checkBoxSelection
            // 
            this.checkBoxSelection.AutoSize = true;
            this.checkBoxSelection.Checked = true;
            this.checkBoxSelection.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSelection.Location = new System.Drawing.Point(12, 36);
            this.checkBoxSelection.Name = "checkBoxSelection";
            this.checkBoxSelection.Size = new System.Drawing.Size(98, 17);
            this.checkBoxSelection.TabIndex = 2;
            this.checkBoxSelection.Text = "SelectionSorter";
            this.checkBoxSelection.UseVisualStyleBackColor = true;
            // 
            // checkBoxBubble
            // 
            this.checkBoxBubble.AutoSize = true;
            this.checkBoxBubble.Checked = true;
            this.checkBoxBubble.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBubble.Location = new System.Drawing.Point(12, 60);
            this.checkBoxBubble.Name = "checkBoxBubble";
            this.checkBoxBubble.Size = new System.Drawing.Size(87, 17);
            this.checkBoxBubble.TabIndex = 3;
            this.checkBoxBubble.Text = "BubbleSorter";
            this.checkBoxBubble.UseVisualStyleBackColor = true;
            // 
            // checkBoxShake
            // 
            this.checkBoxShake.AutoSize = true;
            this.checkBoxShake.Checked = true;
            this.checkBoxShake.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShake.Location = new System.Drawing.Point(12, 84);
            this.checkBoxShake.Name = "checkBoxShake";
            this.checkBoxShake.Size = new System.Drawing.Size(85, 17);
            this.checkBoxShake.TabIndex = 4;
            this.checkBoxShake.Text = "ShakeSorter";
            this.checkBoxShake.UseVisualStyleBackColor = true;
            // 
            // lbl_StatusInsertion
            // 
            this.lbl_StatusInsertion.AutoSize = true;
            this.lbl_StatusInsertion.Location = new System.Drawing.Point(469, 16);
            this.lbl_StatusInsertion.Name = "lbl_StatusInsertion";
            this.lbl_StatusInsertion.Size = new System.Drawing.Size(103, 13);
            this.lbl_StatusInsertion.TabIndex = 6;
            this.lbl_StatusInsertion.Text = "Status: Nao Iniciado";
            this.lbl_StatusInsertion.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lbl_StatusSelection
            // 
            this.lbl_StatusSelection.AutoSize = true;
            this.lbl_StatusSelection.Location = new System.Drawing.Point(469, 40);
            this.lbl_StatusSelection.Name = "lbl_StatusSelection";
            this.lbl_StatusSelection.Size = new System.Drawing.Size(103, 13);
            this.lbl_StatusSelection.TabIndex = 7;
            this.lbl_StatusSelection.Text = "Status: Nao Iniciado";
            // 
            // lbl_StatusBubble
            // 
            this.lbl_StatusBubble.AutoSize = true;
            this.lbl_StatusBubble.Location = new System.Drawing.Point(469, 64);
            this.lbl_StatusBubble.Name = "lbl_StatusBubble";
            this.lbl_StatusBubble.Size = new System.Drawing.Size(103, 13);
            this.lbl_StatusBubble.TabIndex = 8;
            this.lbl_StatusBubble.Text = "Status: Nao Iniciado";
            // 
            // lbl_StatusShake
            // 
            this.lbl_StatusShake.AutoSize = true;
            this.lbl_StatusShake.Location = new System.Drawing.Point(469, 88);
            this.lbl_StatusShake.Name = "lbl_StatusShake";
            this.lbl_StatusShake.Size = new System.Drawing.Size(103, 13);
            this.lbl_StatusShake.TabIndex = 9;
            this.lbl_StatusShake.Text = "Status: Nao Iniciado";
            // 
            // totGerados
            // 
            this.totGerados.Location = new System.Drawing.Point(135, 11);
            this.totGerados.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.totGerados.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.totGerados.Name = "totGerados";
            this.totGerados.Size = new System.Drawing.Size(98, 20);
            this.totGerados.TabIndex = 12;
            this.totGerados.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Total de numeros gerados";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 152);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totGerados);
            this.Controls.Add(this.lbl_StatusShake);
            this.Controls.Add(this.lbl_StatusBubble);
            this.Controls.Add(this.lbl_StatusSelection);
            this.Controls.Add(this.lbl_StatusInsertion);
            this.Controls.Add(this.checkBoxShake);
            this.Controls.Add(this.checkBoxBubble);
            this.Controls.Add(this.checkBoxSelection);
            this.Controls.Add(this.CheckBoxInsertion);
            this.Controls.Add(this.buttonStart);
            this.Name = "MainWindow";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.totGerados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.CheckBox CheckBoxInsertion;
        private System.Windows.Forms.CheckBox checkBoxSelection;
        private System.Windows.Forms.CheckBox checkBoxBubble;
        private System.Windows.Forms.CheckBox checkBoxShake;
        private System.Windows.Forms.Label lbl_StatusInsertion;
        private System.Windows.Forms.Label lbl_StatusSelection;
        private System.Windows.Forms.Label lbl_StatusBubble;
        private System.Windows.Forms.Label lbl_StatusShake;
        private System.Windows.Forms.NumericUpDown totGerados;
        private System.Windows.Forms.Label label3;
    }
}

