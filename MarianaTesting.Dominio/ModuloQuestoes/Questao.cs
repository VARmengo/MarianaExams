using MarianaTesting.Dominio.Compartilhado;
using MarianaTesting.Dominio.ModuloDisciplina;
using MarianaTesting.Dominio.ModuloMateria;

namespace MarianaTesting.Dominio.ModuloQuestoes
{
    public class Questao : EntidadeBase<Questao>
    {
        public string questao;
        public Disciplina disciplina;
        //public Materia materia;

        public Questao(string questao, Disciplina disciplina)
        {
            this.questao = questao;
            this.disciplina = disciplina;
            //this.materia = materia;
        }

        public override void AtualizarInformacoes(Questao registroAtualizado)
        {
            this.questao = registroAtualizado.questao;
            this.disciplina = registroAtualizado.disciplina;
            //this.materia = registroAtualizado.materia;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();
            List<Questao> questoes = new List<Questao>();

            if (string.IsNullOrEmpty(questao))
                erros.Add("O campo 'enunciado' é obrigatório");

            return erros.ToArray();
        }
    }
}
