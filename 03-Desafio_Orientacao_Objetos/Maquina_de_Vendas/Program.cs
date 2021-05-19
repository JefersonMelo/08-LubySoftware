using System;

namespace Maquina_de_Vendas
{
    class Program
    {
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
                Console.Write("Pagamento R$");
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
                            Console.WriteLine($"O valor da sua compra: {v.vendido(p):C2}\n" +
                                              $"Seu troco: {verificaValor - v.vendido(p):C2}\n");
                            verificaValor -= verificaValor - v.vendido(p);// sinais de operação corrigidos
                        }

                    }
                    else
                    {
                        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>NOTA DA COMPRA<<<<<<<<<<<<<<<<<<<<\n");
                        Console.WriteLine($"Refri: {p.Nome}\n" +
                                              $"Quantidade: {p.QtdItem}\n" +
                                              $"Valor Unidade: {e.valorUniade(p.Nome):C2}\n" +
                                              $"Valor Total Recebido: {v.vendido(p):C2}\n" +
                                              $"Agora refresque-se e mate sua sede!!\n");
                        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>LubySoftware<<<<<<<<<<<<<<<<<<<<<<");
                        break;
                    }

                } while (true);
            }
        }
    }
}
