using System;

namespace Maquina_de_Vendas
{
    class Program
    {
        /*
         * Desenvolver programa que rode uma Vending Machine (Máquina de venda de bebidas em lata) 
         * utilizando orientação objetos conforme as regras abaixo.
        1-Crie uma interface de usuário simples para execução da máquina.
        2-A máquina deverá possuir um estoque de produtos com valor e quantidade de cada produto. 
        A quantidade de produto no estoque da máquina deve ser alterado conforme realização de vendas dos produtos.
        3-A máquina deverá ter opção para visualizar estoque e quantidade disponível.
        4-A máquina só pode vender produtos com quantidade em estoque disponível.
        5-A máquina deverá contabilizar as vendas e mostrar o valor total das vendas realizadas.
        6-Uma venda só poderá ser concluída ao inserir o valor total do produto.
        7-A máquina deverá contabilizar e solicitar o valor faltante para finalizar a venda, caso haja valor 
        de troco para deverá informar o valor.
        8-A máquina não necessita de lógica de contagem de notas, será apenas necessário informar os valores.
        9-Caso necessário crie um documento simples com informações de como executar o programa.   
        https://github.com/lubysoftware/join/tree/asp-net
         */

        static void Main( string[] args )
        {
            Produto p = new Produto();
            Venda v = new Venda();
            Estoque e = new Estoque();

            Console.WriteLine("1-Comprar | 2-Conferir Estoque?");
            int r = int.Parse(Console.ReadLine());

            if (r == 2)// Verificar estoque
            {
                do
                {
                    Console.Write("Entre com a senha: ");
                    string senha = Console.ReadLine();
                    if (senha == "$$")// Senha para verficar estoque
                    {
                        Console.Write("Coca | Pepsi | Itubaina | Total: ");
                        e.visualizarEstoque(p.Nome = Console.ReadLine().ToLower());
                        Console.WriteLine($"Quantidade {p.Nome}: {e.visualizarEstoque(p.Nome)}");
                        Console.WriteLine($"Valor Total em Vendas: {v.contabilidade(p):C2}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Senha Não Confere");
                        break;
                    }

                } while (true);

            }
            else// Compra
            {
                Console.Write("Refris Disponíveis: Coca, Pepsi, Itubaina.\nEscolha Um Refri: ");
                p.Nome = Console.ReadLine().ToLower();
                Console.WriteLine($"Valor da Unidade: {e.valorUniade(p.Nome):C2}");
                Console.Write("Quantidade: ");
                p.QtdItem = int.Parse(Console.ReadLine());
                Console.WriteLine($"Valor de Sua Compra: {v.vendido(p):C2}");// Calcula o valor da compra
                Console.Write("Pagamento: ");
                double verificaValor = double.Parse(Console.ReadLine());
                double valorRetorno;
                do
                {
                    if (e.visualizarEstoque(p.Nome) < p.QtdItem)// Estoque menor que a quantidade requerida na compra
                    {
                        Console.WriteLine($"Não é possível realizar a venda, o estoque menor que seu pedido.\n" +
                                          $"Quantidade atual{e.visualizarEstoque(p.Nome)}");
                        break;
                    }
                    else if (verificaValor != v.vendido(p))
                    {
                        if (verificaValor < v.vendido(p))// Valor menor, requer complemento
                        {
                            Console.WriteLine($"O Valor da Sua Compra: {v.vendido(p):C2}\n" +
                                              $"Valor Que Falta: {v.vendido(p) - verificaValor:C2}");
                            valorRetorno = double.Parse(Console.ReadLine());
                            verificaValor += valorRetorno;
                        }
                        if (verificaValor > v.vendido(p))// Valor maior, requer troco
                        {
                            Console.WriteLine($"O valor da sua compra: {v.vendido(p):C2}\n " +
                                              $"Seu troco: {verificaValor - v.vendido(p):C2}\n");
                            verificaValor -= verificaValor + -v.vendido(p);
                        }

                    }
                    else
                    {
                        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>NOTA DA COMPRA<<<<<<<<<<<<<<<<<<<<");
                        Console.WriteLine($"Refri: {p.Nome}\n" +
                                              $"Quantidade: {p.QtdItem}\n" +
                                              $"Valor Unidade: {e.valorUniade(p.Nome)}\n" +
                                              $"Valor Total Recebido: {v.vendido(p):C2}\n" +
                                              $"Agora refresque-se e mate sua sede!!\n");
                        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>LubySoftware<<<<<<<<<<<<<<<<<<<<");
                        break;
                    }

                } while (true);
            }
        }
    }
}
