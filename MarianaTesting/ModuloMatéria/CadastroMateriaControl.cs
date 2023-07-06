using MarianaTesting.Dominio.ModuloDisciplina;
using MarianaTesting.Dominio.ModuloMatéria;

namespace MarianaTesting.WinApp.ModuloMatéria
{
    public partial class CadastroMateriaControl : Form
    {
        private Materia materia;

        public CadastroMateriaControl(List<Disciplina> disciplinas)
        {
            InitializeComponent();
            CarregarDisciplinas(disciplinas);
        }

        public Materia ObterMateria()
        {
            int id = Convert.ToInt32(txtId.Text);
            string nomeMateria = txtNomeMateria.Text;
            Disciplina disciplinaSelecionada = cmbDisciplina.SelectedItem as Disciplina;
            string serie = cmbSerie.Text;

            Materia materia = new(id, nomeMateria, disciplinaSelecionada, serie);

            if (id > 0)
                materia.id = id;

            return materia;
        }
        private void CarregarDisciplinas(List<Disciplina> disciplinas)
        {
            foreach (Disciplina disciplina in disciplinas)
                cmbDisciplina.Items.Add(disciplina);
        }
        public void ConfigurarTela(Materia materiaSelecionada)
        {
            txtId.Text = materiaSelecionada.id.ToString();
            txtNomeMateria.Text = materiaSelecionada.nome;
            cmbDisciplina.Text = materiaSelecionada.disciplina.ToString();
            cmbSerie.Text = materiaSelecionada.serie;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CadastroMateriaControl_Load(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Materia materia = ObterMateria();

            string[] erros = materia.Validar();

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
    }
}
