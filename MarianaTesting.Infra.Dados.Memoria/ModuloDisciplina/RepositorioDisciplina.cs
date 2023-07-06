using MarianaTesting.Dominio.Compartilhado;
using MarianaTesting.Dominio.ModuloDisciplina;
using MarianaTesting.Infra.Dados.Memoria.Compartilhado;

namespace MarianaTesting.Infra.Dados.Memoria.ModuloDisciplina
{

    public class RepositorioDisciplina : RepositorioEmMemoriaBase<Disciplina>, IRepositorio<Disciplina>
    {
        public RepositorioDisciplina(List<Disciplina> disciplinas)
        {
            this.listaRegistros = disciplinas;
        }

    }
}
