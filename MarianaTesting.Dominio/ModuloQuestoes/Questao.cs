using MarianaTesting.Dominio.Compartilhado;
using MarianaTesting.Dominio.ModuloDisciplina;
using MarianaTesting.Dominio.ModuloMatéria;
using MarianaTesting.Dominio.ModuloTeste;

namespace MarianaTesting.Dominio.ModuloQuestoes
{
    public class Questao : EntidadeBase<Questao>
    {
        public string nome;
        public Disciplina disciplina;
        public Materia materia;
        public List<string> alternativas;
        public string alternativaCorreta;


        public Questao(string nome, Disciplina disciplina, Materia materia, List<string> alternativaQuestao, string alternativaCorreta)
        {
            this.nome = nome;
            this.disciplina = disciplina;
            this.materia = materia;
            this.alternativas = alternativaQuestao;
            this.alternativaCorreta = alternativaCorreta;
        }

        public override void AtualizarInformacoes(Questao registroAtualizado)
        {
            this.nome = registroAtualizado.nome;
            this.disciplina = registroAtualizado.disciplina;
            this.materia = registroAtualizado.materia;
            this.alternativas = registroAtualizado.alternativas;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();
            List<Questao> questoes = new List<Questao>();

            if (disciplina == null)
                erros.Add("Selecione uma 'disciplina' primeiro!");

            if (materia == null)
                erros.Add("Selecione uma 'materia' primeiro!");

            if (string.IsNullOrEmpty(nome))
                erros.Add("O campo 'enunciado' é obrigatório");


            return erros.ToArray();
        }

        public bool ValidarNomeExistente(Questao questao, List<Questao> questoes)
        {
            return questoes.Any(m => string.Equals(m.nome, nome, StringComparison.OrdinalIgnoreCase));
        }

        public override string ToString()
        {
            return nome;
        }
    }
}
