using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEscolar.Classes
{
    public class Disciplina
    {
        private int _codigo = 0;
        public string Nome { get; set; }
        public int Codigo
        {
            get { return ++_codigo; }
            set { }
        }
        public Professor ProfessorAssociado { get; set; }
        public Disciplina(string nome, int codigo)
        {
            this.Nome = nome;
            this.Codigo = codigo;
        }

        public void Exibir()
        {
            Console.WriteLine("Detalhes da disciplina:");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Matrícula: {Codigo}");
        }
    }
}
