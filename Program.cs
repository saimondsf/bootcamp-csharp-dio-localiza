using System;

namespace BootcampLocaliza
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;

            string opcaoUsuario = ObterOpcaoUsuario();

            while(opcaoUsuario.ToUpper() != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1": //Insere um novo aluno
                        Console.WriteLine("Informe o nome do aluno:");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota do aluno:");
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentOutOfRangeException("O valor da nota deve ser decimal");
                        }
                        
                        alunos[indiceAluno] = aluno;
                        indiceAluno++;

                        break;

                    case "2": //Exibe a lista de alunos
                        foreach (var item in alunos)
                        {
                            if (!string.IsNullOrEmpty(item.Nome))
                            {
                                Console.WriteLine($"Aluno: {item.Nome} - Nota: {item.Nota}");
                            }
                        }
                        break;

                    case "3": //Calcula e exibe a média geral
                        decimal notaTotal = 0;
                        var numeroDeAlunos = 0;

                        for (int i = 0; i < alunos.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                notaTotal = notaTotal + alunos[i].Nota;
                                numeroDeAlunos++;
                            }
                        }

                        var mediaGeral = notaTotal / numeroDeAlunos;
                        Conceito conceitoGeral;
                        
                        if (mediaGeral<2)
                        {
                            conceitoGeral = Conceito.E;
                        }
                        else if(mediaGeral<4)
                        {
                            conceitoGeral = Conceito.D;
                        }
                        else if(mediaGeral<6)
                        {
                            conceitoGeral = Conceito.C;
                        }
                        else if(mediaGeral<8)
                        {
                            conceitoGeral = Conceito.B;
                        }
                        else
                        {
                            conceitoGeral = Conceito.A;
                        }

                        Console.WriteLine($"Média: {mediaGeral} - Conceito: {conceitoGeral}");

                        break;

                    default:
                        throw new ArgumentOutOfRangeException();    
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("\nInforme a opção desejada:");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X - Sair\n");

            string opcaoUsuarioFunc = Console.ReadLine();
            Console.Write("\n");
            return opcaoUsuarioFunc;
        }
    }
}