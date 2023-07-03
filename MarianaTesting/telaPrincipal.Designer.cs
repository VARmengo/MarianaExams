namespace MarianaTesting
{
    partial class telaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaPrincipal));
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
            panel2 = new Panel();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
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
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(231, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1053, 66);
            panel2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(660, 103);
            label4.Name = "label4";
            label4.Size = new Size(250, 25);
            label4.TabIndex = 2;
            label4.Text = "Plataforma de Estudos";
            // 
            // telaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 661);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "telaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MarianaExams 1.0";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Button btnMaterias;
        private Button btnQuestions;
        private Button btnTests;
        private Button btnDashboard;
        private Button btnDisciplinas;
        private Label label4;
    }
}