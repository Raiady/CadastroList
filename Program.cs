class Program
{
    static void Main(string[] args)
    {
        List<Aluno> listCadastro = new List<Aluno>();
        int selecione;
        do
        {
            Console.WriteLine("Bem Vindo ao Cadastro do Alunos");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("1 - Novo Cadastro");
            Console.WriteLine("2 - Lista de Cadastro");
            Console.WriteLine("3 - Excluir Registro");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Digite uma Das Opções");

            selecione = int.Parse(Console.ReadLine());
            switch (selecione)
            {
                case 1:
                    Console.Write("-----------------------------------\n");
                    Console.Write("Digite o numero da Matricula: ");
                    int Id = int.Parse(Console.ReadLine());
                    Console.Write("-----------------------------------\n");
                    Console.Write("Digite o nome do aluno(a): ");
                    string Nome = Console.ReadLine();
                    Console.Write("-----------------------------------\n");
                    Console.Write("Idade do aluno: ");
                    int Idade = int.Parse(Console.ReadLine());
                    Console.Write("-----------------------------------\n");
                    Console.Write("Nome da Instituição que é vinculada a Atividade : ");
                    string NomeInstituicao = Console.ReadLine();
                    Console.Write("-----------------------------------\n");
                    Console.Write("Nome do Curso : ");
                    string NomeCurso = Console.ReadLine();
                    Console.Write("-----------------------------------\n");
                    Console.Write("Area do Curso : ");
                    string Area = Console.ReadLine();
                    Console.Write("-----------------------------------\n");
                    Console.Write("Atividades Complimentares : ");
                    string AtividadeComplementar = Console.ReadLine();
                    Console.Write("-----------------------------------\n");
                    Console.Write("Data de Admissão do Curso: ");
                    DateTime DataAdmissao = DateTime.Parse(Console.ReadLine());
                    Console.Write("-----------------------------------\n");
                    Console.Write("Data de Conclusão do Curso: ");
                    DateTime DataConclusao = DateTime.Parse(Console.ReadLine());
                    Console.Write("-----------------------------------\n");
                    Aluno novoAluno = new Aluno(Nome, Idade, NomeInstituicao, Id,
            NomeCurso, AtividadeComplementar, Area, DataAdmissao, DataConclusao);
                    listCadastro.Add(novoAluno);

                    Console.WriteLine("Aluno cadastrado com sucesso!");
                    break;
                case 2:
                    Console.WriteLine("Lista de Alunos Cadastrados:");

                    foreach (Aluno aluno in listCadastro)
                    {
                        Console.WriteLine(aluno.ToString());
                    }

                    break;

                case 0:
                    Console.WriteLine("Saindo do programa...");
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            Console.WriteLine();



        } while (selecione != 0);
    }
    class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string NomeInstituicao { get; set; }
        public string NomeCurso { get; set; }
        public string AtividadeComplementar { get; set; }
        public string Area { get; set; }
        public DateTime DataAdmissao { get; set; }
        public DateTime DataConclusao { get; set; }
        public Aluno(string nome, int idade, string nomeInstituicao, int id,
            string curso, string atividadeComplementar, string area,
            DateTime DtAdmissao, DateTime DtConclusao)
        {
            Id = id;
            Nome = nome;
            Idade = idade;
            NomeInstituicao = nomeInstituicao;
            NomeCurso = curso;
            Area = area;
            AtividadeComplementar = atividadeComplementar;
            DataAdmissao = DtAdmissao;
            DataConclusao = DtConclusao;

        }
        public override string ToString() => $"Nome:{Nome}\n Numero da Matricula:{Id}\n Idade:{Idade}" +
                $"\n Nome da Instituição:{NomeInstituicao}\n Nome do Curso:{NomeCurso}\n Area:{Area}" +
                $"\n Atividades Complementares:{AtividadeComplementar}\n Data de Admissão do Curso:{DataAdmissao}\n" +
            $" Data de Conclusão do Curso:{DataConclusao}\n --------------------------------------";
    }
}
