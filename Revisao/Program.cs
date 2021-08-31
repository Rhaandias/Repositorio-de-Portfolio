using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            int indicedealuno=0;
                       
            
            string opcaousuario = ObterOpcaoUsuario(); //Console.Readline() - é tipo String.
                                                 //var - se torna tipo de valor igual 
                                                 //ao tipo de valor que recebe   

            while (opcaousuario!="0")
            {
                if(opcaousuario=="1")
                {
                    Console.WriteLine();
                    Console.WriteLine("Nome do aluno:");
                    Aluno aluno = new Aluno();
                    aluno.Nome=Console.ReadLine();

                    Console.WriteLine("Nota do aluno:");
                    
                    
                    if(decimal.TryParse(Console.ReadLine(), out decimal Nota))
                    {
                        aluno.Nota=Nota;

                    }else
                    {
                        throw new ArgumentOutOfRangeException("Valor da nota deve ser decimal");
                    }
                    alunos[indicedealuno]=aluno;
                     indicedealuno++; 


                }
                else if(opcaousuario=="2")
                {
                    Console.WriteLine();
                    foreach (var a in alunos)
                    {
                        if (!string.IsNullOrEmpty(a.Nome))
                        {
                            Console.WriteLine($"Aluno: {a.Nome} - Nota: {a.Nota}");
                            
                        }
                        
                        
                    }

                }
                else if(opcaousuario=="3")
                {
                    decimal somanota=0, mediageral;
                    int numbaluno=0;
                    for(int i=0;i<alunos.Length;i++)
                    {
                        if (!string.IsNullOrEmpty(alunos[i].Nome))
                        {
                            somanota= somanota + alunos[i].Nota;
                            numbaluno++;
                        }

                    }
                    mediageral = somanota / numbaluno; 
                    Console.WriteLine($"Média Geral: {mediageral}");

                }else
                {
                    throw new ArgumentOutOfRangeException();
                }

                Console.WriteLine();
                opcaousuario=ObterOpcaoUsuario();
                
            }

        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Escolha a opção desejada:");
            Console.WriteLine("1 - Cadastrar Aluno e Nota");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Média Geral");
            Console.WriteLine("0 - Sair");
            Console.WriteLine();

            String opcaousuario = Console.ReadLine();
            return opcaousuario;


        }
    }
}
