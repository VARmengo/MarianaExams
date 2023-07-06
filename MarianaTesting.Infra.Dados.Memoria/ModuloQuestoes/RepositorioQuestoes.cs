using MarianaTesting.Dominio.ModuloQuestoes;
using MarianaTesting.Infra.Dados.Memoria.Compartilhado;

namespace MarianaTesting.Infra.Dados.Memoria.ModuloQuestoes
{
    public class RepositorioQuestoes : RepositorioEmMemoriaBase<Questao>
    {
        public RepositorioQuestoes(List<Questao> questoes)
        {
            this.listaRegistros = questoes;
        }
    }
}
