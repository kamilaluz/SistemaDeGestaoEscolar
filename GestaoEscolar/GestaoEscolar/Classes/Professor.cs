using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEscolar.Classes
{
    public class Professor
    {
        private int _numeroRegistro = 0;
        public string Nome { get; set; }
        public int NumeroRegistro
        {
            get { return ++_numeroRegistro; }
            set { }
        }
        public List<Disciplina> Disciplinas { get; set; }

        public Professor(string nome, int numeroRegistro)
        {
            this.Nome = nome;
            this.NumeroRegistro = numeroRegistro;
            this.Disciplinas = new List<Disciplina>();
        }


        public void Exibir()
        {
            Console.WriteLine("\nDetalhes do Professor:");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Registro: {NumeroRegistro}");
        }

        public void MostrarDisciplinasDoProfessor()
        {
            Console.WriteLine($"Disciplinas do professor :{Nome}");
            foreach (var disciplina in Disciplinas)
            {
                Console.WriteLine($"Nome: {disciplina.Nome}");
            }
        }

        public void AdicionarDisciplina(Disciplina disciplina)
        {
            Disciplinas.Add(disciplina);
        }

    }
}
