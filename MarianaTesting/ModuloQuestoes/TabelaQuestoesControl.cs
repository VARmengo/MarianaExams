using MarianaTesting.Dominio.ModuloDisciplina;
using MarianaTesting.Dominio.ModuloQuestoes;
using MarianaTesting.WinApp.Compartilhado;

namespace MarianaTesting.WinApp.ModuloQuestoes
{
    public partial class TabelaQuestoesControl : UserControl
    {
        public TabelaQuestoesControl()
        {
            InitializeComponent();
            ConfigurarColunas();
            gridQuestao.ConfigurarGridSomenteLeitura();
            gridQuestao.ConfigurarGridZebrado();
            
        }

        private void ConfigurarColunas()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {
                    Name = "id",
                    HeaderText = "ID"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "questao",
                    HeaderText = "Questao"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "serie",
                    HeaderText = "Serie"
                }
            };

            gridQuestao.Columns.AddRange(colunas);
        }

        public void AtualizarRegistros(List<Questao> questoes)
        {
            gridQuestao.Rows.Clear();

            foreach (Questao q in questoes)
            {
                gridQuestao.Rows.Add(q.id, q.nome, q.materia.serie);
            }
        }

        public int ObterIdSelecionado()
        {
            if (gridQuestao.Rows.Count == 0)
            {
                return 0;
            }
            int id = Convert.ToInt32(gridQuestao.SelectedRows[0].Cells["id"].Value);

            return id;
        }
    }
}
