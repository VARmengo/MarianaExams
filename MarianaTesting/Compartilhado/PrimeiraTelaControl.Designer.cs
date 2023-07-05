namespace MarianaTesting.WinApp.Compartilhado
{
    partial class PrimeiraTelaControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            painelDashboard = new Panel();
            label4 = new Label();
            painelDashboard.SuspendLayout();
            SuspendLayout();
            // 
            // painelDashboard
            // 
            painelDashboard.BackColor = SystemColors.ControlDark;
            painelDashboard.Controls.Add(label4);
            painelDashboard.Dock = DockStyle.Fill;
            painelDashboard.Location = new Point(0, 0);
            painelDashboard.Name = "painelDashboard";
            painelDashboard.Size = new Size(1053, 595);
            painelDashboard.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(429, 32);
            label4.Name = "label4";
            label4.Size = new Size(250, 25);
            label4.TabIndex = 2;
            label4.Text = "Plataforma de Estudos";
            // 
            // PrimeiraTelaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(painelDashboard);
            Name = "PrimeiraTelaControl";
            Size = new Size(1053, 595);
            painelDashboard.ResumeLayout(false);
            painelDashboard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel painelDashboard;
        private Label label4;
    }
}
