using MarianaTesting.Dominio.ModuloDisciplina;
using MarianaTesting.Dominio.ModuloMatéria;
using MarianaTesting.Dominio.ModuloQuestoes;
using System.Linq;

namespace MarianaTesting.WinApp.ModuloQuestoes
{
    public partial class CadastroQuestoesForm : Form
    {        
        public CadastroQuestoesForm(List<Disciplina> disciplinas, List<Materia> materias)
        {
            InitializeComponent();
            CarregarDisciplinas(disciplinas);
            CarregarMaterias(materias);
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
            List<string> alternativaQuestao = new();

            alternativaQuestao.AddRange(cklAlternativas.Items.Cast<string>());

            Questao questao = new Questao(enunciadoQuestao, disciplina, materia, alternativaQuestao, cklAlternativas.CheckedItems[0].ToString());

            return questao;
        }

        private void btnGravar_Click_1(object sender, EventArgs e)
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

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
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

            cklAlternativas.Items.Add(alternativa);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            cklAlternativas.Items.RemoveAt(cklAlternativas.SelectedIndex);
        }
    }
}
