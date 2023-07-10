using MarianaTesting.Dominio.Compartilhado;
using MarianaTesting.Dominio.ModuloDisciplina;
using MarianaTesting.Dominio.ModuloQuestoes;

namespace MarianaTesting.Dominio.ModuloMatéria
{
    public class Materia : EntidadeBase<Materia>
    {
        public string nome;
        public Disciplina disciplina;
        public string serie;
        public List<Questao> listaQuestoes;

        public Materia(int id, string nome, Disciplina disciplina, string serie)
        {
            this.nome = nome;
            this.disciplina = disciplina;
            this.serie = serie;
        }

        public override void AtualizarInformacoes(Materia registroAtualizado)
        {
            this.nome = registroAtualizado.nome;
            this.disciplina = registroAtualizado.disciplina;
            this.serie = registroAtualizado.serie;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();
            List<Materia> materias = new List<Materia>();

            if (string.IsNullOrEmpty(nome))
                erros.Add("O campo 'nome' é obrigatório");    
            
            if (disciplina == null)
                erros.Add("Selecione uma 'disciplina'");    
            
            if (string.IsNullOrEmpty(serie))
                erros.Add("Selecione uma 'série'");    


            return erros.ToArray();
        }

        public bool ValidarNomeExistente(Materia materia, List<Materia> materias)
        {
            return materias.Any(m => string.Equals(m.nome, materia.nome, StringComparison.OrdinalIgnoreCase) && m.disciplina == materia.disciplina && m.serie == materia.serie);
        }

        public override string ToString()
        {
            return nome + " " + serie;
        }
    }
}
