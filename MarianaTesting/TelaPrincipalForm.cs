using MarianaTesting.Dominio.ModuloDisciplina;
using MarianaTesting.Dominio.ModuloQuestoes;
using MarianaTesting.Infra.Dados.Memoria.ModuloDisciplina;
using MarianaTesting.Infra.Dados.Memoria.ModuloQuestoes;
using MarianaTesting.WinApp.Compartilhado;
using MarianaTesting.WinApp.ModuloDisciplina;
using MarianaTesting.WinApp.ModuloQuestoes;
using System.Windows.Forms;

namespace MarianaTesting
{
    public partial class TelaPrincipalForm : Form
    {
        private ControladorBase controlador;
        private RepositorioDisciplina repositorioDisciplina = new RepositorioDisciplina(new List<Disciplina>());
        private RepositorioQuestoes repositorioQuestoes = new RepositorioQuestoes(new List<Questao>());

        private static TelaPrincipalForm telaPrincipal;

        public static TelaPrincipalForm Principal
        {
            get
            {
                if (telaPrincipal == null)
                    telaPrincipal = new TelaPrincipalForm();

                return telaPrincipal;
            }
        }

        public TelaPrincipalForm()
        {
            InitializeComponent();
            barraDeFerramenta.Visible = false;
        }

        private void btnDisciplinas_Click(object sender, EventArgs e)
        {
            barraDeFerramenta.Visible = true;
            controlador = new ControladorDisciplina(repositorioDisciplina);

            ConfigurarTelaPrincipal(controlador);
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            PrimeiraTelaControl primeiroPainel = new PrimeiraTelaControl();
            primeiroPainel.Show();
        }

        private void btnQuestions_Click(object sender, EventArgs e)
        {
            barraDeFerramenta.Visible = true;
            controlador = new ControladorQuestoes(repositorioQuestoes, repositorioDisciplina);

            ConfigurarTelaPrincipal(controlador);
        }

        private void btnTests_Click(object sender, EventArgs e)
        {

        }

        private void ConfigurarListagem(ControladorBase controladorBase)
        {
            UserControl listagem = controladorBase.ObterListagem();

            painelDashboard.Controls.Clear();
            painelDashboard.Controls.Add(listagem);
        }

        private void ConfigurarTelaPrincipal(ControladorBase controladorBase)
        {
            labelTitle.Text = controlador.ObterTipoCadastro();
            ConfigurarToolTips(controlador);
            ConfigurarListagem(controlador);
        }

        private void ConfigurarToolTips(ControladorBase controlador)
        {
            btnAdicionar.ToolTipText = controlador.ToolTipInserir;
            btnEditar.ToolTipText = controlador.ToolTipEditar;
            btnExcluir.ToolTipText = controlador.ToolTipExcluir;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            controlador.Inserir();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (controlador == null)
            {
                MessageBox.Show("Escolha um cadastro primeiro!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            controlador.Editar();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }
    }
}