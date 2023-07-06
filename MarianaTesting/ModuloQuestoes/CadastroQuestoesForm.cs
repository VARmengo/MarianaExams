using MarianaTesting.Dominio.ModuloDisciplina;
using MarianaTesting.Dominio.ModuloMateria;
using MarianaTesting.Dominio.ModuloQuestoes;

namespace MarianaTesting.WinApp.ModuloQuestoes
{
    public partial class CadastroQuestoesForm : Form
    {
        public CadastroQuestoesForm(List<Disciplina> disciplinas)
        {
            InitializeComponent();
            CarregarDisciplinas(disciplinas);
            //CarregarMaterias(materias);
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

            Questao questao = new Questao(enunciadoQuestao, disciplina);

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
                MessageBox.Show(erros[0]);
                return;
            }

            if (DialogResult == DialogResult.OK)
                MessageBox.Show("Questao cadastrada com sucesso!");
        }

        public void ConfigurarTela(Questao questaoSelecionada)
        {
            txtQuestao.Text = questaoSelecionada.questao;
        }
    }
}
