namespace MarianaTesting.WinApp.ModuloMatéria
{
    partial class CadastroMateriaControl
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
            txtId = new TextBox();
            lblId = new Label();
            txtNomeMateria = new TextBox();
            lblNomeMateria = new Label();
            labelDisciplinaMateria = new Label();
            cmbDisciplina = new ComboBox();
            labelSérie = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            cmbSerie = new ComboBox();
            status = new StatusStrip();
            labelRodape = new ToolStripStatusLabel();
            status.SuspendLayout();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(103, 33);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(33, 23);
            txtId.TabIndex = 27;
            txtId.Text = "0";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(77, 36);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 15);
            lblId.TabIndex = 26;
            lblId.Text = "Id:";
            // 
            // txtNomeMateria
            // 
            txtNomeMateria.Location = new Point(103, 80);
            txtNomeMateria.Name = "txtNomeMateria";
            txtNomeMateria.Size = new Size(302, 23);
            txtNomeMateria.TabIndex = 25;
            // 
            // lblNomeMateria
            // 
            lblNomeMateria.AutoSize = true;
            lblNomeMateria.Location = new Point(51, 83);
            lblNomeMateria.Name = "lblNomeMateria";
            lblNomeMateria.Size = new Size(46, 15);
            lblNomeMateria.TabIndex = 24;
            lblNomeMateria.Text = "Nome: ";
            // 
            // labelDisciplinaMateria
            // 
            labelDisciplinaMateria.AutoSize = true;
            labelDisciplinaMateria.Location = new Point(33, 120);
            labelDisciplinaMateria.Name = "labelDisciplinaMateria";
            labelDisciplinaMateria.Size = new Size(64, 15);
            labelDisciplinaMateria.TabIndex = 28;
            labelDisciplinaMateria.Text = "Disciplina: ";
            // 
            // cmbDisciplina
            // 
            cmbDisciplina.FormattingEnabled = true;
            cmbDisciplina.Location = new Point(103, 117);
            cmbDisciplina.Name = "cmbDisciplina";
            cmbDisciplina.Size = new Size(121, 23);
            cmbDisciplina.TabIndex = 29;
            // 
            // labelSérie
            // 
            labelSérie.AutoSize = true;
            labelSérie.Location = new Point(51, 157);
            labelSérie.Name = "labelSérie";
            labelSérie.Size = new Size(35, 15);
            labelSérie.TabIndex = 30;
            labelSérie.Text = "Série:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(226, 187);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 45);
            btnCancelar.TabIndex = 32;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGravar
            // 
            btnGravar.BackColor = Color.White;
            btnGravar.Cursor = Cursors.Hand;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.FlatStyle = FlatStyle.Flat;
            btnGravar.Location = new Point(106, 187);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(114, 45);
            btnGravar.TabIndex = 31;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = false;
            btnGravar.Click += btnGravar_Click;
            // 
            // cmbSerie
            // 
            cmbSerie.FormattingEnabled = true;
            cmbSerie.Items.AddRange(new object[] { "Primeira", "Segunda", "Terceira" });
            cmbSerie.Location = new Point(103, 149);
            cmbSerie.Name = "cmbSerie";
            cmbSerie.Size = new Size(121, 23);
            cmbSerie.TabIndex = 33;
            // 
            // status
            // 
            status.Items.AddRange(new ToolStripItem[] { labelRodape });
            status.Location = new Point(0, 254);
            status.Name = "status";
            status.Size = new Size(446, 22);
            status.TabIndex = 34;
            status.Text = "statusStrip1";
            // 
            // labelRodape
            // 
            labelRodape.Name = "labelRodape";
            labelRodape.Size = new Size(0, 17);
            // 
            // CadastroMateriaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 276);
            Controls.Add(status);
            Controls.Add(cmbSerie);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(labelSérie);
            Controls.Add(cmbDisciplina);
            Controls.Add(labelDisciplinaMateria);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(txtNomeMateria);
            Controls.Add(lblNomeMateria);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "CadastroMateriaControl";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Matéria";
            Load += CadastroMateriaControl_Load;
            status.ResumeLayout(false);
            status.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label lblId;
        private TextBox txtNomeMateria;
        private Label lblNomeMateria;
        private Label labelDisciplinaMateria;
        public ComboBox cmbDisciplina;
        private Label labelSérie;
        private Button btnCancelar;
        private Button btnGravar;
        private ComboBox cmbSerie;
        private StatusStrip status;
        private ToolStripStatusLabel labelRodape;
    }
}