using MarianaTesting.Dominio.ModuloDisciplina;
using MarianaTesting.Dominio.ModuloMateria;
using MarianaTesting.Dominio.ModuloQuestoes;
using MarianaTesting.Infra.Dados.Memoria.ModuloDisciplina;
using MarianaTesting.Infra.Dados.Memoria.ModuloQuestoes;
using MarianaTesting.WinApp.Compartilhado;
using MarianaTesting.WinApp.ModuloDisciplina;

namespace MarianaTesting.WinApp.ModuloQuestoes
{
    public class ControladorQuestoes : ControladorBase
    {
        private RepositorioQuestoes repositorioQuestoes;
        private TabelaQuestoesControl tabelaQuestoes;
        private RepositorioDisciplina repositorioDisciplina;
        //private RepositorioMateria repositorioMateria;

        public ControladorQuestoes(RepositorioQuestoes repositorioQuestoes, RepositorioDisciplina repositorioDisciplina)
        {
            this.repositorioQuestoes = repositorioQuestoes;
            this.repositorioDisciplina = repositorioDisciplina;
        }

        public override string ToolTipInserir => "Cadastrar nova Questão";

        public override string ToolTipEditar => "Editar uma Questão existente";

        public override string ToolTipExcluir => "Excluir uma Questão existente";

        public override void Inserir()
        {
            List<Disciplina> disciplinas = repositorioDisciplina.SelecionarTodos();
            //List<Materia> materias = repositorioMateria.SelecionarTodos();

            CadastroQuestoesForm telaQuestoes = new(disciplinas);

            DialogResult opcaoEscolhida = telaQuestoes.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Questao questao = telaQuestoes.ObterQuestao();

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
                    "Edicação de Questões",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            List<Disciplina> disciplinas = repositorioDisciplina.SelecionarTodos();
            //List<Materia> materias = repositorioMateria.SelecionarTodos();

            CadastroQuestoesForm telaQuestoes = new CadastroQuestoesForm(disciplinas);

            telaQuestoes.ConfigurarTela(questaoSelecionada);

            DialogResult opcaoEscolhida = telaQuestoes.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Questao questao = telaQuestoes.ObterQuestao();

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

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a questao: {questao.questao}?", "Exclusão de Disciplinas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioQuestoes.Excluir(questao);

                CarregarQuestoes();

                MessageBox.Show("Questão excluída com Sucesso!");
            }
        }
        private Questao ObterQuestaoSelecionada()
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
