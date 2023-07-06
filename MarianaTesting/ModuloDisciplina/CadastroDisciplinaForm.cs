using MarianaTesting.Dominio.ModuloDisciplina;
using MarianaTesting.Dominio.ModuloMatéria;

namespace MarianaTesting.WinApp.ModuloDisciplina
{
    public partial class CadastroDisciplinaControl : Form
    {
        public CadastroDisciplinaControl()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Disciplina disciplina = ObterDisciplina();

            string[] erros = disciplina.Validar();

            if (erros.Length > 0)
            {
                AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
                return;
            }
        }

        public void AtualizarRodape(string mensagem)
        {
            labelRodape.Text = mensagem;
        }

        public Disciplina ObterDisciplina()
        {
            int id = Convert.ToInt32(txtId.Text);
            string nomeDisciplina = txtNomeDisciplina.Text;

            Disciplina disciplina = new(id, nomeDisciplina);

            if (id > 0)
                disciplina.id = id;

            return disciplina;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void ConfigurarTela(Disciplina disciplinaSelecionada)
        {
            txtId.Text = disciplinaSelecionada.id.ToString();
            txtNomeDisciplina.Text = disciplinaSelecionada.disciplina;
        }
    }
}
