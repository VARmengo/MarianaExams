namespace MarianaTesting.WinApp.ModuloQuestoes
{
    partial class CadastroQuestoesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroQuestoesForm));
            cmbMateria = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtQuestao = new TextBox();
            txtResposta = new TextBox();
            btnAdicionar = new Button();
            label4 = new Label();
            cmbDisciplina = new ComboBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // cmbMateria
            // 
            cmbMateria.FormattingEnabled = true;
            cmbMateria.Location = new Point(110, 107);
            cmbMateria.Name = "cmbMateria";
            cmbMateria.Size = new Size(230, 23);
            cmbMateria.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 110);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 1;
            label1.Text = "Matéria:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 171);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 2;
            label2.Text = "Enunciado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 302);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 3;
            label3.Text = "Resposta: ";
            // 
            // txtQuestao
            // 
            txtQuestao.Location = new Point(110, 168);
            txtQuestao.Multiline = true;
            txtQuestao.Name = "txtQuestao";
            txtQuestao.Size = new Size(419, 92);
            txtQuestao.TabIndex = 4;
            // 
            // txtResposta
            // 
            txtResposta.Location = new Point(110, 284);
            txtResposta.Multiline = true;
            txtResposta.Name = "txtResposta";
            txtResposta.Size = new Size(296, 46);
            txtResposta.TabIndex = 5;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(425, 291);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(104, 36);
            btnAdicionar.TabIndex = 6;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 57);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 8;
            label4.Text = "Disciplina: ";
            // 
            // cmbDisciplina
            // 
            cmbDisciplina.FormattingEnabled = true;
            cmbDisciplina.Location = new Point(110, 54);
            cmbDisciplina.Name = "cmbDisciplina";
            cmbDisciplina.Size = new Size(230, 23);
            cmbDisciplina.TabIndex = 7;
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(411, 480);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(80, 42);
            btnGravar.TabIndex = 9;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(497, 480);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 42);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // CadastroQuestoesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 534);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(label4);
            Controls.Add(cmbDisciplina);
            Controls.Add(btnAdicionar);
            Controls.Add(txtResposta);
            Controls.Add(txtQuestao);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbMateria);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CadastroQuestoesForm";
            Text = "Cadastro de Questões";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbMateria;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtQuestao;
        private TextBox txtResposta;
        private Button btnAdicionar;
        private Label label4;
        private ComboBox cmbDisciplina;
        private Button btnGravar;
        private Button btnCancelar;
    }
}