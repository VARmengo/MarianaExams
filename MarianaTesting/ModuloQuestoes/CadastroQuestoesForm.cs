using MarianaTesting.Dominio.ModuloDisciplina;
using MarianaTesting.Dominio.ModuloMatéria;
using MarianaTesting.Dominio.ModuloQuestoes;
using System.Linq;

namespace MarianaTesting.WinApp.ModuloQuestoes
{
    public partial class CadastroQuestoesForm : Form
    {
        private readonly ControladorQuestoes controladorQuestoes;

        public CadastroQuestoesForm(List<Disciplina> disciplinas, List<Materia> materias)
        {
            InitializeComponent();
            CarregarDisciplinas(disciplinas);
            CarregarMaterias(materias);
            controladorQuestoes = new ControladorQuestoes();
        }

        private void CarregarMaterias(List<Materia> materias)
        {
            foreach (Materia materia in materias)
                cmbMateria.Items.Add(materia);
        }

        private void CarregarDisciplinas(List<Disciplina> disciplinas)
        {
            foreach (Disciplina disciplina in disciplinas)
                cmbDisciplina.Items.Add(disciplina);
        }

        public Questao ObterQuestao()
        {
            string enunciadoQuestao = txtQuestao.Text;
            Disciplina disciplina = (Disciplina)cmbDisciplina.SelectedItem;
            Materia materia = (Materia)cmbMateria.SelectedItem;

            Questao questao = new Questao(enunciadoQuestao, disciplina, materia);

            return questao;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Questao questao = ObterQuestao();



            string[] erros = questao.Validar();

            if (erros.Length > 0)
            {
                AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
                return;
            }

            if (cklAlternativas.CheckedItems.Count != 1)
            {

                DialogResult = DialogResult.None;

                MessageBox.Show("Cadastre no mínimo uma alternativa correta");
                return;
            }
        }

        public void AtualizarRodape(string mensagem)
        {
            labelRodape.Text = mensagem;
        }

        public void ConfigurarTela(Questao questaoSelecionada)
        {
            txtQuestao.Text = questaoSelecionada.nome;
            cmbDisciplina.SelectedItem = questaoSelecionada.disciplina;
            cmbMateria.SelectedItem = questaoSelecionada.materia;

            cklAlternativas.Items.AddRange(questaoSelecionada.alternativas.ToArray());
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            string alternativa = txtResposta.Text;

            if (string.IsNullOrEmpty(alternativa))
            {
                DialogResult = DialogResult.None;
                MessageBox.Show("A alternativa não pode ser em branco");
                return;
            }

            //AlternativaQuestao alternativaQuestao = new AlternativaQuestao(alternativa);

            //questao.alternativas.Add(alternativaQuestao);

            cklAlternativas.Items.Add(alternativa);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

        }

        public List<AlternativaQuestao> ObterAlternativaCorreta()
        {
            return cklAlternativas.CheckedItems.Cast<AlternativaQuestao>().ToList();
        }

        public List<AlternativaQuestao> ObterAlternativaIncorreta()
        {
            return cklAlternativas.Items.Cast<AlternativaQuestao>().Except(ObterAlternativaCorreta()).ToList();
        }        
    }
}
