using MarianaTesting.Dominio.Compartilhado;
using MarianaTesting.Dominio.ModuloDisciplina;
using MarianaTesting.Dominio.ModuloMatéria;
using MarianaTesting.Dominio.ModuloQuestoes;
using MarianaTesting.Dominio.ModuloTeste;
using MarianaTesting.Infra.Dados.Memoria.ModuloDisciplina;
using MarianaTesting.Infra.Dados.Memoria.ModuloMatéria;
using MarianaTesting.WinApp.Compartilhado;
using MarianaTesting.WinApp.ModuloMatéria;
using MarianaTesting.WinApp.ModuloQuestoes;

namespace MarianaTesting.WinApp.ModuloTeste
{
    public class ControladorTeste : ControladorBase
    {
        private IRepositorio<Questao> repositorioQuestoes;
        private IRepositorio<Disciplina> repositorioDisciplina;
        private IRepositorio<Materia> repositorioMateria;
        private IRepositorio<Teste> repositorioTeste;
        private TabelaTesteControl tabelaTeste;

        public ControladorTeste(IRepositorio<Questao> repositorioQuestoes, IRepositorio<Disciplina> repositorioDisciplina, IRepositorio<Materia> repositorioMateria, IRepositorio<Teste> repositorioTeste)
        {
            this.repositorioQuestoes = repositorioQuestoes;
            this.repositorioDisciplina = repositorioDisciplina;
            this.repositorioMateria = repositorioMateria;
            this.repositorioTeste = repositorioTeste;
        }

        public override string ToolTipInserir => "Cadastrar um novo Teste";

        public override string ToolTipEditar => "Editar um Teste existente";

        public override string ToolTipExcluir => "Excluir um Teste existente";

        public override void Inserir()
        {
            List<Disciplina> disciplinas = repositorioDisciplina.SelecionarTodos();
            List<Materia> materias = repositorioMateria.SelecionarTodos();
            List<Questao> questoesDisponiveis = repositorioQuestoes.SelecionarTodos();

            CadastroTestesForm telaTeste = new(disciplinas, materias, questoesDisponiveis);

            DialogResult opcaoEscolhida = telaTeste.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Teste teste = telaTeste.ObterTeste();

                if (teste.ValidarNomeExistente(teste, repositorioTeste.SelecionarTodos()))
                {
                    MessageBox.Show("Já existe um teste com esse titulo!");
                    Inserir();
                    return;
                }

                repositorioTeste.Inserir(teste);

                CarregarTestes();

                MessageBox.Show("Teste cadastrado com Sucesso!");
            }
        }        

        public override void Editar()
        {
            Teste testeSelecionado = ObterTesteSelecionado();

            if (testeSelecionado == null)
            {
                MessageBox.Show($"Selecione um teste primeiro!",
                    "Edição de Testes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            List<Disciplina> disciplinas = repositorioDisciplina.SelecionarTodos();
            List<Materia> materias = repositorioMateria.SelecionarTodos();
            List<Questao> questoesDisponiveis = repositorioQuestoes.SelecionarTodos();

            CadastroTestesForm telaTeste = new CadastroTestesForm(disciplinas, materias, questoesDisponiveis);

            telaTeste.ConfigurarTela(testeSelecionado);

            DialogResult opcaoEscolhida = telaTeste.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Teste teste = telaTeste.ObterTeste();

                if (teste.ValidarNomeExistente(teste, repositorioTeste.SelecionarTodos()))
                {
                    MessageBox.Show("Já existe um Teste com esse titulo");
                    return;
                }

                repositorioTeste.Editar(teste.id, teste);

                CarregarTestes();

                MessageBox.Show("Teste editado com Sucesso!");
            }
        }

        public override void Excluir()
        {
            Teste teste = ObterTesteSelecionado();

            if (teste == null)
            {
                MessageBox.Show($"Selecione uma matéria primeiro!",
                   "Exclusão de Matérias",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o testes: {teste.nome}?", "Exclusão de Testes", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioTeste.Excluir(teste);

                CarregarTestes();

                MessageBox.Show("Matéria excluída com Sucesso!");
            }
        }

        private Teste ObterTesteSelecionado()
        {
            int id = tabelaTeste.ObterIdSelecionado();
            return repositorioTeste.SelecionarPorId(id);
        }        

        private void CarregarTestes()
        {
            List<Teste> testes = repositorioTeste.SelecionarTodos();

            tabelaTeste.AtualizarRegistros(testes);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaTeste == null)
                tabelaTeste = new TabelaTesteControl();

            CarregarTestes();

            return tabelaTeste;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Teste";
        }
    }
}
