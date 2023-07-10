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
            cklAlternativas = new CheckedListBox();
            statusStrip1 = new StatusStrip();
            labelstatus = new ToolStripStatusLabel();
            labelRodape = new ToolStripStatusLabel();
            btnRemover = new Button();
            btnCancelar = new Button();
            btnGravar = new Button();
            statusStrip1.SuspendLayout();
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
            btnAdicionar.Click += btnAdicionar_Click;
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
            // cklAlternativas
            // 
            cklAlternativas.FormattingEnabled = true;
            cklAlternativas.Location = new Point(110, 373);
            cklAlternativas.Name = "cklAlternativas";
            cklAlternativas.Size = new Size(419, 148);
            cklAlternativas.TabIndex = 11;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { labelstatus, labelRodape });
            statusStrip1.Location = new Point(0, 601);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(566, 22);
            statusStrip1.TabIndex = 25;
            statusStrip1.Text = "statusStrip1";
            // 
            // labelstatus
            // 
            labelstatus.Name = "labelstatus";
            labelstatus.Size = new Size(0, 17);
            // 
            // labelRodape
            // 
            labelRodape.Name = "labelRodape";
            labelRodape.Size = new Size(0, 17);
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(454, 498);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 23);
            btnRemover.TabIndex = 26;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(435, 553);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 36);
            btnCancelar.TabIndex = 34;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // btnGravar
            // 
            btnGravar.BackColor = Color.White;
            btnGravar.Cursor = Cursors.Hand;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.FlatStyle = FlatStyle.Flat;
            btnGravar.Location = new Point(335, 553);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(94, 36);
            btnGravar.TabIndex = 33;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = false;
            btnGravar.Click += btnGravar_Click_1;
            // 
            // CadastroQuestoesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 623);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(btnRemover);
            Controls.Add(statusStrip1);
            Controls.Add(cklAlternativas);
            Controls.Add(label4);
            Controls.Add(cmbDisciplina);
            Controls.Add(btnAdicionar);
            Controls.Add(txtResposta);
            Controls.Add(txtQuestao);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbMateria);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CadastroQuestoesForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Questões";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
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
        private CheckedListBox cklAlternativas;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel labelstatus;
        private ToolStripStatusLabel labelRodape;
        private Button btnRemover;
        private Button button1;
        private Button button2;
    }
}