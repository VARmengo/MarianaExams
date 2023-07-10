namespace MarianaTesting.WinApp.ModuloQuestoes
{
    partial class TabelaQuestoesControl
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            gridQuestao = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridQuestao).BeginInit();
            SuspendLayout();
            // 
            // gridQuestao
            // 
            gridQuestao.AllowUserToAddRows = false;
            gridQuestao.AllowUserToDeleteRows = false;
            gridQuestao.AllowUserToResizeColumns = false;
            gridQuestao.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.SelectionBackColor = Color.LightYellow;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            gridQuestao.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            gridQuestao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            gridQuestao.BackgroundColor = SystemColors.ControlLight;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.LightYellow;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            gridQuestao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            gridQuestao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.LightYellow;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            gridQuestao.DefaultCellStyle = dataGridViewCellStyle6;
            gridQuestao.Location = new Point(27, 72);
            gridQuestao.MultiSelect = false;
            gridQuestao.Name = "gridQuestao";
            gridQuestao.RowTemplate.Height = 25;
            gridQuestao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridQuestao.Size = new Size(1000, 563);
            gridQuestao.TabIndex = 1;
            // 
            // TabelaQuestoesControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            Controls.Add(gridQuestao);
            Name = "TabelaQuestoesControl";
            Size = new Size(1053, 661);
            ((System.ComponentModel.ISupportInitialize)gridQuestao).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridQuestao;
    }
}
