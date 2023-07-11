using MarianaTesting.Dominio.Compartilhado;
using MarianaTesting.Dominio.ModuloDisciplina;
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

        public bool VerificarQuestoesAbertasDisciplina(Disciplina disciplina)
        {
            return listaRegistros
                .Any(Questao => Questao.disciplina == disciplina) == false;
        }

        public bool VerificarQuestoesAbertasMateria(Materia materia)
        {
            return listaRegistros
                .Any(Questao => Questao.materia == materia) == false;
        }
    }
}
