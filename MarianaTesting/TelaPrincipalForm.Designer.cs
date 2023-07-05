namespace MarianaTesting
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipalForm));
            panel1 = new Panel();
            btnMaterias = new Button();
            btnDisciplinas = new Button();
            btnQuestions = new Button();
            btnTests = new Button();
            btnDashboard = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            painelDashboard = new Panel();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            barraDeFerramenta = new ToolStrip();
            btnCadastrar = new ToolStripButton();
            btnEdit = new ToolStripButton();
            btnDelete = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            labelTitle = new ToolStripLabel();
            toolStrip1 = new ToolStrip();
            btnAdicionar = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel1 = new ToolStripLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            painelDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            barraDeFerramenta.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnMaterias);
            panel1.Controls.Add(btnDisciplinas);
            panel1.Controls.Add(btnQuestions);
            panel1.Controls.Add(btnTests);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(231, 661);
            panel1.TabIndex = 0;
            // 
            // btnMaterias
            // 
            btnMaterias.Cursor = Cursors.Hand;
            btnMaterias.FlatStyle = FlatStyle.Flat;
            btnMaterias.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMaterias.Image = WinApp.Properties.Resources.school;
            btnMaterias.Location = new Point(3, 375);
            btnMaterias.Name = "btnMaterias";
            btnMaterias.Size = new Size(222, 40);
            btnMaterias.TabIndex = 22;
            btnMaterias.Text = "Matérias";
            btnMaterias.TextAlign = ContentAlignment.MiddleRight;
            btnMaterias.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMaterias.UseVisualStyleBackColor = true;
            btnMaterias.Click += btnMaterias_Click;
            // 
            // btnDisciplinas
            // 
            btnDisciplinas.Cursor = Cursors.Hand;
            btnDisciplinas.FlatStyle = FlatStyle.Flat;
            btnDisciplinas.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDisciplinas.Image = WinApp.Properties.Resources.subjects;
            btnDisciplinas.Location = new Point(3, 421);
            btnDisciplinas.Name = "btnDisciplinas";
            btnDisciplinas.Size = new Size(222, 40);
            btnDisciplinas.TabIndex = 21;
            btnDisciplinas.Text = "Disciplinas";
            btnDisciplinas.TextAlign = ContentAlignment.MiddleRight;
            btnDisciplinas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDisciplinas.UseVisualStyleBackColor = true;
            btnDisciplinas.Click += btnDisciplinas_Click;
            // 
            // btnQuestions
            // 
            btnQuestions.Cursor = Cursors.Hand;
            btnQuestions.FlatStyle = FlatStyle.Flat;
            btnQuestions.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuestions.Image = WinApp.Properties.Resources.quiz;
            btnQuestions.Location = new Point(3, 329);
            btnQuestions.Name = "btnQuestions";
            btnQuestions.Size = new Size(222, 40);
            btnQuestions.TabIndex = 20;
            btnQuestions.Text = "Questões";
            btnQuestions.TextAlign = ContentAlignment.MiddleRight;
            btnQuestions.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnQuestions.UseVisualStyleBackColor = true;
            btnQuestions.Click += btnQuestions_Click;
            // 
            // btnTests
            // 
            btnTests.Cursor = Cursors.Hand;
            btnTests.FlatStyle = FlatStyle.Flat;
            btnTests.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTests.Image = WinApp.Properties.Resources.receipt;
            btnTests.Location = new Point(3, 283);
            btnTests.Name = "btnTests";
            btnTests.Size = new Size(222, 40);
            btnTests.TabIndex = 19;
            btnTests.Text = "Testes";
            btnTests.TextAlign = ContentAlignment.MiddleRight;
            btnTests.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTests.UseVisualStyleBackColor = true;
            btnTests.Click += btnTests_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.BorderColor = Color.Black;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDashboard.ForeColor = SystemColors.ControlText;
            btnDashboard.Image = WinApp.Properties.Resources.home;
            btnDashboard.Location = new Point(12, 166);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(200, 54);
            btnDashboard.TabIndex = 4;
            btnDashboard.Text = "Painel de Estudos";
            btnDashboard.TextAlign = ContentAlignment.MiddleRight;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = WinApp.Properties.Resources.tasks_png;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 128);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 2;
            label3.Text = "INÍCIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 253);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 1;
            label2.Text = "GERENCIAR";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(75, 26);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 0;
            label1.Text = "Mariana Exams";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ImageAlign = ContentAlignment.TopCenter;
            label4.Location = new Point(407, 4);
            label4.Name = "label4";
            label4.Size = new Size(250, 25);
            label4.TabIndex = 2;
            label4.Text = "Plataforma de Estudos";
            // 
            // painelDashboard
            // 
            painelDashboard.BackColor = SystemColors.ControlDark;
            painelDashboard.Controls.Add(pictureBox2);
            painelDashboard.Controls.Add(label4);
            painelDashboard.Dock = DockStyle.Fill;
            painelDashboard.Location = new Point(231, 0);
            painelDashboard.Name = "painelDashboard";
            painelDashboard.Size = new Size(1053, 661);
            painelDashboard.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(0, 80);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1053, 532);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(barraDeFerramenta);
            panel2.Controls.Add(toolStrip1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(231, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1053, 58);
            panel2.TabIndex = 4;
            // 
            // barraDeFerramenta
            // 
            barraDeFerramenta.AutoSize = false;
            barraDeFerramenta.Items.AddRange(new ToolStripItem[] { btnCadastrar, btnEdit, btnDelete, toolStripSeparator2, labelTitle });
            barraDeFerramenta.Location = new Point(0, 0);
            barraDeFerramenta.Name = "barraDeFerramenta";
            barraDeFerramenta.Size = new Size(1053, 56);
            barraDeFerramenta.TabIndex = 2;
            barraDeFerramenta.Text = "toolStrip2";
            // 
            // btnCadastrar
            // 
            btnCadastrar.AutoSize = false;
            btnCadastrar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnCadastrar.Image = (Image)resources.GetObject("btnCadastrar.Image");
            btnCadastrar.ImageScaling = ToolStripItemImageScaling.None;
            btnCadastrar.ImageTransparentColor = Color.Magenta;
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(50, 45);
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnEdit
            // 
            btnEdit.AutoSize = false;
            btnEdit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.ImageScaling = ToolStripItemImageScaling.None;
            btnEdit.ImageTransparentColor = Color.Magenta;
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(50, 45);
            btnEdit.Text = "Editar";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = false;
            btnDelete.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageScaling = ToolStripItemImageScaling.None;
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(50, 45);
            btnDelete.Text = "Excluir";
            btnDelete.Click += btnDelete_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 56);
            // 
            // labelTitle
            // 
            labelTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(157, 53);
            labelTitle.Text = "Disciplinas Registradas";
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.Dock = DockStyle.Fill;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdicionar, btnEditar, btnExcluir, toolStripSeparator1, toolStripLabel1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1053, 75);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.Visible = false;
            // 
            // btnAdicionar
            // 
            btnAdicionar.AutoSize = false;
            btnAdicionar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdicionar.Image = (Image)resources.GetObject("btnAdicionar.Image");
            btnAdicionar.ImageScaling = ToolStripItemImageScaling.None;
            btnAdicionar.ImageTransparentColor = Color.Magenta;
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(50, 45);
            btnAdicionar.Text = "Adicionar Disciplina";
            // 
            // btnEditar
            // 
            btnEditar.AutoSize = false;
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageScaling = ToolStripItemImageScaling.None;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(50, 45);
            btnEditar.Text = "Editar Disciplina";
            // 
            // btnExcluir
            // 
            btnExcluir.AutoSize = false;
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.ImageScaling = ToolStripItemImageScaling.None;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(50, 45);
            btnExcluir.Text = "Excluir Disciplina";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 75);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(162, 72);
            toolStripLabel1.Text = "Disciplinas Cadastradas";
            // 
            // telaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1284, 661);
            Controls.Add(panel2);
            Controls.Add(painelDashboard);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "telaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MarianaExams 1.0";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            painelDashboard.ResumeLayout(false);
            painelDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            barraDeFerramenta.ResumeLayout(false);
            barraDeFerramenta.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Button btnMaterias;
        private Button btnQuestions;
        private Button btnTests;
        private Button btnDashboard;
        private Button btnDisciplinas;
        private Label label4;
        private Panel painelDashboard;
        private Panel panel2;
        private ToolStrip toolStrip1;
        private ToolStripButton btnAdicionar;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel1;
        private PictureBox pictureBox2;
        private ToolStrip barraDeFerramenta;
        private ToolStripButton btnCadastrar;
        private ToolStripButton btnEdit;
        private ToolStripButton btnDelete;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel labelTitle;
    }
}