using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ControleDeJogos
{
    class Program
    {
        static int Menu()
        {
            Console.Clear();
            Console.WriteLine("<<< Controle de Jogos >>>");
            Console.WriteLine("Selecione uma opcao: ");
            Console.WriteLine("1) Cadastrar um Jogo. ");
            Console.WriteLine("2) Excluir um Jogo. ");
            Console.WriteLine("3) Alterar um Jogo. ");
            Console.WriteLine("4) Localizar um Jogo por nome. ");
            Console.WriteLine("5) Lista os jogos por Genero. ");
            Console.WriteLine("6) Lista os jogos por Console. ");
            Console.WriteLine("7) Lista todos os jogos. ");
            Console.WriteLine("9) Sair. ");
            int opcao = int.Parse(Console.ReadLine());

            return opcao;

        }
        static void Main(string[] args)
        {
            
            ListaDeJogos listadejogos = new ListaDeJogos();
            
            Jogo jogo = new Jogo(1,"Rei Card","Jogo de cartas mágicas",tipoConsole.PC,tipoGenero.Estrategia);
            listadejogos.Inserir(jogo);
             jogo = new Jogo(2, "Monster lol", "Jogo de monstros", tipoConsole.PS5, tipoGenero.Acao);
            listadejogos.Inserir(jogo);
            jogo = new Jogo(3, "Vampiro vlad", "Jogo do rei gabinhovlad", tipoConsole.Xbox, tipoGenero.Aventura);
            listadejogos.Inserir(jogo);

            int opcao = 0;
            while (opcao != 9)
            {
                opcao = Menu();
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Cadastrar jogo:");
                        jogo = new Jogo();
                        Console.WriteLine("ID:");
                        jogo.Id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nome do jogo:");
                        jogo.Nome = Console.ReadLine();
                        Console.WriteLine("Desricao do jogo:");
                        jogo.Descricao = Console.ReadLine();
                        Console.WriteLine("Informe o genero: Acao [0], Aventura [1], Casual [2], Puzzle [3], Estrategia [4], Outros [5]");
                        jogo.Genero = (tipoGenero)Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o console: PS5 [0], PS4 [1], NSwitch [2], Xbox [3], Xbox360 [4], XboxOne [5], PC [6], Outros [7]");
                        jogo.Console = (tipoConsole)Convert.ToInt32(Console.ReadLine());

                        if (listadejogos.Inserir(jogo))
                        {
                            Console.WriteLine("Jogo adicionado!");

                        }
                        else
                        {
                            Console.WriteLine("Não foi possivel adicionar o jogo");
                        }
                            ;

                        break;

                    case 2:
                        Console.WriteLine("Excluir jogo:");
                        Console.WriteLine("Informe o ID do jogo :");
                        int id = int.Parse(Console.ReadLine());
                        if (listadejogos.Excluir(id))
                        {
                            Console.WriteLine("Jogo excluido");
                        }
                        else
                        {
                            Console.WriteLine("Jogo nao encontrado");
                        }
                        Console.ReadKey();

                        break;

                    case 3:
                        Console.WriteLine("Alterar um jogo: ");
                        jogo = new Jogo();
                        Console.WriteLine("ID:");
                        jogo.Id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nome do jogo:");
                        jogo.Nome = Console.ReadLine();
                        Console.WriteLine("Desricao do jogo:");
                        jogo.Descricao = Console.ReadLine();
                        Console.WriteLine("Informe o genero: Acao [0], Aventura [1], Casual [2], Puzzle [3], Estrategia [4], Outros [5]");
                        jogo.Genero = (tipoGenero)Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o console: PS5 [0], PS4 [1], NSwitch [2], Xbox [3], Xbox360 [4], XboxOne [5], PC [6], Outros [7]");
                        jogo.Console = (tipoConsole)Convert.ToInt32(Console.ReadLine());

                        if (listadejogos.Alterar(jogo))
                        {
                            Console.WriteLine("Jogo alterado!");

                        }
                        else
                        {
                            Console.WriteLine("Jogo não alterado.");
                        }
                            ;

                        break;

                    case 4:
                        Console.WriteLine("Localizar jogos:");
                        Console.WriteLine("Informe o nome do jogo :");
                        string nome = Console.ReadLine();
                        List<Jogo> listaNomes = listadejogos.Localizar(nome);
                        foreach (var y in listaNomes)
                        {
                            Console.Write(" Id: " + y.Id);
                            Console.Write(" - Nome :" + y.Nome);
                            Console.Write(" - Descricao :" + y.Descricao);
                            Console.Write(" - Genero :" + y.Genero);
                            Console.WriteLine(" - Console :" + y.Console);
                            Console.WriteLine("------------");

                        }
                        Console.WriteLine("Aperte qualquer tecla para continuar");
                        Console.ReadKey();

                        break;

                    case 5:
                        Console.WriteLine("Listar todos os jogos por genero:");
                        Console.WriteLine("Informe o genero: Acao [0], Aventura [1], Casual [2], Puzzle [3], Estrategia [4], Outros [5]");
                        tipoGenero genero = (tipoGenero)Convert.ToInt32(Console.ReadLine());
                        List<Jogo> listaGenero = listadejogos.ListarPorGenero(genero);
                        foreach (var y in listaGenero)
                        {
                            Console.Write(" Id: " + y.Id);
                            Console.Write(" - Nome :" + y.Nome);
                            Console.Write(" - Descricao :" + y.Descricao);
                            Console.Write(" - Genero :" + y.Genero);
                            Console.WriteLine(" - Console :" + y.Console);
                            Console.WriteLine("------------");

                        }
                        Console.WriteLine("Aperte qualquer tecla para continuar");
                        Console.ReadKey();

                        break;

                    case 6:
                        Console.WriteLine("Listar todos os jogos por console:");
                        Console.WriteLine("Informe o console: PS5 [0], PS4 [1], NSwitch [2], Xbox [3], Xbox360 [4], XboxOne [5], PC [6], Outros [7]");
                        tipoConsole console = (tipoConsole)Convert.ToInt32(Console.ReadLine());
                        List<Jogo> listaConsole = listadejogos.ListarPorConsole(console);
                        foreach (var y in listaConsole)
                        {
                            Console.Write(" Id: " + y.Id);
                            Console.Write(" - Nome :" + y.Nome);
                            Console.Write(" - Descricao :" + y.Descricao);
                            Console.Write(" - Genero :" + y.Genero);
                            Console.WriteLine(" - Console :" + y.Console);
                            Console.WriteLine("------------");

                        }
                        Console.WriteLine("Aperte qualquer tecla para continuar");
                        Console.ReadKey();

                        break;

                    case 7:
                        Console.WriteLine("Listar todos os jogos:");
                        foreach(var y in listadejogos.Jogos)
                        {
                            Console.Write(" Id: " + y.Id);
                            Console.Write(" - Nome :" + y.Nome);
                            Console.Write(" - Descricao :" + y.Descricao);
                            Console.Write(" - Genero :" + y.Genero);
                            Console.WriteLine(" - Console :" + y.Console);
                            Console.WriteLine("------------");
                            
                        }
                        Console.WriteLine("Aperte qualquer tecla para continuar");
                        Console.ReadKey();
                        break;






                }


            }




        }
    }
}
