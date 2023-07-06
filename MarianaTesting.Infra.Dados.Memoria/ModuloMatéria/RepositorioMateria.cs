using MarianaTesting.Dominio.ModuloDisciplina;
using MarianaTesting.Dominio.ModuloMatéria;
using MarianaTesting.Infra.Dados.Memoria.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarianaTesting.Infra.Dados.Memoria.ModuloMatéria
{
    public class RepositorioMateria : RepositorioEmMemoriaBase<Materia>
    {
        public RepositorioMateria(List<Materia> materias)
        {
            this.listaRegistros = materias;
        }
    }
}
