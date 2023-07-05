using MarianaTesting.Dominio.ModuloDisciplina;

namespace MarianaTesting.WinApp.ModuloDisciplina
{
    public partial class CadastroDisciplinaForm : Form
    {
        public CadastroDisciplinaForm()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {                                 
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
