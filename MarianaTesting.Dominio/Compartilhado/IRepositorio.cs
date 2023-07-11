using MarianaTesting.Dominio.ModuloDisciplina;
using MarianaTesting.Dominio.ModuloMatéria;

namespace MarianaTesting.Dominio.Compartilhado
{
    public interface IRepositorio<TEntidade> where TEntidade : EntidadeBase<TEntidade>
    {
        void Inserir(TEntidade registro);

        void Editar(TEntidade registroSelecionado, TEntidade registroAtualizado);

        void Editar(int id, TEntidade registroAtualizado);

        void Excluir(TEntidade registroSelecionado);

        List<TEntidade> SelecionarTodos();

        TEntidade SelecionarPorId(int id);
        bool VerificarQuestoesAbertasDisciplina(Disciplina disciplina);
        bool VerificarQuestoesAbertasMateria(Materia materia);
    }
}
