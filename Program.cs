using System;
using System.Collections.Generic;

namespace DIO.Series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();

        static void Main(string[] args)
        {
            string opcaoUsuario = obterOpcaoUsuario();
            
            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario) 
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                        AtualizarSerie();
                        break;
                    case "4":
                        ExcluirSerie();
                        break;
                    case "5":
                        VisualizarSeries();
                        break;
                    case "6":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();                     
                }
                opcaoUsuario = obterOpcaoUsuario();
            }
            
            static void InserirSerie()
            {
                Console.WriteLine("Cadastrar nova Série");

                foreach (int i in Enum.GetValues(typeof(Genero)))
                {
                    Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
                }
                Console.Write("Digite o genero da série entre as opções acima: ");
                int entraGenero = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o título da Série: ");
                string entraTitulo = Console.ReadLine();

                Console.WriteLine("Digite o ano da Série: ");
                int entradaAno = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a Descrição da Série: ");
                string entradaDescricao = Console.ReadLine();

                Series novaSerie = new Series(repositorio.ProximoId(), (Genero)entraGenero, entraTitulo, entradaDescricao, entradaAno);
                
                repositorio.Insere(novaSerie);

            }

            static void AtualizarSerie()
            {
                Console.WriteLine("Alterar Série");
                Console.WriteLine();

                Console.WriteLine("Digite a ID da Série");
                int entradaID = int.Parse(Console.ReadLine());

                foreach (int i in Enum.GetValues(typeof(Genero)))
                {
                    Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
                }
                Console.Write("Digite o genero da série entre as opções acima: ");
                int entraGenero = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o título da Série: ");
                string entraTitulo = Console.ReadLine();

                Console.WriteLine("Digite o ano da Série: ");
                int entradaAno = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a Descrição da Série: ");
                string entradaDescricao = Console.ReadLine();

                var serieAtualizada = new Series(entradaID, (Genero)entraGenero, entraTitulo, entradaDescricao, entradaAno);
                
                repositorio.Atualiza(entradaID, serieAtualizada);
            }

            static void ListarSeries()
            {
                Console.WriteLine("Listagem de séries cadastradas");

                var lista = repositorio.Lista();

                if (lista.Count == 0) 
                {
                    Console.WriteLine("Não existe série cadastrada");
                    return;
                }

                foreach (var serie in lista)
                {
                    Console.WriteLine("#ID {0}: - {1}", serie.retornaId(), serie.retornaTitulo());
                }
            }

            static void ExcluirSerie()
            {
                Console.WriteLine("Exclusão de Série");
                Console.WriteLine();

                Console.WriteLine("Digite a ID da Série a ser excluída");
                int entradaID = int.Parse(Console.ReadLine());

                repositorio.Excluir(entradaID);

            }

            static void VisualizarSeries();
            {
                Console.WriteLine("Visualizar de Série");
                Console.WriteLine();

                Console.WriteLine("Digite a ID da Série a ser visualizada");
                int entradaID = int.Parse(Console.ReadLine());
                var serie = repositorio.retornaPorId(entradaID);
                
                serie.Visualizar(entradaID); 
            }

            static string obterOpcaoUsuario()
            {
                Console.WriteLine();
                Console.WriteLine("Herbert Bank SE ao seu dispor!");
                Console.WriteLine("Informe a opção desejada");

                Console.WriteLine("1 - Listar Séries");
                Console.WriteLine("2 - Inserir nova Série");
                Console.WriteLine("3 - Atualizar Série");
                Console.WriteLine("4 - Excluir Série");
                Console.WriteLine("5 - Visualizar Séries");
                Console.WriteLine("6 - Limpar Tela");
                Console.WriteLine("X - Sair");
                Console.WriteLine();
                string opcaoUsuario = Console.ReadLine();
                Console.WriteLine();
                return opcaoUsuario;                
            }
                   
        }
    }
}
