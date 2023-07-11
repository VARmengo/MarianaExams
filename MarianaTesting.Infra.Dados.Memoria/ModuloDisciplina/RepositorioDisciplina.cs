using MarianaTesting.Dominio.Compartilhado;
using MarianaTesting.Dominio.ModuloDisciplina;
using MarianaTesting.Dominio.ModuloMatéria;
using MarianaTesting.Infra.Dados.Memoria.Compartilhado;

namespace MarianaTesting.Infra.Dados.Memoria.ModuloDisciplina
{

    public class RepositorioDisciplina : RepositorioEmMemoriaBase<Disciplina>, IRepositorio<Disciplina>
    {
        public RepositorioDisciplina(List<Disciplina> disciplinas)
        {
            this.listaRegistros = disciplinas;
        }

        public bool VerificarQuestoesAbertasDisciplina(Disciplina disciplina)
        {
            throw new NotImplementedException();
        }
        public bool VerificarQuestoesAbertasMateria(Materia materia)
        {
            throw new NotImplementedException();
        }
    }
}
