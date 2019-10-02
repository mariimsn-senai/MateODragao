using System;
using MateODragao.Models;

namespace MateODragao
{
    class Program
    {
        public static object DataTime { get; private set; }

        static void Main(string[] args)
        {
            bool jogadorNaoDesistiu = true;
            do
            {


                Console.Clear();
                System.Console.WriteLine("==============================");
                System.Console.WriteLine("        Mate o Dragão!");
                System.Console.WriteLine("==============================");

                System.Console.WriteLine(" 1 - Iniciar jogo");
                System.Console.WriteLine(" 0 - Sair do jogo");

                string opçãoJodor = Console.ReadLine();

                switch (opçãoJodor)
                {
                    case "1":
                        Console.Clear();

                        Guerreiro guerreiro = CriarGuerreiro();

                        Dragao dragao = new Dragao();
                        dragao.Nome = "Dragonildo";
                        dragao.Força = 5;
                        dragao.Destreza = 1;
                        dragao.Inteligencia = 3;
                        dragao.Vida = 300;

                        /*INICIO - PRIMEIRO DIÁLOGO */
                        CriarDialogo(guerreiro.Nome, $"{dragao.Nome}, Vim-lhe derrotar-lhe!");
                        CriarDialogo(dragao.Nome, " Humano tolino. Quem pensas que és?");


                        FinalizarDialogo();
                        /*FIM - PRIMEIRO DIÁLOGO */

                        /*INICIO - SEGUNDO DIÁLOGO */
                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Eu sou {guerreiro.Nome}, da casa {guerreiro.Sobrenome} ó criatura morfética");
                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Vim de {guerreiro.CidadeNatal} para derrotar-te e mostrar meu valor");
                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: QUEM ? DE onde ? Bom, que seja... frita-te-ei e devorar-te-ei, primata insolente!");

                        System.Console.WriteLine("BAMBAM: Tá na hora do show!");

                        System.Console.WriteLine();
                        System.Console.WriteLine("Aperte ENTER para proceguir");
                        Console.ReadLine();
                        /*FIM - SEGUNDO DIÁLOGO */
                        Console.Clear();

                        bool jogadorAtacaPrimeiro = guerreiro.Destreza > dragao.Destreza ? true : false;

                        int poderAtaqueGuerreiro = guerreiro.Força > guerreiro.Inteligencia ? guerreiro.Força + guerreiro.Destreza : guerreiro.Inteligencia + guerreiro.Destreza;

                        bool jogadorNaoCorreu = true;

                        if (jogadorAtacaPrimeiro)
                        {
                            
                            System.Console.WriteLine("*** Turno do jogador ***");
                            System.Console.WriteLine(" Escolher uma ação ");
                            System.Console.WriteLine(" 1 - Atacar");
                            System.Console.WriteLine(" 2 - Fugir");
                            
                            string opçaoBatalhaJogador = Console.ReadLine();
                            
                            switch (opçaoBatalhaJogador)
                            {
                                case "1":
                                    Random geradorNumeroAleatorio = new Random();
                                    int numeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                                    int numeroAleatoriodragao = geradorNumeroAleatorio.Next(0, 5);
                                    int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                    int dragaoDestrezaTotal = dragao.Destreza + numeroAleatoriodragao;

                                    if (guerreiroDestrezaTotal > dragaoDestrezaTotal)
                                    {
                                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Toma essa, lagarto MALDJETO! BIRLLLL");
                                        dragao.Vida = dragao.Vida - (poderAtaqueGuerreiro + 5);
                                        System.Console.WriteLine($"HP Guerreiro: {dragao.Vida}");
                                        System.Console.WriteLine($"HP Guerreiro: {guerreiro.Vida}");
                                    }
                                    else
                                    {
                                        System.Console.WriteLine($"{dragao.Nome.ToUpper()} Você está destruido!!");
                                    }

                                    break;
                                case "2":
                                    System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Simbora fii!");
                                    System.Console.WriteLine($"{dragao.Nome.ToUpper()}: GG EZ");
                                    jogadorNaoCorreu = false;
                                    break;
                            }
                        }

                        System.Console.WriteLine();
                        System.Console.WriteLine("Aperte Enter para prosseguir");
                        Console.ReadLine();

                        while (guerreiro.Vida > 0 && dragao.Vida > 0 && jogadorNaoCorreu)
                        {
                           
                            System.Console.WriteLine("*** Turno Dadrao***");
                            Random geradorNumeroAleatorio = new Random();
                            int numeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                            int numeroAleatoriodragao = geradorNumeroAleatorio.Next(0, 5);
                            int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                            int dragaoDestrezaTotal = dragao.Destreza + numeroAleatoriodragao;

                            if (guerreiroDestrezaTotal < dragaoDestrezaTotal)
                            {
                                System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Fritou o forévis, foi?");
                                guerreiro.Vida -= dragao.Força;
                                System.Console.WriteLine($"HP Guerreiro: {dragao.Vida}");
                                System.Console.WriteLine($"HP Guerreiro: {guerreiro.Vida}");
                            }
                            else
                            {
                                System.Console.WriteLine($"{guerreiro.Nome.ToUpper()} Errou DESGRAÇADOS!");

                            }


                        System.Console.WriteLine();
                        System.Console.WriteLine("Aperte ENTER para prosseguir");
                        Console.ReadLine();

                        Console.Clear();

                        System.Console.WriteLine("*** Turno do jogador ***");
                        System.Console.WriteLine(" Escolher uma ação ");
                        System.Console.WriteLine(" 1 - Atacar");
                        System.Console.WriteLine(" 2 - Fugir");
                        
                        string opçãoBatalhaJogador = Console.ReadLine();
                        
                        switch (opçãoBatalhaJogador)
                        {
                            case "1":
                                geradorNumeroAleatorio = new Random();
                                numeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                                numeroAleatoriodragao = geradorNumeroAleatorio.Next(0, 5);
                                guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                dragaoDestrezaTotal = dragao.Destreza + numeroAleatoriodragao;

                                if (guerreiroDestrezaTotal > dragaoDestrezaTotal)
                                {
                                    System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Toma essa, lagarto MALDJETO! BIRLLLL");
                                    dragao.Vida = dragao.Vida - (poderAtaqueGuerreiro + 5);
                                    System.Console.WriteLine($"HP Dragão: {dragao.Vida}");
                                    System.Console.WriteLine($"HP Guerreiro: {guerreiro.Vida}");
                                }
                                else
                                {
                                    System.Console.WriteLine($"{dragao.Nome.ToUpper()} Você está destruido!!");

                                }

                                break;
                            case "2":
                                System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Simbora fii!");
                                System.Console.WriteLine($"{dragao.Nome.ToUpper()}: GG EZ");
                                jogadorNaoCorreu = false;
                                break;
                                
                        }

                        if (guerreiro.Vida <=0)
                        {
                            System.Console.WriteLine("Você Perdeu!");
                        }
                        if (dragao.Vida <= 0)
                        {
                            System.Console.WriteLine("Você venceu");
                        }


                
                        }
                        break;
                    case "0":
                        jogadorNaoDesistiu = false;
                        System.Console.WriteLine("GAME OVER");
                        break;
                    default:
                        System.Console.WriteLine("Comando inválido");
                        break;
                }
            } while (jogadorNaoDesistiu);
        }
    
    public static void CriarDialogo(string nome, string frase)
    {
        System.Console.WriteLine($"{nome.ToUpper()}: {frase}, Vim-lhe derrotar-lhe!");

    }
        public static void FinalizarDialogo() {
            System.Console.WriteLine();
            System.Console.WriteLine("Aperte ENTER para prosseguir");
            Console.ReadLine();
            Console.Clear();
        }

        public static Guerreiro CriarGuerreiro()
        {
            Guerreiro guerreiro = new Guerreiro();
            guerreiro.Nome = "Nayumi";
            guerreiro.Sobrenome = "Halux";
            guerreiro.CidadeNatal = "Havanna";
            guerreiro.DataNascimento = DateTime.Parse("1/1/1001");
            guerreiro.FerramentaAtaque = "Olho mortal";
            guerreiro.FerramentaProteção = "Escudo";
            guerreiro.Força = 2;
            guerreiro.Destreza = 3;
            guerreiro.Inteligencia = 3;
            guerreiro.Vida = 20;

            return guerreiro;
        }
    
    
    }
}
