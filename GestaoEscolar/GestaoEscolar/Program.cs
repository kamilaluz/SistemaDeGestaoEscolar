using GestaoEscolar.Classes;

namespace GestaoEscolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Aluno> listaAlunos = new List<Aluno>();
            List<Disciplina> listaDisciplinas = new List<Disciplina>();
            List<Professor> listaProfessores = new List<Professor>();
            List<Turma> listaTurmas = new List<Turma>();



            Console.WriteLine("-------------------------");
            Console.WriteLine("SISTEMA DE GESTÃO ESCOLAR");
            Console.WriteLine("-------------------------");

            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("\n\n------MENU PRINCIPAL-----");
                Console.WriteLine("\nEscolha uma opção: ");
                Console.WriteLine("\n1. Cadastrar");
                Console.WriteLine("2. Matricular");
                Console.WriteLine("3. Consultar");
                Console.WriteLine("4. Excluir");
                Console.WriteLine("5. Cancelar");
                int opcaoInicial = int.Parse(Console.ReadLine());
                switch (opcaoInicial)
                {
                    case 1:
                        Console.WriteLine("\n\n-------CADASTRO------");
                        Console.WriteLine("\n1. Cadastrar um novo aluno");
                        Console.WriteLine("2. Cadastrar um novo professor");
                        Console.WriteLine("3. Cadastrar uma nova disciplina");
                        Console.WriteLine("4. Cadastrar uma nova turma");
                        Console.WriteLine("5. Encerrar");

                        int opcaoCadastro = int.Parse(Console.ReadLine());
                        switch (opcaoCadastro)
                        {
                            case 1:
                                AdicionarAluno();
                                break;
                            case 2:
                                AdicionarProfessor();
                                break;
                            case 3:
                                AdicionarDisciplina();
                                break;
                            case 4:
                                AdicionarTurma();
                                break;
                            case 5:
                                continuar = false;
                                break;
                            default:
                                Console.WriteLine("Opção inválida!");
                                break;
                        }

                        break;

                    case 2:
                        Console.WriteLine("\n\n-------VÍNCULOS------");
                        Console.WriteLine("\n1. Vincular disciplina em turma");
                        Console.WriteLine("2. Vincular disciplina a um aluno");
                        Console.WriteLine("3. Matricular aluno em uma turma");
                        Console.WriteLine("4. Vincular disciplina a um professor");
                        Console.WriteLine("5. Encerrar");
                        int opcaoMatricula = int.Parse(Console.ReadLine());
                        switch (opcaoMatricula)
                        {
                            case 1:
                                VincularDisciplinaEmTurma();
                                break;
                            case 2:
                                VincularDisciplinaEmAluno();
                                break;
                            case 3:
                                MatricularAlunoEmTurma();
                                break;
                            case 4:
                                VincularDisciplinaEmProfessor();
                                break;
                            case 5:
                                continuar = false;
                                break;
                            default:
                                Console.WriteLine("Opção inválida!");
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("\n\n--------CONSULTAS-------");
                        Console.WriteLine("\n1. Exibir a lista de alunos matriculados em uma turma específica");
                        Console.WriteLine("2. Exibir a lista de disciplinas lecionadas por um professor específico");
                        Console.WriteLine("3. Exibir detalhes de um aluno");
                        Console.WriteLine("4. Exibir detalhes de um professor");
                        Console.WriteLine("5. Exibir detalhes de uma disciplina");
                        Console.WriteLine("6. Exibir detalhes de uma turma");
                        Console.WriteLine("7. Encerrar");
                        int opcaoConsulta = int.Parse(Console.ReadLine());
                        switch (opcaoConsulta)
                        {
                            case 1:
                                ExibirAlunosPorTurma();
                                break;
                            case 2:
                                ExibirDisciplinasPorProfessor();
                                break;
                            case 3:
                                ExibirDetalhesAluno();
                                break;
                            case 4:
                                ExibirDetalhesProfessor();
                                break;
                            case 5:
                                ExibirDetalhesDisciplina();
                                break;
                            case 6:
                                ExibirDetalhesTurma();
                                break;
                            case 7:
                                continuar = false;
                                break;
                            default:
                                Console.WriteLine("Opção inválida!");
                                break;
                        }

                        break;
                    case 4:
                        Console.WriteLine("\n\n--------EXCLUSÃO-------");
                        Console.WriteLine("\n1. Excluir aluno");
                        Console.WriteLine("2. Excluir professor");
                        Console.WriteLine("3. Excluir disciplina");
                        Console.WriteLine("4. Excluir turma");
                        Console.WriteLine("5. Encerrar");
                        int opcaoExclusao = int.Parse(Console.ReadLine());
                        switch (opcaoExclusao)
                        {
                            case 1:
                                ExcluirAluno();
                                break;
                            case 2:
                                ExcluirProfessor();
                                break;
                            case 3:
                                ExcluirDisciplina();
                                break;
                            case 4:
                                ExcluirTurma();
                                break;
                            case 5:
                                continuar = false;
                                break;
                            default:
                                Console.WriteLine("Opção inválida!");
                                break;
                        }
                        break;
                    case 5:
                        continuar = false;
                        break;

                }
            }
            //********************************************************************************************************
            //FUNÇÕES DE CADASTRO
            //********************************************************************************************************

            void AdicionarAluno()
            {
                Console.Write("Nome completo do aluno: ");
                string nomeAluno = Console.ReadLine();

                int matricula = 0;

                string dataNascimento = null;
                bool dataValida = false;
                while (!dataValida)
                {
                    Console.Write($"\nData de nascimento do aluno (no formato dd/mm/aaaa): ");
                    dataNascimento = Console.ReadLine();
                    if (DateTime.TryParseExact(dataNascimento, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime novaDataNascimento))
                    {
                        dataValida = true;
                        Console.WriteLine("Data de nascimento válida: " + novaDataNascimento.ToShortDateString());
                        Console.WriteLine($"Idade:  {DateTime.Now.Year - novaDataNascimento.Year} anos");
                    }
                    else
                    {
                        Console.WriteLine("Data de nascimento inválida. Certifique-se de usar o formato dd/mm/aaaa.");
                    }
                }
                Aluno aluno = new Aluno(nomeAluno, matricula, dataNascimento);
                listaAlunos.Add(aluno);
                Console.WriteLine("Aluno cadastrado com sucesso.");
            }
            void AdicionarProfessor()
            {
                Console.Write("Nome completo do professor: ");
                string nomeProfessor = Console.ReadLine();
                int registro = 0;

                Professor professor = new Professor(nomeProfessor, registro);
                listaProfessores.Add(professor);
                Console.WriteLine("Professor cadastrado com sucesso.");
            }
            void AdicionarDisciplina()
            {
                Console.Write("Nome da disciplina: ");
                string nomeDisciplina = Console.ReadLine();
                int codigoDisciplina = 0;

                Disciplina disciplina = new Disciplina(nomeDisciplina, codigoDisciplina);
                listaDisciplinas.Add(disciplina);
                Console.WriteLine("Disciplina cadastrada com sucesso.");
            }
            void AdicionarTurma()
            {
                Console.Write("Nome da turma (Formato 1º Ano/A): ");
                string nomeTurma = Console.ReadLine();

                int codigoTurma = 0;

                Turma turma = new Turma(nomeTurma, codigoTurma);
                listaTurmas.Add(turma);
            }
            //********************************************************************************************************
            //FUNÇÕES DE VINCULOS 
            //********************************************************************************************************
            void VincularDisciplinaEmTurma()
            {
                if (listaTurmas.Count == 0)
                {
                    Console.WriteLine("Não há turmas cadastradas!");
                }
                else if (listaDisciplinas.Count == 0)
                {
                    Console.WriteLine("Não há disciplinas cadastradas!");
                }
                else
                {
                    Console.WriteLine("Turmas disponíveis:");
                    for (int i = 0; i < listaTurmas.Count; i++)
                    {
                        Console.WriteLine($"{i}. {listaTurmas[i].Nome}");
                    }
                    Console.Write("Escolha o número da turma: ");
                    int numeroTurma0 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Disciplinas disponíveis:");
                    for (int i = 0; i < listaDisciplinas.Count; i++)
                    {
                        Console.WriteLine($"{i}. {listaDisciplinas[i].Nome}");
                    }
                    Console.Write("Escolha o número da disciplina: ");
                    int numeroDisciplina0 = int.Parse(Console.ReadLine());

                    foreach (var turma in listaTurmas)
                    {
                        if (listaTurmas.IndexOf(turma) == numeroTurma0)
                        {
                            foreach (var disciplina in listaDisciplinas)
                            {
                                if (listaDisciplinas.IndexOf(disciplina) == numeroDisciplina0)
                                {
                                    turma.InserirDisciplinaEmTurma(disciplina);
                                }
                            }
                        }
                    }
                }
            }
            void VincularDisciplinaEmAluno()
            {
                if (listaAlunos.Count == 0)
                {
                    Console.WriteLine("Não há alunos cadastrados!");
                }
                else if (listaDisciplinas.Count == 0)
                {
                    Console.WriteLine("Não há disciplinas cadastradas!");
                }
                else
                {
                    Console.WriteLine("Alunos disponíveis:");
                    for (int i = 0; i < listaAlunos.Count; i++)
                    {
                        Console.WriteLine($"{i}. {listaAlunos[i].Nome}");
                    }
                    Console.Write("Escolha o número da turma: ");
                    int numeroAluno = int.Parse(Console.ReadLine());

                    Console.WriteLine("Disciplinas disponíveis:");
                    for (int i = 0; i < listaDisciplinas.Count; i++)
                    {
                        Console.WriteLine($"{i}. {listaDisciplinas[i].Nome}");
                    }
                    Console.Write("Escolha o número da disciplina: ");
                    int numeroDisciplina1 = int.Parse(Console.ReadLine());

                    foreach (var aluno in listaAlunos)
                    {
                        if (listaAlunos.IndexOf(aluno) == numeroAluno)
                        {
                            foreach (var disciplina in listaDisciplinas)
                            {
                                if (listaDisciplinas.IndexOf(disciplina) == numeroDisciplina1)
                                {
                                    aluno.VincularDisciplina(disciplina);
                                }
                            }
                        }
                    }
                }
            }
            void MatricularAlunoEmTurma()
            {
                if (listaTurmas.Count == 0)
                {
                    Console.WriteLine("Não há turmas cadastradas!");
                }
                else if (listaAlunos.Count == 0)
                {
                    Console.WriteLine("Não há alunos cadastrados!");
                }
                else
                {
                    Console.WriteLine("Turmas disponíveis:");
                    for (int i = 0; i < listaTurmas.Count; i++)
                    {
                        Console.WriteLine($"{i}. {listaTurmas[i].Nome}");
                    }
                    Console.Write("Escolha o número da turma: ");
                    int numeroTurma1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Alunos disponíveis:");
                    for (int i = 0; i < listaAlunos.Count; i++)
                    {
                        Console.WriteLine($"{i}. {listaAlunos[i].Nome}");
                    }
                    Console.Write("Escolha o número do aluno: ");
                    int numeroAluno1 = int.Parse(Console.ReadLine());

                    foreach (var turma in listaTurmas)
                    {
                        if (listaTurmas.IndexOf(turma) == numeroTurma1)
                        {
                            foreach (var aluno in listaAlunos)
                            {
                                if (listaAlunos.IndexOf(aluno) == numeroAluno1)
                                {
                                    turma.MatricularAlunoEmTurma(aluno);
                                }
                            }
                        }
                    }
                }
            }
            void VincularDisciplinaEmProfessor()
            {
                if (listaDisciplinas.Count == 0)
                {
                    Console.WriteLine("Não há disciplinas cadastradas!");
                }
                else if (listaProfessores.Count == 0)
                {
                    Console.WriteLine("Não há professores cadastrados!");
                }
                else
                {
                    Console.WriteLine("Disciplinas disponíveis:");
                    for (int i = 0; i < listaDisciplinas.Count; i++)
                    {
                        Console.WriteLine($"{i}. {listaDisciplinas[i].Nome}");
                    }
                    Console.Write("Escolha o número da disciplina: ");
                    int numeroDisciplina = int.Parse(Console.ReadLine());

                    Console.WriteLine("Professores disponíveis:");
                    for (int i = 0; i < listaProfessores.Count; i++)
                    {
                        Console.WriteLine($"{i}. {listaProfessores[i].Nome}");
                    }
                    Console.Write("Escolha o número do professor: ");
                    int numeroProfessor = int.Parse(Console.ReadLine());

                    foreach (var disciplina in listaDisciplinas)
                    {
                        if (listaDisciplinas.IndexOf(disciplina) == numeroDisciplina)
                        {
                            foreach (var professor in listaProfessores)
                            {
                                if (listaProfessores.IndexOf(professor) == numeroProfessor)
                                {
                                    professor.AdicionarDisciplina(disciplina);
                                }
                            }
                        }
                    }
                }
            }

            //********************************************************************************************************
            //FUNÇÕES DE CONSULTAS 
            //********************************************************************************************************
            void ExibirAlunosPorTurma()
            {
                if (listaTurmas.Count == 0)
                {
                    Console.WriteLine("Nenhuma turma cadastrada!");
                }
                else
                {
                    Console.WriteLine("Turmas disponíveis:");
                    for (int i = 0; i < listaTurmas.Count; i++)
                    {
                        Console.WriteLine($"{i}. {listaTurmas[i].Nome}");
                    }
                    Console.Write("Escolha o número da turma: ");
                    int numeroTurma = int.Parse(Console.ReadLine());

                    foreach (var turma in listaTurmas)
                    {
                        if (listaTurmas.IndexOf(turma) == numeroTurma)
                        {
                            turma.ExibirAlunosMatriculados();
                        }
                    }
                }
            }
            void ExibirDisciplinasPorProfessor()
            {
                if (listaProfessores.Count == 0)
                {
                    Console.WriteLine("Nenhum professor cadastrado!");
                }
                else
                {
                    Console.WriteLine("Professores disponíveis:");
                    for (int i = 0; i < listaProfessores.Count; i++)
                    {
                        Console.WriteLine($"{i}. {listaProfessores[i].Nome}");
                    }
                    Console.Write("Escolha o número do professor: ");
                    int numeroProf = int.Parse(Console.ReadLine());

                    foreach (var professor in listaProfessores)
                    {
                        if (listaProfessores.IndexOf(professor) == numeroProf)
                        {
                            professor.MostrarDisciplinasDoProfessor();
                        }
                    }
                }
            }
            void ExibirDetalhesAluno()
            {
                if (listaAlunos.Count == 0)
                {
                    Console.WriteLine("Nenhum aluno cadastrado!");
                }
                else
                {
                    Console.WriteLine("Alunos disponíveis:");
                    for (int i = 0; i < listaAlunos.Count; i++)
                    {
                        Console.WriteLine($"{i}. {listaAlunos[i].Nome}");
                    }
                    Console.Write("Escolha o número do aluno: ");
                    int numeroAlunoConsultar = int.Parse(Console.ReadLine());

                    foreach (var aluno in listaAlunos)
                    {
                        if (listaAlunos.IndexOf(aluno) == numeroAlunoConsultar)
                        {
                            aluno.Exibir();
                        }
                    }
                }
            }
            void ExibirDetalhesProfessor()
            {
                if (listaProfessores.Count == 0)
                {
                    Console.WriteLine("Nenhum professor cadastrado!");
                }
                else
                {
                    Console.WriteLine("Professores disponíveis:");
                    for (int i = 0; i < listaProfessores.Count; i++)
                    {
                        Console.WriteLine($"{i}. {listaProfessores[i].Nome}");
                    }
                    Console.Write("Escolha o número do aluno: ");
                    int numeroProfessorConsultar = int.Parse(Console.ReadLine());

                    foreach (var professor in listaProfessores)
                    {
                        if (listaProfessores.IndexOf(professor) == numeroProfessorConsultar)
                        {
                            professor.Exibir();
                        }
                    }
                }
            }
            void ExibirDetalhesDisciplina()
            {
                if (listaDisciplinas.Count == 0)
                {
                    Console.WriteLine("Nenhuma disciplina cadastrada!");
                }
                else
                {
                    Console.WriteLine("Disciplinas disponíveis:");
                    for (int i = 0; i < listaDisciplinas.Count; i++)
                    {
                        Console.WriteLine($"{i}. {listaDisciplinas[i].Nome}");
                    }
                    Console.Write("Escolha o número do aluno: ");
                    int numeroDisciplinaConsultar = int.Parse(Console.ReadLine());

                    foreach (var disciplina in listaDisciplinas)
                    {
                        if (listaDisciplinas.IndexOf(disciplina) == numeroDisciplinaConsultar)
                        {
                            disciplina.Exibir();
                        }
                    }
                }
            }
            void ExibirDetalhesTurma()
            {
                if (listaTurmas.Count == 0)
                {
                    Console.WriteLine("Nenhuma turma cadastrada!");
                }
                else
                {
                    Console.WriteLine("Turmas disponíveis:");
                    for (int i = 0; i < listaTurmas.Count; i++)
                    {
                        Console.WriteLine($"{i}. {listaTurmas[i].Nome}");
                    }
                    Console.Write("Escolha o número do aluno: ");
                    int numeroTurmaConsultar = int.Parse(Console.ReadLine());

                    foreach (var turma in listaTurmas)
                    {
                        if (listaTurmas.IndexOf(turma) == numeroTurmaConsultar)
                        {
                            turma.Exibir();
                        }
                    }
                }
            }

            //********************************************************************************************************
            //FUNÇÕES DE EXCLUSÃO 
            //********************************************************************************************************

            void ExcluirAluno()
            {
                if (listaAlunos.Count == 0)
                {
                    Console.WriteLine("Nenhum aluno cadastrado!");
                }
                else
                {
                    Console.WriteLine("Alunos disponíveis:");
                    for (int i = 0; i < listaAlunos.Count; i++)
                    {
                        Console.WriteLine($"{i}. {listaAlunos[i].Nome}");
                    }
                    Console.Write("Escolha o número do aluno: ");
                    int numeroAluno = int.Parse(Console.ReadLine());

                    foreach (Aluno aluno in listaAlunos.ToList())
                    {
                        if (listaAlunos.IndexOf(aluno) == numeroAluno)
                        {
                            listaAlunos.Remove(aluno);
                            Console.Write("Aluno excluído com sucesso!");
                        }
                    }
                }
            }
            void ExcluirProfessor()
            {
                if (listaProfessores.Count == 0)
                {
                    Console.WriteLine("Nenhum professor cadastrado!");
                }
                else
                {
                    Console.WriteLine("Professores disponíveis:");
                    for (int i = 0; i < listaProfessores.Count; i++)
                    {
                        Console.WriteLine($"{i}. {listaProfessores[i].Nome}");
                    }
                    Console.Write("Escolha o número do professor: ");
                    int numeroProfessor = int.Parse(Console.ReadLine());

                    foreach (var profesor in listaProfessores.ToList())
                    {
                        if (listaProfessores.IndexOf(profesor) == numeroProfessor)
                        {
                            listaProfessores.Remove(profesor);
                            Console.Write("Professor excluído com sucesso!");
                        }
                    }
                }
            }
            void ExcluirDisciplina()
            {
                if (listaDisciplinas.Count == 0)
                {
                    Console.WriteLine("Nenhuma disciplina cadastrada!");
                }
                else
                {
                    Console.WriteLine("Disciplinas disponíveis:");
                    for (int i = 0; i < listaDisciplinas.Count; i++)
                    {
                        Console.WriteLine($"{i}. {listaDisciplinas[i].Nome}");
                    }
                    Console.Write("Escolha o número do professor: ");
                    int numeroDisciplina = int.Parse(Console.ReadLine());

                    foreach (var disciplina in listaDisciplinas.ToList())
                    {
                        if (listaDisciplinas.IndexOf(disciplina) == numeroDisciplina)
                        {
                            listaDisciplinas.Remove(disciplina);
                            Console.Write("Disciplina excluída com sucesso!");
                        }
                    }
                }
            }
            void ExcluirTurma()
            {
                if (listaTurmas.Count == 0)
                {
                    Console.WriteLine("Nenhuma turma cadastrada!");
                }
                else
                {
                    Console.WriteLine("Turmas disponíveis:");
                    for (int i = 0; i < listaTurmas.Count; i++)
                    {
                        Console.WriteLine($"{i}. {listaTurmas[i].Nome}");
                    }
                    Console.Write("Escolha o número da turma: ");
                    int numeroTurma = int.Parse(Console.ReadLine());

                    foreach (var turma in listaTurmas.ToList())
                    {
                        if (listaTurmas.IndexOf(turma) == numeroTurma)
                        {
                            listaTurmas.Remove(turma);
                            Console.Write("Turma excluída com sucesso!");

                        }
                    }
                }
            }
        }
    }
}