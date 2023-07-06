using MarianaTesting.Dominio.Compartilhado;
using MarianaTesting.Dominio.ModuloMatéria;
using MarianaTesting.Dominio.ModuloQuestoes;
using MarianaTesting.Infra.Dados.Memoria.Compartilhado;

namespace MarianaTesting.Infra.Dados.Memoria.ModuloQuestoes
{
    public class RepositorioQuestoes : RepositorioEmMemoriaBase<Questao>, IRepositorio<Questao>
    {
        public RepositorioQuestoes(List<Questao> questoes)
        {
            this.listaRegistros = questoes;
        }
    }
}
