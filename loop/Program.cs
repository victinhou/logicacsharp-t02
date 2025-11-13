//loop for
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}


int soma = 0;
for (int i = 1; i <= 100; i++)
{
    soma += i; // Soma o valor de i à variável soma, exemplo: 1+2+3+4...+99+100
}

Console.WriteLine("A soma dos números de 1 a 100 é:" );

/*loop infinito
//for (; ;)//
{
    Console.WriteLine("Este é um loop infinito");
}
*/

//While 
/* int contador = 1
 */

/*
while(contador <= 5)
{
    Console.WriteLine(contador);
    contador++; //incrementa o contador
}

//Do While
int novocontador = 2;
*/
int novocontador = 2;
do
{
    Console.WriteLine(novocontador);
    novocontador++; // Incrementa o contador
}while(novocontador <= 5);

/*Loop infinito While
while//(true)//
{
    Console.WriteLine("este é um loop inifinitooooooooooo");
}
*/

// loop foreach
//uma lista de strings
List<string> nomes = new List<string> { "Marcelo", "Sebastiana", "Armando", "Bob", "Fernando", "Elza","Geiza"};

//Usando o foreach para percorrer a lista
foreach(string nome in nomes)
{
    Console.WriteLine(nome); //imprime cada nome exibido na tela
}

//Usando foreach com lista numeral
int[] numeros = { 1, 2, 3, 4, 5 };

foreach(int numero in numeros)
{
    Console.WriteLine(numero);
}