using MarianaTesting.Dominio.Compartilhado;
using MarianaTesting.Infra.Dados.Memoria.Compartilhado;
using MarianaTesting.Dominio.ModuloTeste;
using MarianaTesting.Dominio.ModuloDisciplina;
using MarianaTesting.Dominio.ModuloQuestoes;

namespace MarianaTesting.Infra.Dados.Memoria.ModuloTeste
{
    public class RepositorioTeste : RepositorioEmMemoriaBase<Teste>, IRepositorio<Teste>
    {
        public RepositorioTeste(List<Teste> testes)
        {
            this.listaRegistros = testes;
        }

        public bool VerificarQuestoesAbertasDisciplina(Disciplina disciplina)
        {
            throw new NotImplementedException();
        }
    }
}
