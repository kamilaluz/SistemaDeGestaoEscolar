using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEscolar.Classes
{
    public class Turma
    {
        private int _codigo;
        public string Nome { get; set; }
        public int Codigo
        {
            get { return ++_codigo; }
            set { }
        }
        public List<Disciplina> Disciplinas { get; set; }
        public Professor Professor { get; set; }
        public List<Aluno> Alunos { get; set; }

        public Turma(string nome, int codigo)
        {
            this.Nome = nome;
            this.Codigo = codigo;
            this.Disciplinas = new List<Disciplina>();
            this.Professor = Professor;
            this.Alunos = new List<Aluno>();

        }

        public void Exibir()
        {
            Console.WriteLine("\nDetalhes da turma:");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Código: {Codigo}");
            ExibirAlunosMatriculados();
        }

        public void ExibirAlunosMatriculados()
        {
            if (Alunos.Count == 0)
            {
                Console.WriteLine("Nenhum aluno matriculado!");
            }
            else
            {
                Console.WriteLine($"Alunos matriculados na turma :{Nome}");
                foreach (var aluno in Alunos)
                {
                    Console.WriteLine($"Nome: {aluno.Nome}");
                }
            }

        }
        public void InserirDisciplinaEmTurma(Disciplina disciplina)
        {
            Disciplinas.Add(disciplina);
        }

        public void MatricularAlunoEmTurma(Aluno aluno)
        {
            Alunos.Add(aluno);
        }
    }
}
