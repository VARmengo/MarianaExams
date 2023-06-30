using MarianaTesting.Dominio.Compartilhado;

namespace MarianaTesting.Infra.Dados.Memoria.Compartilhado
{
    public abstract class RepositorioEmMemoriaBase<TEntidade>
            where TEntidade : EntidadeBase<TEntidade>
    {
        protected List<TEntidade> listaRegistros;
        protected int contadorRegistros = 0;

        protected RepositorioEmMemoriaBase(List<TEntidade> listaRegistros)
        {
            this.listaRegistros = listaRegistros;
            contadorRegistros = listaRegistros.Count;
        }

        public virtual void Inserir(TEntidade registro)
        {
            contadorRegistros++;

            registro.id = contadorRegistros;

            listaRegistros.Add(registro);
        }

        public virtual void Editar(TEntidade registroSelecionado, TEntidade registroAtualizado)
        {
            registroSelecionado.AtualizarInformacoes(registroAtualizado);
        }

        public virtual void Excluir(TEntidade registroSelecionado)
        {
            listaRegistros.Remove(registroSelecionado);
        }

        public virtual List<TEntidade> SelecionarTodos()
        {
            return listaRegistros.OrderBy(x => x.id).ToList();
        }
    }
}
