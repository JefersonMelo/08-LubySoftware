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
            Console.WriteLine("1-Comprar | 2-Conferir Estoque?");
            int r = int.Parse(Console.ReadLine());

            if (r == 2)// verificar estoque
            {
                Console.Write("Coca | Pepsi | Itubaina | Total: ");
                p.visualizarEstoque(p.Nome = Console.ReadLine().ToLower());
                Console.WriteLine($"Quantidade {p.Nome}: {p.visualizarEstoque(p.Nome)}");
            }
            else
            {
                Console.Write("Refris Disponíveis: Coca, Pepsi, Itubaina.\nEscolha Um Refri: ");
                p.Nome = Console.ReadLine().ToLower();
                Console.WriteLine($"Valor da Unidade: {p.valorUniade(p.Nome)}");
                Console.Write("Quantidade: ");
                p.QtdItem = int.Parse(Console.ReadLine());
                Console.WriteLine($"{v.vendido(p.Nome)}");// Calcula o valor da compra
                Console.Write("Para concluír a compra, entre com o valor total da sua compra: ");
                double verificaValor = double.Parse(Console.ReadLine());
                double valorRetorno;
                do
                {
                    if (p.visualizarEstoque(p.Nome) < p.QtdItem)// Estoque menor que a quantidade requerida na compra
                    {
                        Console.WriteLine($"Não é possível realizar a venda, o estoque menor que seu pedido.\n" +
                                          $"Quantidade atual{p.visualizarEstoque(p.Nome)}");
                        break;
                    }
                    else if (verificaValor != v.vendido(p.Nome))
                    {
                        if (verificaValor < v.vendido(p.Nome))// Valor menor, requer complemento
                        {
                            Console.WriteLine($"O Valor da Sua Compra: {v.vendido(p.Nome)}\n" +
                                              $"Valor Que Falta: {v.vendido(p.Nome) - verificaValor:C2}");
                            valorRetorno = double.Parse(Console.ReadLine());
                            verificaValor += valorRetorno;
                        }
                        else if (verificaValor > v.vendido(p.Nome))// Valor maior, requer troco
                        {
                            Console.WriteLine($"O valor da sua compra: {v.vendido(p.Nome)}. " +
                                              $"Seu troco: {verificaValor - v.vendido(p.Nome)}");
                            verificaValor -= v.vendido(p.Nome);
                        }

                    }
                    else
                    {
                        Console.WriteLine($"Refri: {p.Nome}\n" +
                                          $"Quantidade: {p.QtdItem}\n" +
                                          $"Valor Unidade: {p.valorUniade(p.Nome)}\n" +
                                          $"Valor Total a Pagar: {v.vendido(p.Nome)}\n" +
                                          $"Agora refresque-se e mate sua sede!!");
                        break;
                    }

                } while (true);
            }
        }
    }
}
