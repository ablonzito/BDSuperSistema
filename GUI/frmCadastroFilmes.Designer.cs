namespace GUI
{
    partial class frmCadastroFilmes
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
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txt_nomeFilme = new System.Windows.Forms.TextBox();
            this.txt_diretor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDtLancamento = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.Location = new System.Drawing.Point(12, 125);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(75, 23);
            this.btn_Confirmar.TabIndex = 0;
            this.btn_Confirmar.Text = "Cadastrar";
            this.btn_Confirmar.UseVisualStyleBackColor = true;
            this.btn_Confirmar.Click += new System.EventHandler(this.Btn_Confirmar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(119, 125);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 1;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // txt_nomeFilme
            // 
            this.txt_nomeFilme.Location = new System.Drawing.Point(68, 12);
            this.txt_nomeFilme.Name = "txt_nomeFilme";
            this.txt_nomeFilme.Size = new System.Drawing.Size(126, 20);
            this.txt_nomeFilme.TabIndex = 2;
            // 
            // txt_diretor
            // 
            this.txt_diretor.Location = new System.Drawing.Point(68, 54);
            this.txt_diretor.Name = "txt_diretor";
            this.txt_diretor.Size = new System.Drawing.Size(126, 20);
            this.txt_diretor.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Diretor";
            // 
            // dtpDtLancamento
            // 
            this.dtpDtLancamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtLancamento.Location = new System.Drawing.Point(95, 80);
            this.dtpDtLancamento.Name = "dtpDtLancamento";
            this.dtpDtLancamento.Size = new System.Drawing.Size(115, 20);
            this.dtpDtLancamento.TabIndex = 6;
            // 
            // frmCadastroFilmes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 158);
            this.ControlBox = false;
            this.Controls.Add(this.dtpDtLancamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_diretor);
            this.Controls.Add(this.txt_nomeFilme);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_Confirmar);
            this.Name = "frmCadastroFilmes";
            this.Text = "Cadastro Filmes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TextBox txt_nomeFilme;
        private System.Windows.Forms.TextBox txt_diretor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDtLancamento;
    }
}