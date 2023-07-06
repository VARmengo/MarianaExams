using MarianaTesting.Dominio.ModuloDisciplina;
using MarianaTesting.Dominio.ModuloMatéria;
using MarianaTesting.WinApp.Compartilhado;
using MarianaTesting.WinApp.ModuloDisciplina;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarianaTesting.WinApp.ModuloMatéria
{
    public partial class TabelaMateriaControl : UserControl
    {
        private readonly ControladorMateria controladorMateria;

        public TabelaMateriaControl()
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
                    HeaderText = "ID"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "nome",
                    HeaderText = "Nome"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "disciplinas",
                    HeaderText = "Disciplinas"
                },             
                new DataGridViewTextBoxColumn()
                {
                    Name = "serie",
                    HeaderText = "Série"
                }
            };

            grid.Columns.AddRange(colunas);
        }

        public void AtualizarRegistros(List<Materia> materias)
        {
            grid.Rows.Clear();

            foreach (Materia d in materias)
            {
                grid.Rows.Add(d.id, d.nome, d.disciplina.disciplina, d.serie);
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
