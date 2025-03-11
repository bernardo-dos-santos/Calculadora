using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics.CodeAnalysis;

namespace Calculadora.ConsoleApp
{
   
    internal class Program
    {
        
        static void Main(string[] args)
        {
            // declaração de variáveis
            decimal resultado, primeironumero, segundonumero; 
            int continuar;
            string qualoperacao, primeironumero1, segundonumero1;
            List<string> historicooperacoes = new List<string>();

            //repetição caso o usuário queira 

            do
            {
                //Cabeçairo / Menu Principal 
                Console.WriteLine("-----------------------------------------------------", "/n");
                Console.WriteLine("Calculadora Simples", "/n");
                Console.WriteLine("Escolha qual operação você deseja realizar", "/n");
                Console.WriteLine("1 - Adição", "/n");
                Console.WriteLine("2 - Subtração", "/n");
                Console.WriteLine("3 - Divisão", "/n");
                Console.WriteLine("4 - Multiplicação", "/n");
                Console.WriteLine("5 - Mostrar Histórico ", "/n");
                Console.WriteLine("6 - Sair do Programa", "/n");
                Console.WriteLine("-----------------------------------------------------", "/n");
                continuar = 7;
                // Escolher qual operação o usario deseja 
                qualoperacao = Console.ReadLine();
                // se for inválido o comando 
                if (qualoperacao != "1" && qualoperacao != "2" && qualoperacao != "3" && qualoperacao != "4" && qualoperacao != "5" && qualoperacao != "6")
                {
                    Console.WriteLine("Comando Inválido, Voltando ao menu principal", "/n");
                    continue;

                }
                else if (qualoperacao == "6")
                {
                    Console.WriteLine("Obrigado Pela Presença!!");
                    break;
                }
                else if (qualoperacao == "5")
                {
                    if (historicooperacoes != null)
                    {
                        Console.WriteLine("O Histórico de operações é ", "/n");
                        Console.WriteLine("-----------------------------------------------------", "/n");
                        foreach (var item in historicooperacoes)
                        {
                            Console.WriteLine(item, "/n");
                        }
                        Console.WriteLine("-----------------------------------------------------", "/n");
                        Console.WriteLine("Pressione qualquer tecla para continuar", "/n");
                        Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Ainda não há um histórico disponivel, Voltando ao menu principal", "/n");
                        continue;

                    }
                }
                Console.WriteLine("Digite o Primeiro Número: ", "/n");
                primeironumero1 = Console.ReadLine();
                Console.WriteLine("Digite o Segundo Número: ", "/n");
                segundonumero1 = Console.ReadLine();
                if (qualoperacao == "1")
                {
                    //verificação se o usario digitou numeros
                    if (SaoNumeros(primeironumero1, segundonumero1, out primeironumero, out segundonumero))
                    {
                        resultado = primeironumero + segundonumero;
                        historicooperacoes.Add($"Adição entre {primeironumero} + {segundonumero} = {resultado.ToString("F2")}");
                        Console.WriteLine("O seu Resultado é " + resultado.ToString("F2"), "/n");
                        Console.WriteLine("Deseja Realizar outra operação? [s/n]");
                        string outraconta;
                        outraconta = Console.ReadLine();
                        if (outraconta == "s" || outraconta == "S")
                        {
                            continuar = 7;
                        }
                        else if (outraconta == "n" || outraconta == "N")
                        {
                            Console.WriteLine("Obrigado pela presença!!");
                            continuar = 8;
                        }
                        else
                        {
                            Console.WriteLine("Comando Inválido, retornando ao menu principal");
                            continuar = 7;
                            
                        }
                    }
                    else
                    {
                        continuar = 7;
                    }
                }
                else if (qualoperacao == "2")
                {
                    
                    //verificação se o usario digitou numeros
                    if (SaoNumeros(primeironumero1, segundonumero1, out primeironumero, out segundonumero))
                    {
                        resultado = primeironumero - segundonumero;
                        historicooperacoes.Add($"Subtração entre {primeironumero} - {segundonumero} = {resultado.ToString("F2")}");
                        Console.WriteLine("O seu Resultado é " + resultado.ToString("F2"), "/n");
                        Console.WriteLine("Deseja Realizar outra operação? [s/n]");
                        string outraconta;
                        outraconta = Console.ReadLine();
                        if (outraconta == "s" || outraconta == "S")
                        {
                            continuar = 7;
                        }
                        else if (outraconta == "n" || outraconta == "N")
                        {
                            Console.WriteLine("Obrigado pela presença!!");
                            continuar = 8;
                        }
                        else
                        {
                            Console.WriteLine("Comando Inválido, retornando ao menu principal");
                            continuar = 7;
                        }
                    }
                    else
                    {
                        continuar = 7;
                    }
                }
                else if (qualoperacao == "3")
                {
                    
                    while (segundonumero1 == "0")
                    {
                        Console.WriteLine("Não é possivel dividir um numero por 0", "\n");
                        Console.WriteLine("Digite o Segundo numemro novamente", "\n");
                        segundonumero1 = Console.ReadLine();

                    }
                    //verificação se o usario digitou numeros
                    if (SaoNumeros(primeironumero1, segundonumero1, out primeironumero, out segundonumero))
                    {

                        
                        resultado = primeironumero / segundonumero;
                        historicooperacoes.Add($"Divisão entre {primeironumero} / {segundonumero} = {resultado.ToString("F2")}");
                        Console.WriteLine("O seu Resultado é " + resultado.ToString("F2"), "/n");
                        Console.WriteLine("Deseja Realizar outra operação? [s/n]");
                        string outraconta;
                        outraconta = Console.ReadLine();
                        if (outraconta == "s" || outraconta == "S")
                            continuar = 7;

                        else if (outraconta == "n" || outraconta == "N")
                        {
                            Console.WriteLine("Obrigado pela presença!!");
                            continuar = 8;
                        }
                        else
                        {
                            Console.WriteLine("Comando Inválido, retornando ao menu principal");
                            continuar = 7;
                        }
                    }
                    else
                    {
                        continuar = 7;

                    }

                }
                   
                else if (qualoperacao == "4")
                {
                    //verificação se o usario digitou numeros
                    if (SaoNumeros(primeironumero1, segundonumero1, out primeironumero, out segundonumero))
                    {



                        resultado = primeironumero * segundonumero;
                        historicooperacoes.Add($"Multiplicação entre {primeironumero} x {segundonumero} = {resultado.ToString("F2")}");
                        Console.WriteLine("O seu Resultado é " + resultado.ToString("F2"), "/n");
                        Console.WriteLine("Deseja Realizar outra operação? [s/n]");
                        string outraconta;
                        outraconta = Console.ReadLine();
                        if (outraconta == "s" || outraconta == "S")
                        {
                            continuar = 7;
                        }
                        else if (outraconta == "n" || outraconta == "N")
                        {
                            Console.WriteLine("Obrigado pela presença!!");
                            continuar = 8;
                        }
                        else
                        {
                            Console.WriteLine("Comando Inválido, retornando ao menu principal");
                            continuar = 7;
                        }
                    }
                    else
                    {
                        continuar = 7;
                    }
                }  
            } while (continuar == 7);
            
            

        }
        static bool SaoNumeros(string numero1, string numero2, out decimal num1, out decimal num2)
        {

            if (decimal.TryParse(numero1, out decimal teste1) && decimal.TryParse(numero2, out decimal teste2))
            {
                num1 = teste1;
                num2 = teste2;
                return true;

                
            } else
            {
                Console.WriteLine("Numeros Inválidos, Retornando ao Menu Principal ");
                num1 = 0;
                num2 = 0;
                return false;
                    
            }
        }
        
}
}
