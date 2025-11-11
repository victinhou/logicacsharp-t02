/*1.Saudação com Nome 
Objetivo: Declarar variáveis, usar concatenação e interpolação. 
Descrição: Crie um script que declare uma variável para o nome de 
uma pessoa e exiba uma saudação personalizada, por exemplo:  
"Olá,João! Bem - vindo ao nosso site!". 
Dica: Utilize tanto a concatenação (.) quanto a interpolação dentro de 
uma string com aspas duplas.
*/

// Declara a variável para o nome da pessoa
string nome1 = "João";
// 1. Saudação usando CONCATENAÇÃO (+)
string saudacaoConcatenada = "Olá, " + nome1 + "! Bem-vindo ao nosso site!";
Console.WriteLine(saudacaoConcatenada);
// 2. Saudação usando INTERPOLAÇÃO ($ e {})
string saudacaoInterpolada = $"Olá, {nome1}! Bem-vindo ao nosso site!";
Console.WriteLine(saudacaoInterpolada);


/*2. Conversão de Temperatura (Celsius para Fahrenheit)
Objetivo: Trabalhar com cálculos matemáticos e variáveis. 
Descrição: Crie um script que converta uma temperatura em Celsius 
para Fahrenheit. A fórmula para conversão é:  
Dica: Declare uma constante para armazenar o valor 9/5 e faça o 
cálculo com a variável fornecida.
*/

const int fatorConversao = 9 / 5;
int celsius = 25; // Ex. de temperatura em Celsius
int fahrenheit = (celsius * fatorConversao) + 32;
Console.WriteLine($"{celsius}°C é igual a {fahrenheit}°F");

/*3. Impressão de Dados do Usuário 
Objetivo: Concatenar e interpolar dados. 
Descrição: Crie um script que solicite ao usuário seu nome, idade e 
cidade e depois mostre uma mensagem com essas informações. 
Exemplo: "Meu nome é João, tenho 25 anos e moro em São Paulo".
Dica: Use tanto concatenação quanto interpolação. 
*/

//solicitando dados usuario
Console.Write("põe teu nome aqui :");
string nome3 = Console.ReadLine();  

Console.Write("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine());

Console.Write("Digite sua cidade: ");
string cidade = Console.ReadLine();

// Usando concatenação
string mensagemConcatenada = "Meu nome é " + nome3 + ", tenho " + idade + " anos e moro em " + cidade + ".";
Console.WriteLine("\n[Concatenação]");
Console.WriteLine(mensagemConcatenada);

// Usando interpolação
string mensagemInterpolada = $"Meu nome é {nome3}, tenho {idade} anos e moro em {cidade}.";
Console.WriteLine("\n[Interpolação]");
Console.WriteLine(mensagemInterpolada);
/*4. Empréstimo Bancário
Objetivo: Cálculos financeiros e declaração de variáveis.
Descrição: Crie um script que calcule o valor de uma parcela de um
empréstimo, dado o valor total do empréstimo, a taxa de juros e o
número de parcelas. Exemplo de fórmula:
Dica: Utilize variáveis para o valor do empréstimo, a taxa de juros e o
número de parcelas.
*/

double valorEmprestimo = 10000.0; // Valor total do empréstimo  
double taxaJuros4 = 0.05; // Taxa de juros mensal (5%)
int numeroParcelas = 12; // Número de parcelas
double valorParcela = (valorEmprestimo * (1 + taxaJuros4)) / numeroParcelas;
Console.WriteLine($"O valor de cada parcela do empréstimo é: R$ {valorParcela:F2}");

/*5. Conversor de Moeda
Objetivo: Trabalhar com variáveis, operadores e arredondamento.
Descrição: Crie um script que converta uma quantia em reais para
dólares, com base em uma taxa de câmbio fornecida. Mostre o valor
convertido com 2 casas decimais.
Dica: Use round() para arredondar o valor para 2 casas decimais. 
*/

// Valores 
double reais = 100.0;        // valor em reais
double taxaCambio = 5.20;    // taxa de câmbio 

// Conversão
double dolares = reais / taxaCambio;

// Arredondamento para 2 casas decimais
double dolaresArredondado = Math.Round(dolares, 2);

// Exibe o resultado
Console.WriteLine("Valor em reais: R$ " + reais);
Console.WriteLine("Taxa de câmbio: " + taxaCambio);
Console.WriteLine("Valor em dólares: US$ " + dolaresArredondado);

/*6 . Calculadora de Desconto
Objetivo: Cálculos matemáticos e uso de variáveis.
Descrição: Crie um script que calcule o valor do desconto de um
produto, dado o preço original e a porcentagem de desconto. Exemplo
de fórmula:
Dica: Use variáveis para armazenar o preço e a porcentagem do
desconto e calcule o valor final.
*/



// Variáveis 
double precoOriginal = 200.0;       // preço do produto
double porcentagemDesconto = 15.0;  // desconto em %

// Calcula o valor do desconto
double valorDesconto = precoOriginal * (porcentagemDesconto / 100);

// Calcula o preço final
double precoFinal = precoOriginal - valorDesconto;

// Exibe os resultados
Console.WriteLine("Preço original: R$ " + precoOriginal);
Console.WriteLine("Desconto: R$ " + valorDesconto);
Console.WriteLine("Preço final com desconto: R$ " + precoFinal);

