namespace MarianaTesting.WinApp.ModuloDisciplina
{
    partial class CadastroDisciplinaControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroDisciplinaControl));
            lblNomeDisciplina = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            txtNomeDisciplina = new TextBox();
            txtId = new TextBox();
            lblId = new Label();
            statusStrip1 = new StatusStrip();
            labelstatus = new ToolStripStatusLabel();
            labelRodape = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNomeDisciplina
            // 
            lblNomeDisciplina.AutoSize = true;
            lblNomeDisciplina.Location = new Point(29, 77);
            lblNomeDisciplina.Name = "lblNomeDisciplina";
            lblNomeDisciplina.Size = new Size(46, 15);
            lblNomeDisciplina.TabIndex = 0;
            lblNomeDisciplina.Text = "Nome: ";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(242, 126);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 45);
            btnCancelar.TabIndex = 20;
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
            btnGravar.Location = new Point(100, 126);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(114, 45);
            btnGravar.TabIndex = 19;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = false;
            btnGravar.Click += btnGravar_Click;
            // 
            // txtNomeDisciplina
            // 
            txtNomeDisciplina.Location = new Point(81, 74);
            txtNomeDisciplina.Name = "txtNomeDisciplina";
            txtNomeDisciplina.Size = new Size(302, 23);
            txtNomeDisciplina.TabIndex = 21;
            // 
            // txtId
            // 
            txtId.Location = new Point(81, 27);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(33, 23);
            txtId.TabIndex = 23;
            txtId.Text = "0";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(55, 30);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 15);
            lblId.TabIndex = 22;
            lblId.Text = "Id:";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { labelstatus, labelRodape });
            statusStrip1.Location = new Point(0, 191);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(436, 22);
            statusStrip1.TabIndex = 24;
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
            // CadastroDisciplinaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 213);
            Controls.Add(statusStrip1);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(txtNomeDisciplina);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(lblNomeDisciplina);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CadastroDisciplinaControl";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Disciplina";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeDisciplina;
        private Button btnCancelar;
        private Button btnGravar;
        private TextBox txtNomeDisciplina;
        private TextBox txtId;
        private Label lblId;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel labelstatus;
        private ToolStripStatusLabel labelRodape;
    }
}