
using System;
using System.Collections.Generic;


public class Player
{
    public string nome;
    public int xp;
    public int gold;
    public List<Item> Itens = new List<Item>();
}

public class Item
{
    public string Nome;
    public int Id;
    public int Preco;
}
public class LP2_Trabalho
{

    static List<Player> Players = new List<Player>();

    public static void Main(string[] args)
    {
     
        
        bool MostrarMenu = true;
        while (MostrarMenu)
        {
            MostrarMenu = MenuPrincipal();
        }
    }


    private static bool MenuPrincipal()
    {

            Item varinha = new Item();
            varinha.Id = 01;
            varinha.Nome = "Varinha";
            varinha.Preco = 47;

            Item livro_de_encantos_1 = new Item();
            livro_de_encantos_1.Id = 02;
            livro_de_encantos_1.Nome = "Livro de encantos 1";
            livro_de_encantos_1.Preco = 100;

            Item livro_de_encantos_2 = new Item();
            livro_de_encantos_2.Id = 03;
            livro_de_encantos_2.Nome = "livro de encantos 2";
            livro_de_encantos_2.Preco = 150;

            Item livro_de_encantos_3 = new Item();
            livro_de_encantos_3.Id = 04;
            livro_de_encantos_3.Nome = "livro de encantos 3";
            livro_de_encantos_3.Preco = 200;

            Item vassoura_voadora = new Item();
            vassoura_voadora.Id = 05;
            vassoura_voadora.Nome = "Vassoura voadora";
            vassoura_voadora.Preco = 125;

            Item kit_quadribol = new Item();
            kit_quadribol.Id = 06;
            kit_quadribol.Nome = "kit quadribol";
            kit_quadribol.Preco = 200;


        Console.Clear();
        Console.WriteLine("Entre com '1' para se regitrar (necessário para entrar na loja).");
        Console.WriteLine("Entre com '2' para ver o regitro de jogadores");
        Console.WriteLine("Entre com '3' para olhar o seu inventário.");
        Console.WriteLine("Entre com '4' para entrar na loja.");
        Console.WriteLine("Entre com '5' para encerrar o programa.");

        switch (Console.ReadLine())
        {
          case "1":

                Console.Clear();  
                
                Console.Write("Digite o nome do seu jogador: ");
                var np = Console.ReadLine();
              
                Console.Write("Digite a quantidade de XP (experiência): ");
                var xpP = Console.ReadLine();
               
                Console.Write("Digite a quantidade de moedas do jogador: ");
                var dinDin = Console.ReadLine();


                Players.Add(new Player { nome = np, xp = Convert.ToInt32(xpP), gold = Convert.ToInt32(dinDin)});
                Console.Clear();

                Console.WriteLine("Jogador criado com sucesso");
                Console.WriteLine("");
                Console.WriteLine("O jogador possui " + dinDin +" moedas");
                Console.WriteLine("Tecle 'ENTER' para continuar...");
                Console.ReadLine();
                return true;

            case "2":
                Console.Clear();
                for (int i = 0; i < Players.Count; i++)
                {

                    Console.WriteLine("");
                    Console.WriteLine("Jogador:");            
                    Console.WriteLine("Nome : " + Players[i].nome);
                    Console.WriteLine("XP : " + Players[i].xp);
                    Console.WriteLine("Gold : " + Players[i].gold);                 
                    Console.WriteLine("");
                }

                Console.WriteLine("");
                Console.Write("Pressione qualquer tecla para sair...");
                Console.ReadKey();
                return true;
            
            case "3":
            Console.Clear();
            Console.WriteLine("Digite o nome do jogador:");
            var pq = Console.ReadLine();
            foreach(Player p in Players)
            {
                if(p.nome == pq)
                {
                    Console.WriteLine("Itens:");
                    Console.WriteLine("");
                    for (int i = 0; i < p.Itens.Count; i++)
                    {
                        Console.WriteLine("Item: " + p.Itens[i].Nome);
                    }
                    Console.WriteLine("XP: " + p.xp);
                    Console.WriteLine("Entre com qualquer tecla para continuar");
                    Console.ReadLine();
                }
                else{
                    Console.Clear();
                    Console.WriteLine("Nenhum jogador encontrado... Retornando ao menu principal");
                    Console.ReadLine();
                }
            }
                return true;

            case "4":
            Console.Clear();
            Console.WriteLine("Digite o nome do jogador que irá acessar a loja: ");
            pq = Console.ReadLine();
            foreach(Player p in Players)
            {
                if(p.nome == pq)
                {
                    Console.WriteLine("Bem vindo! Temos aqui tudo que você precisa");
                    Console.WriteLine("-Digite o ID do item que você gostaria de comprar:");
                    Console.WriteLine("=====================================================================");;
                    Console.WriteLine("01 - varinha  (usada para fazer encantos)");
                    Console.WriteLine("=====================================================================");
                    Console.WriteLine("02 - livros de encantos 1 (livro que possui encantos basicos para bruxos iniciantes)");  
                    Console.WriteLine("Aumenta 5 pontos de experiência");
                    Console.WriteLine("=====================================================================");
                    Console.WriteLine("03 - Livros de encantos 2 (livro que possui encantos um pouco avançados para bruxos com um pouco de experiência)");
                    Console.WriteLine("OBS:Necessário ler o livro anterior");
                    Console.WriteLine("Aumenta 15 pontos de experiência");
                    Console.WriteLine("=====================================================================");
                    Console.WriteLine("04 - Livros de encantos 3 (livros de encantos complexos para bruxos experientes)");
                    Console.WriteLine("Aumenta 35 pontos de experiência");
                    Console.WriteLine("OBS:Necessário ler o livro anterior");
                    Console.WriteLine("=====================================================================");
                    Console.WriteLine("05 - Vassoura voadora (Vassoura utilizada por atletas de quadribol)");  
                    Console.WriteLine("=====================================================================");
                    Console.WriteLine("06 - kit de quadribol (conjuto com as 4 bolas usadas no quadribol)");
                    Console.WriteLine("=====================================================================");
                    Console.WriteLine("07- Capa de invisibilidade (torna o jogador invisível)");
                    Console.WriteLine("=====================================================================");
                    var ic = Console.ReadLine();
                    switch(ic)  
                    {
                        case "01":
                        Console.WriteLine("Você gostaria de comprar varinha por 47 moedas? (S)/(N)");
                        Console.WriteLine("voce tem " + p.gold + " moedas");
                        var resp = Console.ReadLine();
                        if(resp == "S")
                        {
                            if(p.gold >= varinha.Preco)
                            {
                                p.gold = p.gold - varinha.Preco;
                                p.Itens.Add(varinha);
                                Console.Clear();
                                Console.WriteLine("-Item adquirido!!");
                                Console.WriteLine("Verifique seu inventário");
                                Console.WriteLine("Muito obrigado, volte sempre!");
                                Console.ReadLine();
                                
                            }
                            else
                            {
                                Console.WriteLine("Fiado só amanhã!");
                                Console.ReadLine();
                            }
                        }
                        else{}
                        break;

                        case "02":
                        Console.WriteLine("Você gostaria de comprar livro de encantos 1 por 100 moedas? (S)/(N)");
                        Console.WriteLine("voce tem " + p.gold + " moedas");
                 
                        resp = Console.ReadLine();
                        if(resp == "S")
                        {
                            if(p.gold >= livro_de_encantos_1.Preco)
                            {
                                p.gold = p.gold - livro_de_encantos_1.Preco;
                                p.Itens.Add(livro_de_encantos_1);
                                p.xp=p.xp + 5;
                                Console.Clear();
                                Console.WriteLine("-Item e experiência adquiridos!!");
                                Console.WriteLine("Verifique seu inventário");
                                Console.WriteLine("Muito obrigado, volte sempre!");
                                Console.ReadLine();
                            }
                            else
                            {
                               Console.WriteLine("Fiado só amanhã!");
                                Console.ReadLine();
                            }
                        }
                        else{}
                        break;

                        case "03":
                        Console.WriteLine("Você gostaria de comprar livro de encantos 2 por 150 moedas? (S)/(N)");
                        Console.WriteLine("voce tem " + p.gold + " moedas");
                        resp = Console.ReadLine();
                        if(resp == "S")
                        {
                            if(p.gold >= livro_de_encantos_2.Preco)
                            {
                                p.gold = p.gold - livro_de_encantos_2.Preco;
                                p.Itens.Add(livro_de_encantos_2);
                                p.xp=p.xp + 15;
                                Console.Clear();
                                Console.WriteLine("-Item e experiência adquiridos!!");
                                Console.WriteLine("Verifique seu inventário");
                                Console.WriteLine("Muito obrigado, volte sempre!");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Fiado só amanhã!");
                                Console.ReadLine();
                            }
                        }
                        else{}
                        break;

                        case "04":
                        Console.WriteLine("Você gostaria de comprar o livro de encantos 3 por 200 moedas? (S)/(N)");
                        Console.WriteLine("voce tem " + p.gold + " moedas");
                        resp = Console.ReadLine();
                        if(resp == "S")
                        {
                            if(p.gold >= livro_de_encantos_3.Preco)
                            {
                                p.gold = p.gold - livro_de_encantos_3.Preco;
                                p.Itens.Add(livro_de_encantos_3);
                                p.xp=p.xp + 35;
                                Console.Clear();
                                Console.WriteLine("-Item e experiência adquiridos!!");
                                Console.WriteLine("Verifique seu inventário");
                                Console.WriteLine("Muito obrigado, volte sempre!");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Fiado só amanhã!");
                                Console.ReadLine();;
                            }
                        }
                        else{}
                        break;

                        case "05":
                        Console.WriteLine("Você gostaria de comprar uma vassoura voadora por 200 moedas? (S)/(N)");
                        Console.WriteLine("voce tem " + p.gold + " moedas");
                        resp = Console.ReadLine();
                        if(resp == "S")
                        {
                            if(p.gold >= vassoura_voadora.Preco)
                            {
                                p.gold = p.gold - vassoura_voadora.Preco;
                                p.Itens.Add(vassoura_voadora);
                                Console.Clear();
                                Console.WriteLine("-Item adquirido!!");
                                Console.WriteLine("Verifique seu inventário");
                                Console.WriteLine("Muito obrigado, volte sempre!");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Fiado só amanhã!");
                                Console.ReadLine();
                            }
                        }
                        else{}
                        break;

                      case "06":
                        Console.WriteLine("Você gostaria de comprar kit de quadribol por 200 moedas? (S)/(N)");
                        Console.WriteLine("voce tem " + p.gold + " moedas");
                        resp = Console.ReadLine();
                        if(resp == "S")
                        {
                            if(p.gold >= kit_quadribol.Preco)
                            {
                                p.gold = p.gold - kit_quadribol.Preco;
                                p.Itens.Add(kit_quadribol);
                                Console.Clear();
                                Console.WriteLine("-Item adquirido!!");
                                Console.WriteLine("Verifique seu inventário");
                                Console.WriteLine("Muito obrigado, volte sempre!");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Fiado só amanhã!");
                                Console.ReadLine();
                            }
                        }
                        else{}
                        break;

                        default:                        
                        Console.WriteLine("Volte sempre,contanto que compre!");
                        Console.ReadLine();
                        break;
                    }
                }
                else{
                    Console.Clear();
                    Console.WriteLine("Nenhum jogador encontrado... É necessário ter um jogador registrado");
                    Console.WriteLine("para acessar a loja. Retornando ao menu principal...");
                    Console.ReadLine();
                }
            }
                return true;

            case "5":
                return false;

            default:
                return true;

        }
    }


}