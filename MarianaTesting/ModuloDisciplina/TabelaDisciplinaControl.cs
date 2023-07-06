using MarianaTesting.Dominio.ModuloDisciplina;
using MarianaTesting.WinApp.Compartilhado;

namespace MarianaTesting.WinApp.ModuloDisciplina
{
    public partial class TabelaDisciplinaControl : UserControl
    {

        public TabelaDisciplinaControl()
        {
            InitializeComponent();
            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
            ConfigurarColunas();
        }

        private void ConfigurarColunas()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {
                    Name = "id",
                    HeaderText = "Identificador"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "nome",
                    HeaderText = "Nome"
                }
            };

            grid.Columns.AddRange(colunas);
        }

        public void AtualizarRegistros(List<Disciplina> disciplinas)
        {
            grid.Rows.Clear();

            foreach (Disciplina d in disciplinas)
            {
                grid.Rows.Add(d.id, d.disciplina);
            }
        }

        public int ObterIdSelecionado()
        {
            if (grid.Rows.Count == 0)
            {
                return 0;
            }
            int id = Convert.ToInt32(grid.SelectedRows[0].Cells["id"].Value);

            return id;
        }
    }
}
