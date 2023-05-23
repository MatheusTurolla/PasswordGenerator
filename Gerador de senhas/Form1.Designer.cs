namespace Gerador_de_senhas
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
            this.lbl_titleSenhaGerada = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkbox_numbers = new System.Windows.Forms.CheckBox();
            this.checkbox_specialCharacters = new System.Windows.Forms.CheckBox();
            this.trackbar_tamanho = new System.Windows.Forms.TrackBar();
            this.lbl_trackbar = new System.Windows.Forms.Label();
            this.lbl_senhaGerada = new System.Windows.Forms.Label();
            this.lbl_tamanho = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_tamanho)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titleSenhaGerada
            // 
            this.lbl_titleSenhaGerada.AutoSize = true;
            this.lbl_titleSenhaGerada.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titleSenhaGerada.Location = new System.Drawing.Point(12, 44);
            this.lbl_titleSenhaGerada.Name = "lbl_titleSenhaGerada";
            this.lbl_titleSenhaGerada.Size = new System.Drawing.Size(175, 25);
            this.lbl_titleSenhaGerada.TabIndex = 0;
            this.lbl_titleSenhaGerada.Text = "Senha gerada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(193, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 1;
            // 
            // checkbox_numbers
            // 
            this.checkbox_numbers.AutoSize = true;
            this.checkbox_numbers.Location = new System.Drawing.Point(17, 102);
            this.checkbox_numbers.Name = "checkbox_numbers";
            this.checkbox_numbers.Size = new System.Drawing.Size(68, 17);
            this.checkbox_numbers.TabIndex = 2;
            this.checkbox_numbers.Text = "Números";
            this.checkbox_numbers.UseVisualStyleBackColor = true;
            this.checkbox_numbers.CheckedChanged += new System.EventHandler(this.checkbox_numbers_CheckedChanged);
            // 
            // checkbox_specialCharacters
            // 
            this.checkbox_specialCharacters.AutoSize = true;
            this.checkbox_specialCharacters.Location = new System.Drawing.Point(17, 135);
            this.checkbox_specialCharacters.Name = "checkbox_specialCharacters";
            this.checkbox_specialCharacters.Size = new System.Drawing.Size(124, 17);
            this.checkbox_specialCharacters.TabIndex = 3;
            this.checkbox_specialCharacters.Text = "Caracteres especiais";
            this.checkbox_specialCharacters.UseVisualStyleBackColor = true;
            this.checkbox_specialCharacters.CheckedChanged += new System.EventHandler(this.checkbox_specialCharacters_CheckedChanged);
            // 
            // trackbar_tamanho
            // 
            this.trackbar_tamanho.Location = new System.Drawing.Point(17, 183);
            this.trackbar_tamanho.Maximum = 18;
            this.trackbar_tamanho.Minimum = 7;
            this.trackbar_tamanho.Name = "trackbar_tamanho";
            this.trackbar_tamanho.Size = new System.Drawing.Size(202, 45);
            this.trackbar_tamanho.TabIndex = 4;
            this.trackbar_tamanho.Value = 7;
            this.trackbar_tamanho.ValueChanged += new System.EventHandler(this.trackbar_tamanho_ValueChanged);
            // 
            // lbl_trackbar
            // 
            this.lbl_trackbar.AutoSize = true;
            this.lbl_trackbar.Location = new System.Drawing.Point(14, 167);
            this.lbl_trackbar.Name = "lbl_trackbar";
            this.lbl_trackbar.Size = new System.Drawing.Size(52, 13);
            this.lbl_trackbar.TabIndex = 5;
            this.lbl_trackbar.Text = "Tamanho";
            // 
            // lbl_senhaGerada
            // 
            this.lbl_senhaGerada.AutoSize = true;
            this.lbl_senhaGerada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senhaGerada.Location = new System.Drawing.Point(193, 44);
            this.lbl_senhaGerada.Name = "lbl_senhaGerada";
            this.lbl_senhaGerada.Size = new System.Drawing.Size(64, 25);
            this.lbl_senhaGerada.TabIndex = 6;
            this.lbl_senhaGerada.Text = "blank";
            // 
            // lbl_tamanho
            // 
            this.lbl_tamanho.AutoSize = true;
            this.lbl_tamanho.Location = new System.Drawing.Point(225, 192);
            this.lbl_tamanho.Name = "lbl_tamanho";
            this.lbl_tamanho.Size = new System.Drawing.Size(57, 13);
            this.lbl_tamanho.TabIndex = 7;
            this.lbl_tamanho.Text = "caracteres";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 239);
            this.Controls.Add(this.lbl_tamanho);
            this.Controls.Add(this.lbl_senhaGerada);
            this.Controls.Add(this.lbl_trackbar);
            this.Controls.Add(this.trackbar_tamanho);
            this.Controls.Add(this.checkbox_specialCharacters);
            this.Controls.Add(this.checkbox_numbers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_titleSenhaGerada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_tamanho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titleSenhaGerada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkbox_numbers;
        private System.Windows.Forms.CheckBox checkbox_specialCharacters;
        private System.Windows.Forms.TrackBar trackbar_tamanho;
        private System.Windows.Forms.Label lbl_trackbar;
        private System.Windows.Forms.Label lbl_senhaGerada;
        private System.Windows.Forms.Label lbl_tamanho;
    }
}

