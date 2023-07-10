using MarianaTesting.Dominio.Compartilhado;
using MarianaTesting.Dominio.ModuloDisciplina;
using MarianaTesting.Dominio.ModuloMatéria;
using MarianaTesting.Dominio.ModuloQuestoes;
using MarianaTesting.Infra.Dados.Memoria.ModuloDisciplina;
using MarianaTesting.Infra.Dados.Memoria.ModuloQuestoes;
using MarianaTesting.WinApp.Compartilhado;
using MarianaTesting.WinApp.ModuloDisciplina;
using System.Drawing.Drawing2D;

namespace MarianaTesting.WinApp.ModuloQuestoes
{
    public class ControladorQuestoes : ControladorBase
    {
        private readonly IRepositorio<Questao> repositorioQuestoes;
        private IRepositorio<Disciplina> repositorioDisciplina;
        private IRepositorio<Materia> repositorioMateria;
        private TabelaQuestoesControl tabelaQuestoes;

        public ControladorQuestoes(IRepositorio<Questao> repositorioQuestoes, IRepositorio<Disciplina> repositorioDisciplina, IRepositorio<Materia> repositorioMaterias)
        {
            this.repositorioQuestoes = repositorioQuestoes;
            this.repositorioDisciplina = repositorioDisciplina;
            this.repositorioMateria = repositorioMaterias;
        }

        public ControladorQuestoes()
        {
            
        }

        public override string ToolTipInserir => "Cadastrar nova Questão";

        public override string ToolTipEditar => "Editar uma Questão existente";

        public override string ToolTipExcluir => "Excluir uma Questão existente";

        public override void Inserir()
        {
            List<Disciplina> disciplinas = repositorioDisciplina.SelecionarTodos();
            List<Materia> materias = repositorioMateria.SelecionarTodos();

            CadastroQuestoesForm telaQuestoes = new(disciplinas, materias);

            DialogResult opcaoEscolhida = telaQuestoes.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Questao questao = telaQuestoes.ObterQuestao();

                if (questao.ValidarNomeExistente(questao, repositorioQuestoes.SelecionarTodos()))
                {
                    MessageBox.Show("Já existe uma questão com esse enunciado!");
                    Inserir();
                    return;
                }

                repositorioQuestoes.Inserir(questao);

                CarregarQuestoes();

                MessageBox.Show("Questão cadastrada com Sucesso!");
            }
        }        

        public override void Editar()
        {
            Questao questaoSelecionada = ObterQuestaoSelecionada();

            if (questaoSelecionada == null)
            {
                MessageBox.Show($"Selecione uma questão primeiro!",
                    "Edição de Questões",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            List<Disciplina> disciplinas = repositorioDisciplina.SelecionarTodos();
            List<Materia> materias = repositorioMateria.SelecionarTodos();

            CadastroQuestoesForm telaQuestoes = new CadastroQuestoesForm(disciplinas, materias);

            telaQuestoes.ConfigurarTela(questaoSelecionada);

            DialogResult opcaoEscolhida = telaQuestoes.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Questao questao = telaQuestoes.ObterQuestao();

                if (questao.ValidarNomeExistente(questao, repositorioQuestoes.SelecionarTodos()))
                {
                    MessageBox.Show("Já existe uma Questao igual");
                    return;
                }

                repositorioQuestoes.Editar(questao.id, questao);

                CarregarQuestoes();

                MessageBox.Show("Questão editada com Sucesso!");
            }
        }        

        public override void Excluir()
        {
            Questao questao = ObterQuestaoSelecionada();

            if (questao == null)
            {
                MessageBox.Show($"Selecione uma questão primeiro!",
                   "Exclusão de Questões",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a questao: {questao.nome}?", "Exclusão de Questões", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioQuestoes.Excluir(questao);

                CarregarQuestoes();

                MessageBox.Show("Questão excluída com Sucesso!");
            }
        }
        public Questao ObterQuestaoSelecionada()
        {
            int id = tabelaQuestoes.ObterIdSelecionado();
            return repositorioQuestoes.SelecionarPorId(id);
        }

        public override UserControl ObterListagem()
        {
            if(tabelaQuestoes == null)
                tabelaQuestoes = new TabelaQuestoesControl();

            CarregarQuestoes();

            return tabelaQuestoes;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Questões";
        }

        private void CarregarQuestoes()
        {
            List<Questao> questoes = repositorioQuestoes.SelecionarTodos();

            tabelaQuestoes.AtualizarRegistros(questoes);
        }
    }
}
