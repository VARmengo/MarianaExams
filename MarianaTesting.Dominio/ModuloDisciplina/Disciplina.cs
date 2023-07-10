using MarianaTesting.Dominio.Compartilhado;
//using MarianaTesting.Dominio.ModuloMateria;

namespace MarianaTesting.Dominio.ModuloDisciplina
{
    public class Disciplina : EntidadeBase<Disciplina>
    {
        public string disciplina;
       // public List<Materia> materia;

        public Disciplina(string disciplina)
        {
            this.disciplina = disciplina;
            //this.materia = new List<Materia>();
        }

        public Disciplina(int id, string disciplina)
        {
            this.disciplina = disciplina;
        }

        public override void AtualizarInformacoes(Disciplina registroAtualizado)
        {
            this.disciplina = registroAtualizado.disciplina;
            //this.materia.Clear();
            //this.materia = registroAtualizado.materia;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();
            List<Disciplina> disciplinas = new List<Disciplina>();

            if (string.IsNullOrEmpty(disciplina))
                erros.Add("O campo 'disciplina' é obrigatório");
                                    
            return erros.ToArray();
        }

        public override string ToString()
        {
            return disciplina;
        }

        public bool ValidarNomeExistente(string nome, List<Disciplina> listaDisciplinas)
        {
            return listaDisciplinas.Any(m => string.Equals(m.disciplina, nome, StringComparison.OrdinalIgnoreCase));
        }
    }
}
