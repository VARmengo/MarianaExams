using MarianaTesting.Dominio.Compartilhado;
using MarianaTesting.Dominio.ModuloDisciplina;
using MarianaTesting.Dominio.ModuloMatéria;
using MarianaTesting.Infra.Dados.Memoria.Compartilhado;

namespace MarianaTesting.Infra.Dados.Memoria.ModuloMatéria
{
    public class RepositorioMateria : RepositorioEmMemoriaBase<Materia>, IRepositorio<Materia>
    {
        public RepositorioMateria(List<Materia> materias)
        {
            this.listaRegistros = materias;
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
