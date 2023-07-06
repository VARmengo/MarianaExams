using MarianaTesting.Dominio.Compartilhado;
using MarianaTesting.Dominio.ModuloDisciplina;
using MarianaTesting.Infra.Dados.Memoria.ModuloDisciplina;
using MarianaTesting.WinApp.Compartilhado;

namespace MarianaTesting.WinApp.ModuloDisciplina
{
    public class ControladorDisciplina : ControladorBase
    {
        private IRepositorio<Disciplina> repositorioDisciplina;
        private TabelaDisciplinaControl tabelaDisciplinas;

        public override string ToolTipInserir => "Cadastrar nova Disciplina";

        public override string ToolTipEditar => "Editar uma Disciplina existente";

        public override string ToolTipExcluir => "Excluir uma Disciplina Existente";

        public ControladorDisciplina(IRepositorio<Disciplina> repositorioDisciplina)
        {
            this.repositorioDisciplina = repositorioDisciplina;
        }

        public override void Inserir()
        {
            CadastroDisciplinaControl telaDisciplina = new();

            DialogResult opcaoEscolhida = telaDisciplina.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Disciplina disciplina = telaDisciplina.ObterDisciplina();

                if (disciplina.ValidarNomeExistente(disciplina.disciplina, repositorioDisciplina.SelecionarTodos()))
                {
                    MessageBox.Show("Já existe uma Disciplina com este nome");
                    Inserir();
                    return;
                }
                    

                repositorioDisciplina.Inserir(disciplina);

                CarregarDisciplinas();

                MessageBox.Show("Disciplina cadastrada com Sucesso!");
            }
        }

        public override void Editar()
        {
            Disciplina disciplinaSelecionada = ObterDisciplinaSelecionada();

            if (disciplinaSelecionada == null)
            {
                MessageBox.Show($"Selecione uma disciplina primeiro!",
                    "Edicação de Disciplinas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            CadastroDisciplinaControl telaDisciplina = new CadastroDisciplinaControl();
            telaDisciplina.ConfigurarTela(disciplinaSelecionada);

            DialogResult opcaoEscolhida = telaDisciplina.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Disciplina disciplina = telaDisciplina.ObterDisciplina();

                if (disciplina.ValidarNomeExistente(disciplina.disciplina, repositorioDisciplina.SelecionarTodos()))
                {
                    MessageBox.Show("Já existe uma Disciplina com este nome");
                    Inserir();
                    return;
                }

                repositorioDisciplina.Editar(disciplina.id, disciplina);

                CarregarDisciplinas();

                MessageBox.Show("Disciplina editada com Sucesso!");
            }
        }

        private Disciplina ObterDisciplinaSelecionada()
        {
            int id = tabelaDisciplinas.ObterIdSelecionado();
            return repositorioDisciplina.SelecionarPorId(id);
        }

        public override void Excluir()
        {
            Disciplina disciplina = ObterDisciplinaSelecionada();

            if (disciplina == null)
            {
                MessageBox.Show($"Selecione uma disciplina primeiro!",
                   "Exclusão de Disciplinas",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a disciplina: {disciplina.disciplina}?", "Exclusão de Disciplinas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioDisciplina.Excluir(disciplina);

                CarregarDisciplinas();

                MessageBox.Show("Disciplina excluída com Sucesso!");
            }
        }              

        public override UserControl ObterListagem()
        {
            if(tabelaDisciplinas == null)
                tabelaDisciplinas = new TabelaDisciplinaControl();

            CarregarDisciplinas();

            return tabelaDisciplinas;
        }

        private void CarregarDisciplinas()
        {
            List<Disciplina> disciplinas = repositorioDisciplina.SelecionarTodos();

            tabelaDisciplinas.AtualizarRegistros(disciplinas);
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Disciplina";
        }
    }
}
