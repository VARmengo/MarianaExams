using MarianaTesting.Dominio.Compartilhado;
using MarianaTesting.Dominio.ModuloDisciplina;
using MarianaTesting.Dominio.ModuloMatéria;
using MarianaTesting.Infra.Dados.Memoria.ModuloDisciplina;
using MarianaTesting.Infra.Dados.Memoria.ModuloMatéria;
using MarianaTesting.WinApp.Compartilhado;


namespace MarianaTesting.WinApp.ModuloMatéria
{
    public class ControladorMateria : ControladorBase
    {
        private IRepositorio<Materia> repositorioMateria;
        private IRepositorio<Disciplina> repositorioDisciplina;
        private TabelaMateriaControl tabelaMaterias;

        public ControladorMateria(IRepositorio<Materia> repositorioMateria, IRepositorio<Disciplina> repositorioDisciplina)
        {
            this.repositorioMateria = repositorioMateria;
            this.repositorioDisciplina = repositorioDisciplina;
        }

        public override string ToolTipInserir => "Cadastrar noa Matéria";

        public override string ToolTipEditar => "Editar uma Matéria existente";

        public override string ToolTipExcluir => "Excluir uma Matéria existente";

        public override void Inserir()
        {
            List<Disciplina> disciplinas = repositorioDisciplina.SelecionarTodos();
            CadastroMateriaControl telaMateria = new(disciplinas);

            DialogResult opcaoEscolhida = telaMateria.ShowDialog();
            
            if (opcaoEscolhida == DialogResult.OK)
            {
                Materia materia = telaMateria.ObterMateria();

                if (materia.ValidarNomeExistente(materia, repositorioMateria.SelecionarTodos()))
                {
                    MessageBox.Show("Já existe uma Materia com este nome");
                    return;
                }

                repositorioMateria.Inserir(materia);

                CarregarMaterias();

                MessageBox.Show("Matéria cadastrada com Sucesso!");
            }
        }
        public override void Editar()
        {
            Materia materiaSelecionada = ObterMateriaSelecionada();

            if (materiaSelecionada == null)
            {
                MessageBox.Show($"Selecione uma matéria primeiro!",
                    "Edicação de Matérias",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            List<Disciplina> disciplinas = repositorioDisciplina.SelecionarTodos();
            CadastroMateriaControl telaMateria = new CadastroMateriaControl(disciplinas);
            telaMateria.ConfigurarTela(materiaSelecionada);

            DialogResult opcaoEscolhida = telaMateria.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Materia materia = telaMateria.ObterMateria();

                if (materia.ValidarNomeExistente(materia, repositorioMateria.SelecionarTodos()))
                {
                    MessageBox.Show("Já existe uma Materia com este nome");
                    return;
                }

                repositorioMateria.Editar(materia.id, materia);

                CarregarMaterias();

                MessageBox.Show("Matéria editada com Sucesso!");
            }
        }
        public override void Excluir()
        {
            Materia materia = ObterMateriaSelecionada();

            if (materia == null)
            {
                MessageBox.Show($"Selecione uma matéria primeiro!",
                   "Exclusão de Matérias",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a matéria: {materia.nome}?", "Exclusão de Matérias", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioMateria.Excluir(materia);

                CarregarMaterias();

                MessageBox.Show("Matéria excluída com Sucesso!");
            }
        }
        public override UserControl ObterListagem()
        {
            if (tabelaMaterias == null)
                tabelaMaterias = new TabelaMateriaControl();

            CarregarMaterias();

            return tabelaMaterias;
        }
        public override string ObterTipoCadastro()
        {
            return "Cadastro de Matéria";
        }
        private void CarregarMaterias()
        {
            List<Materia> materias = repositorioMateria.SelecionarTodos();

            tabelaMaterias.AtualizarRegistros(materias);
        }
        private Materia ObterMateriaSelecionada()
        {
            int id = tabelaMaterias.ObterIdSelecionado();
            return repositorioMateria.SelecionarPorId(id);
        }
    }
}
