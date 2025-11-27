/*Exercícios com if, else e elseif:
1.Faça um programa para verificação de estoque
Um sistema de gerenciamento de estoque precisa notificar os funcionários
quando for hora de reabastecer um produto.
Escreva um código que verifique a quantidade de um produto em estoque. Se a
quantidade for menor que 5, exiba a mensagem: "Alerta: Baixo estoque. Por favor,
reabasteça este produto.". Caso contrário, exiba: "Estoque suficiente.".*/
int escolha, p1 = 5, p2 = 2, p3 = 12;

    Console.Write(
     "--------------------\n" +
     "Produtos em estoque:\n" +
     "1. Touca            \n" +
     "2. Camisa           \n" +
     "3. Calça Jeans      \n" +
     "Escolha: ");
escolha = Convert.ToInt32(Console.ReadLine());

switch(escolha)
{
    case 1:
        {
            if (p1 < 5)
                Console.Write("Alerta: Estoque Baixo.\nReabasteça esse produto.\n");

            else
                Console.WriteLine($"Quantidade: {p1}\nEstoque suficiente.\n");
        }
        break;
    case 2:
        {
            if(p2 < 5)
                Console.Write("Alerta: Estoque Baixo.\nReabasteça esse produto.\n");

            else
                Console.WriteLine($"Quantidade: {p2}\nEstoque suficiente.\n");
        }
        break;
    case 3:
        {
            if (p3 < 5)
                Console.Write("Alerta: Estoque Baixo.\nReabasteça esse produto.\n");
           
            else
                Console.WriteLine($"Quantidade: {p3}\nEstoque suficiente.\n");
            
        }
        break;
}


/*2. Faça um programa de desconto
Uma loja oferece um desconto para compras acima de um certo valor como parte
de uma promoção de vendas. Escreva um código que determine o valor total da
compra de um cliente. Se o valor total for superior a R$ 200,00, aplique um
desconto de 10% e exiba: "Desconto de 10% aplicado!".Se o valor total for R$
200,00 ou menos, informe: "Adicione mais itens ao carrinho para ganhar um
desconto de 10%.".*/

/*Exercícios com switch:
1.Faça um programa que determine o dia da semana
O programa deve receber um número de 1 a 7, representando um dia da semana,
e imprimir o nome do dia correspondente (por exemplo, 1 = "Domingo", 2 =
"Segunda-feira", etc.).*/

Console.WriteLine("Digite um número de 1 à 7 para visualizar o dia da semana");
int dia = Convert.ToInt32((Console.ReadLine()));

switch(dia)
{

    case 1: { Console.WriteLine("Domingo\n"); } break;
    case 2: { Console.WriteLine("Segunda-Feira\n"); } break;
    case 3: { Console.WriteLine("Terça-Feira\n"); } break;
    case 4: { Console.WriteLine("Quarta-Feira\n"); } break;
    case 5: { Console.WriteLine("Quinta-Feira\n"); } break;
    case 6: { Console.WriteLine("Sexta-Feira\n"); } break;
    case 7: { Console.WriteLine("Sábado\n"); } break;
    default: { Console.WriteLine("Valor inválido\n"); } break;
}

/*2. Faça um programa que calcule o preço final de um produto com base em um
código de desconto
O programa deve receber um código de desconto (de 1 a 3) e aplicar o desconto
correspondente ao preço do produto.
o
Código 1: 10 % de desconto
o
Código 2: 20 % de desconto
o
Código 3: 30 % de desconto
o
Se o código for inválido, deve mostrar uma mensagem de erro.*/

/*Exercícios com for:
1.Faça um programa de tabuada de multiplicação
Crie um programa que mostre na tela as tabuadas do número 7, utilizando laço de
repetição for.
O programa deve exibir, para cada número de 7, a multiplicação desse número
pelos valores de 1 a 10.*/

int i;

Console.WriteLine("TABUADA DE 7:");
for (i = 0; i <= 10; i++)
{
    Console.WriteLine($"7 x {i} = {i * 7}\n");
}

/*2. Faça um programa para calcular a média
Crie um programa que receba 10 números inteiros e calcule a média desses
números. Utilize o laço for para ler os números e calcular a média.*/

/*Exercícios com while:
1. Faça um programa contador de visitantes
Desenvolva um código que simula a entrada X visitantes aleatoriamente no
museu. A capacidade máxima é de 50 pessoas. Use um loop while para "contar"
cada visitante até que a capacidade máxima seja atingida. A cada visitante
adicional, exiba o número total de visitantes até o momento.*/

Random random = new Random();
int maxVisitantes = 50, maxValue = 50, minValue = 1, novosVisitantes = 0;

while (maxVisitantes > 0)
{
    novosVisitantes = random.Next(minValue, maxValue);
    
    while (maxVisitantes - novosVisitantes < 0){
            novosVisitantes = random.Next(minValue, maxValue);
    }


    maxVisitantes = maxVisitantes - novosVisitantes;

    Console.WriteLine($"Entraram {novosVisitantes} novos visitantes");

    if(maxVisitantes > 0) {

        Console.WriteLine($"Ainda podem entrar {maxVisitantes}\n");
        }
}
Console.WriteLine("Capacidade máxima de visitantes atingida\n");

/*2. Faça um programa de sistema de login
Um sistema de login precisa verificar a autenticidade do usuário, permitindo
múltiplas tentativas até que as credenciais corretas sejam fornecidas.
Desenvolva um código que simule um sistema de login usando um loop while. O
usuário tem um máximo de 3 tentativas para inserir a senha correta. Se a senha
correta ("senha123") for inserida, exiba "Login bem-sucedido!". Se o limite de
tentativas for atingido, mostre "Conta bloqueada por excesso de tentativas.".*/