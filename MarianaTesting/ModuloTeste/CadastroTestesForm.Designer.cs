namespace MarianaTesting.WinApp.ModuloTeste
{
    partial class CadastroTestesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroTestesForm));
            label9 = new Label();
            panel3 = new Panel();
            listQuestoes = new CheckedListBox();
            label2 = new Label();
            panel2 = new Panel();
            cbxDisciplina = new ComboBox();
            cbxMateria = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            txtTitulo = new TextBox();
            label3 = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            statusStrip1 = new StatusStrip();
            labelstatus = new ToolStripStatusLabel();
            labelRodape = new ToolStripStatusLabel();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(34, 215);
            label9.Name = "label9";
            label9.Size = new Size(119, 15);
            label9.TabIndex = 18;
            label9.Text = "Questões Disponíveis";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(listQuestoes);
            panel3.Location = new Point(27, 224);
            panel3.Name = "panel3";
            panel3.Size = new Size(386, 198);
            panel3.TabIndex = 17;
            // 
            // listQuestoes
            // 
            listQuestoes.CheckOnClick = true;
            listQuestoes.FormattingEnabled = true;
            listQuestoes.Location = new Point(4, 8);
            listQuestoes.Name = "listQuestoes";
            listQuestoes.Size = new Size(376, 184);
            listQuestoes.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 29);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 16;
            label2.Text = "Configurações";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(cbxDisciplina);
            panel2.Controls.Add(cbxMateria);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtTitulo);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(27, 38);
            panel2.Name = "panel2";
            panel2.Size = new Size(386, 161);
            panel2.TabIndex = 15;
            // 
            // cbxDisciplina
            // 
            cbxDisciplina.DisplayMember = "Name";
            cbxDisciplina.FormattingEnabled = true;
            cbxDisciplina.Location = new Point(82, 56);
            cbxDisciplina.Name = "cbxDisciplina";
            cbxDisciplina.Size = new Size(281, 23);
            cbxDisciplina.TabIndex = 12;
            // 
            // cbxMateria
            // 
            cbxMateria.DisplayMember = "Name";
            cbxMateria.FormattingEnabled = true;
            cbxMateria.Location = new Point(117, 102);
            cbxMateria.Name = "cbxMateria";
            cbxMateria.Size = new Size(246, 23);
            cbxMateria.TabIndex = 6;
            cbxMateria.SelectedIndexChanged += cbxMateria_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 105);
            label7.Name = "label7";
            label7.Size = new Size(96, 15);
            label7.TabIndex = 5;
            label7.Text = "Matéria do Teste:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 59);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 3;
            label6.Text = "Disciplina:";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(61, 17);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(302, 23);
            txtTitulo.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 20);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 0;
            label3.Text = "Título:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(314, 447);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 36);
            btnCancelar.TabIndex = 36;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGravar
            // 
            btnGravar.BackColor = Color.White;
            btnGravar.Cursor = Cursors.Hand;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.FlatStyle = FlatStyle.Flat;
            btnGravar.Location = new Point(214, 447);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(94, 36);
            btnGravar.TabIndex = 35;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = false;
            btnGravar.Click += btnGravar_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { labelstatus, labelRodape });
            statusStrip1.Location = new Point(0, 499);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(443, 22);
            statusStrip1.TabIndex = 37;
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
            // CadastroTestesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 521);
            Controls.Add(statusStrip1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(label9);
            Controls.Add(panel3);
            Controls.Add(label2);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CadastroTestesForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Testes";
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Panel panel3;
        private CheckedListBox listQuestoes;
        private Label label2;
        private Panel panel2;
        private Label label5;
        private ComboBox CbxBimester;
        private ComboBox cbxDisciplina;
        private ComboBox cbxMateria;
        private Label label7;
        private Label label6;
        private TextBox txtTitulo;
        private Label label3;
        private Button btnCancelar;
        private Button btnGravar;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel labelstatus;
        private ToolStripStatusLabel labelRodape;
    }
}