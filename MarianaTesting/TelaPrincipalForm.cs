using MarianaTesting.Dominio.Compartilhado;
using MarianaTesting.Dominio.ModuloDisciplina;
using MarianaTesting.Dominio.ModuloMatéria;
using MarianaTesting.Dominio.ModuloQuestoes;
using MarianaTesting.Dominio.ModuloTeste;
using MarianaTesting.Infra.Dados.Memoria.ModuloDisciplina;
using MarianaTesting.Infra.Dados.Memoria.ModuloMatéria;
using MarianaTesting.Infra.Dados.Memoria.ModuloQuestoes;
using MarianaTesting.Infra.Dados.Memoria.ModuloTeste;
using MarianaTesting.WinApp.Compartilhado;
using MarianaTesting.WinApp.ModuloDisciplina;
using MarianaTesting.WinApp.ModuloMatéria;
using MarianaTesting.WinApp.ModuloQuestoes;
using MarianaTesting.WinApp.ModuloTeste;

namespace MarianaTesting
{
    public partial class TelaPrincipalForm : Form
    {
        private ControladorBase controlador;
        private IRepositorio<Disciplina> repositorioDisciplina = new RepositorioDisciplina(new List<Disciplina>());
        private IRepositorio<Questao> repositorioQuestoes = new RepositorioQuestao(new List<Questao>());
        private IRepositorio<Materia> repositorioMateria = new RepositorioMateria(new List<Materia>());
        private IRepositorio<Teste> repositorioTeste = new RepositorioTeste(new List<Teste>());

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
            controlador = new ControladorDisciplina(repositorioDisciplina, repositorioQuestoes);

            ConfigurarTelaPrincipal(controlador);
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            barraDeFerramenta.Visible = true;
            controlador = new ControladorMateria(repositorioMateria, repositorioDisciplina);

            ConfigurarTelaPrincipal(controlador);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {            
        }

        private void btnQuestions_Click(object sender, EventArgs e)
        {
            barraDeFerramenta.Visible = true;
            controlador = new ControladorQuestoes(repositorioQuestoes, repositorioDisciplina, repositorioMateria);

            ConfigurarTelaPrincipal(controlador);
        }

        private void btnTests_Click(object sender, EventArgs e)
        {
            barraDeFerramenta.Visible = true;
            controlador = new ControladorTeste(repositorioQuestoes, repositorioDisciplina, repositorioMateria, repositorioTeste);

            ConfigurarTelaPrincipal(controlador);
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