/*Exercícios com if, else e elseif:
1.Faça um programa para verificação de estoque
Um sistema de gerenciamento de estoque precisa notificar os funcionários
quando for hora de reabastecer um produto.
Escreva um código que verifique a quantidade de um produto em estoque. Se a
quantidade for menor que 5, exiba a mensagem: "Alerta: Baixo estoque. Por favor,
reabasteça este produto.". Caso contrário, exiba: "Estoque suficiente.".*/

Console.WriteLine("IFELSE.1- Programa de verificação de estoque:\n");

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
Console.WriteLine("IFELSE.2- Programa de desconto:\n");

Console.WriteLine("Digite o valor total da compra:"); // Solicita o valor da compra
double valorCompra = Convert.ToDouble(Console.ReadLine()); // Converte e lê o valor da compra
if (valorCompra > 200) 
{
    double valorComDesconto = valorCompra * 0.9;
    Console.WriteLine($"Desconto de 10% aplicado! Valor com desconto: R$ {valorComDesconto:F2}\n");
}
else
{
    Console.WriteLine("Adicione mais itens ao carrinho para ganhar um desconto de 10%.\n");
}




/*Exercícios com switch:
1.Faça um programa que determine o dia da semana
O programa deve receber um número de 1 a 7, representando um dia da semana,
e imprimir o nome do dia correspondente (por exemplo, 1 = "Domingo", 2 =
"Segunda-feira", etc.).*/
Console.WriteLine("SWITCH.1- Programa dia da semana:\n");

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

Console.WriteLine("SWITCH.2- Programa desconto com código:\n");

Console.WriteLine("Digite o valor do produto:");
double precoproduto = Convert.ToDouble (Console.ReadLine());
Console.WriteLine("Código de desconto:");
int codigodesc = Convert.ToInt32(Console.ReadLine());
double precodesconto;
switch (codigodesc)
{
    case 1:
        {
            precodesconto = precoproduto * 0.9; Console.WriteLine($"Preço com desconto de 10% : {precodesconto:F2}.");

        }
        break;
    case 2:
        {
            precodesconto = precoproduto * 0.8; Console.WriteLine($"Preço com desconto de 20%: {precodesconto:F2}.");

        }
        break;
    case 3:
        {
            precodesconto = precoproduto * 0.7; Console.WriteLine($"Preço com desconto de 30%: {precodesconto:F2}.");

        }
        break;
    default:
        {
            Console.WriteLine("Código inválido");
        }
        break;
}





/*Exercícios com for:
1.Faça um programa de tabuada de multiplicação
Crie um programa que mostre na tela as tabuadas do número 7, utilizando laço de
repetição for.
O programa deve exibir, para cada número de 7, a multiplicação desse número
pelos valores de 1 a 10.*/

Console.WriteLine("FOR.1- Programa de tabuada de multiplicação:\n");

int i;

Console.WriteLine("TABUADA DE 7:");
for (i = 0; i <= 10; i++)
{
    Console.WriteLine($"7 x {i} = {i * 7}\n");
}

/*2. Faça um programa para calcular a média
Crie um programa que receba 10 números inteiros e calcule a média desses
números. Utilize o laço for para ler os números e calcular a média.*/
Console.WriteLine("FOR.2 -Programa para calcular a média:\n");
int numero, soma = 0;
for (i = 1; i <= 10; i++)
{
    Console.WriteLine($"Digite o {i}º número:");
    numero = Convert.ToInt32(Console.ReadLine());
    soma += numero;
}
double media = (double)soma / 10;
Console.WriteLine($"A média dos números digitados é: {media}\n");


/*Exercícios com while:
1. Faça um programa contador de visitantes
Desenvolva um código que simula a entrada X visitantes aleatoriamente no
museu. A capacidade máxima é de 50 pessoas. Use um loop while para "contar"
cada visitante até que a capacidade máxima seja atingida. A cada visitante
adicional, exiba o número total de visitantes até o momento.*/
Console.WriteLine("WHILE.1 -Programa contador de visitantes:\n");


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
Console.WriteLine("WHILE.2 -Sistema de login:\n");

string senhaCorreta = "senha123";
int tentativas = 0;
while (tentativas < 3)
{
    Console.WriteLine("Digite sua senha:");
    string senhaUsuario = Console.ReadLine();
    if (senhaUsuario == senhaCorreta)
    {
        Console.WriteLine("Login bem-sucedido!\n");
        break;
    }
    else
    {
        tentativas++;
        Console.WriteLine("Senha incorreta.");
        if (tentativas == 3)
        {
            Console.WriteLine("Conta bloqueada por excesso de tentativas.\n");
        }
        else
        {
            Console.WriteLine($"Você tem {3 - tentativas} tentativas restantes.\n");
        }
    }
}
       








