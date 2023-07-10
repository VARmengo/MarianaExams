using MarianaTesting.Dominio.ModuloDisciplina;
using MarianaTesting.Dominio.ModuloMatéria;
using MarianaTesting.Dominio.ModuloQuestoes;
using MarianaTesting.Dominio.ModuloTeste;
using System.ComponentModel.DataAnnotations;

namespace MarianaTesting.WinApp.ModuloTeste
{
    public partial class CadastroTestesForm : Form
    {
        private List<Questao> questoesDisponiveis;

        private Teste teste;
        private readonly List<Questao> _questoes;
        private readonly List<Materia> _materias;


        public CadastroTestesForm(List<Disciplina> disciplinas, List<Materia> materias, List<Questao> questoes)
        {
            InitializeComponent();

            _questoes = questoes;
            _materias = materias;

            CarregarDisciplinas(disciplinas);
            CarregarMaterias(materias);
            CarregarQuestoes(questoes);
        }


        private void btnGravar_Click(object sender, EventArgs e)
        {
            Teste teste = ObterTeste();


            string[] erros = teste.Validar();

            if (erros.Length > 0)
            {
                AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
                return;
            }
        }

        private void AtualizarRodape(string mensagem)
        {
            labelRodape.Text = mensagem;
        }

        public void ConfigurarTela(Teste testeSelecionado)
        {
            txtTitulo.Text = testeSelecionado.nome;
            cbxDisciplina.SelectedItem = testeSelecionado.disciplina;
            cbxMateria.SelectedItem = testeSelecionado.materia;
            listQuestoes.Items.Clear();
            listQuestoes.Items.AddRange(testeSelecionado.questoes.ToArray());
        }

        private void CarregarMaterias(List<Materia> materias)
        {
            foreach (Materia materia in materias)
                cbxMateria.Items.Add(materia);
        }

        private void CarregarDisciplinas(List<Disciplina> disciplinas)
        {
            foreach (Disciplina disciplina in disciplinas)
                cbxDisciplina.Items.Add(disciplina);
        }

        private void CarregarQuestoes(List<Questao> questoes)
        {
            int i = 0;
            for (int j = 0; j < listQuestoes.Items.Count; i++)
            {
                Questao questao = (Questao)listQuestoes.Items[j];

                if (teste.questoes.Contains(questao))
                    listQuestoes.SetItemChecked(i, true);

                i++;
            }
        }

        public Teste ObterTeste()
        {
            string titulo = txtTitulo.Text;
            Disciplina disciplina = (Disciplina)cbxDisciplina.SelectedItem;
            Materia materia = (Materia)cbxMateria.SelectedItem;

            List<Questao> questoes = new();

            questoes.AddRange(listQuestoes.Items.Cast<Questao>());

            Teste teste = new Teste(titulo, disciplina, materia, questoes);

            return teste;
        }

        private void cbxMateria_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbxMateria.SelectedItem is Materia materiaSelecionada)
            {
                List<Questao> questao = _questoes.FindAll(q => q.materia.id == materiaSelecionada.id);

                listQuestoes.Items.AddRange(questao.ToArray());
            }
        }
    }
}
