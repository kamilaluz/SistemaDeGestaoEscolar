using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEscolar.Classes
{
    public class Aluno
    {
        private int _numeroMatricula = 0;


        public string Nome { get; set; }
        public int NumeroMatricula
        {
            get { return ++_numeroMatricula; }
            set { }
        }
        public string DataNascimento { get; set; }

        public List<Disciplina> Disciplinas { get; set; }

        public Aluno(string nome, int numeroMatricula, string dataNascimento)
        {
            Nome = nome;
            NumeroMatricula = numeroMatricula;
            DataNascimento = dataNascimento;
            Disciplinas = new List<Disciplina>();
        }
        public void VincularDisciplina(Disciplina disciplina)
        {
            Disciplinas.Add(disciplina);
        }
        public void Exibir()
        {
            Console.WriteLine("\nDetalhes do Aluno:");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Matrícula: {NumeroMatricula}");
            Console.WriteLine($"Data de Nascimento: {DataNascimento}");
        }


    }
}
