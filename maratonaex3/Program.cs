/*Exercícios com array e foreach: 
1.Faça um programa de listas de peças de carro 
Crie um programa que tenha um array de nomes de 10 peças de carro e imprima 
todos os nomes em uma lista. */

//1. Programa de listas de peças de carro
string[] peçasDeCarro = new string[]
{
 "Embreagem",
"Alternador",
"Correia dentada",
"Amortecedor",
"Farol",
"Parachoque",
"Disco de freio",
"Pastilha de freio",
"Bomba de combustível",
"Filtro de óleo"
};

Console.WriteLine("Lista de peças de carro:");
foreach (string peça in peçasDeCarro)
{
    Console.WriteLine(peça);

}

/*2.Faça um programa de desconto 
Crie um programa que tenha um array associativo com dados de um gato que 
chegou no petshop, como chave e seu valor. Utilize o foreach para imprimir os 
nomes dos dados do gato.*/

//2. Programa de desconto

Dictionary<string, string> gato = new Dictionary<string, string>()
{
    {"Nome", "Bolota"},
    {"Idade", "5 anos"},
    {"Raça", "Cálica"},
    {"Cor", "Tricolor (Laranja/Branco/Preto)"},
    {"Peso", "6 kg"}
};
Console.WriteLine("\nDados do gato no petshop:");
foreach (KeyValuePair<string, string> dado in gato)
{
    Console.WriteLine($"{dado.Key}: {dado.Value}");
}



/*Exercícios com Do while: 
1.Faça um programa que pergunte se a pessoa quer continuar 
O programa pergunta se o usuário quer continuar digitando. 
Enquanto ele responder “s”, o programa repete. */

//1. Programa que pergunta se a pessoa quer continuar

string resposta;

do
{
    Console.Write("Você quer continuar digitando? (s/n): ");
    resposta = Console.ReadLine().ToLower();

} while (resposta == "s");

Console.WriteLine("Programa encerrado.");



/*2. Faça um programa de tabuada do 3 
Crie um programa em C# que mostre a tabuada do número 3 de 1 a 10. 
Use a estrutura do...while e declare a variável do contador já na mesma linha em 
que ela é criada. 
O programa deve exibir o resultado da multiplicação a cada repetição.*/

//2. Programa de tabuada do 3

int x = 1;

do
{
    Console.WriteLine($"3 x {x} = {3 * x}");
    x++;

} while (x <= 10);