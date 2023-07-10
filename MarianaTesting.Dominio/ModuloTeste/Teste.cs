using MarianaTesting.Dominio.Compartilhado;
using MarianaTesting.Dominio.ModuloDisciplina;
using MarianaTesting.Dominio.ModuloMatéria;
using MarianaTesting.Dominio.ModuloQuestoes;

namespace MarianaTesting.Dominio.ModuloTeste
{
    public class Teste : EntidadeBase<Teste>
    {
        public string nome;
        public Disciplina disciplina;
        public Materia materia;
        public List<Questao> questoes;

        public Teste(string titulo, Disciplina disciplina, Materia materia, List<Questao> questoes)
        {
            this.nome = titulo;
            this.disciplina = disciplina;
            this.materia = materia;
            this.questoes = questoes;
        }

        public override void AtualizarInformacoes(Teste registroAtualizado)
        {
            this.nome = registroAtualizado.nome;
            this.disciplina = registroAtualizado.disciplina;
            this.materia = registroAtualizado.materia;
            this.questoes = registroAtualizado.questoes;
        }

        //public Teste Clonar()
        //{
        //    return MemberwiseClone() as Teste;
        //}

        public override string[] Validar()
        {
            List<string> erros = new List<string>();
            List<Teste> testes = new List<Teste>();

            if (disciplina == null)
                erros.Add("Selecione uma 'disciplina' primeiro!");

            if(materia == null)
                erros.Add("Selecione uma 'matéria' primeiro!");

            return erros.ToArray();
        }

        public bool ValidarNomeExistente(Teste teste, List<Teste> testes)
        {
            return testes.Any(t => string.Equals(t.nome, nome, StringComparison.OrdinalIgnoreCase));
        }

        public override string ToString()
        {
            return nome;
        }
    }
}
