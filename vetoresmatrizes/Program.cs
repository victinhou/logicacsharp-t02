//Declarando dois vetores
int[]numeros ={47, 6, 9, 43,5,19,15,23,8,7,49,50,51,12,53,84,56,27,58,95 }; // vetores inteiros
string[] nomes = { "Claudio", "Ramiro", "Ester", "Felipe"}; // vetores de string


Console.WriteLine("Vetor de numeros usando for:"); 
for (int i = 0; i < numeros.Length; i++)//Exibindo os elementos do vetor    
{
    Console.WriteLine(numeros[i]);
}

Console.WriteLine("\nVetor de Nomes (usando foreach):"); 
foreach (var nome in nomes) //Exibindo os Elementos do vetor de nomes com loop foreach
{
    Console.WriteLine(nome);
}

//Ordenação de vetores
/*Array.Sort(numeros);
Console.WriteLine("\nVetor de Numeros Ordenado");
foreach(var numero in numeros)  //Exibindo os Elementos do vetor de nomes com loop foreach
{
    Console.WriteLine(numero);
}
*/
int ValorProcurado = 6;
int posicaosequencial = PesquisaSequencial(numeros, ValorProcurado);

if (posicaosequencial != -1)
{
    Console.WriteLine($"\nPesquisa Sequencial : Valor {ValorProcurado} encontrado na posição {posicaosequencial}.");

}
else
{
    Console.WriteLine($"\nPesquisa Sequencial : Valor {ValorProcurado} não encontrado");
}
static int PesquisaSequencial(int[] vetor, int valor)
{
    for (int i = 0; i < vetor.Length;i++)
    {
        if(vetor[i] == valor)
            return i;   //Retorna o Índice do Valor encontrado 
    }
    return -1; // Retorna -1 se não encontrar
}
// Ordenar antes da pesquisa Binária

Array.Sort(numeros);

//Pesquisa binaria

int posicaoBinaria = Array.BinarySearch(numeros, ValorProcurado);

if (posicaoBinaria >= 0)

{

    Console.WriteLine($"Pesquisa Binária: Valor {ValorProcurado} encontrado na posição {posicaoBinaria}.");

}

else

{

    Console.WriteLine($"Pesquisa Binária: valor {ValorProcurado} não encontrado");

}

//Declaração e Manipulação de uma matriz 3x2

int[,] matriz = new int[3, 2]

{

    { 1,2 },

    { 3,4 },

    { 5,6 }

};

Console.WriteLine("\nExibindo a Matriz 3x2:");
for (int i = 0; i < 3; i++)
    {
        for(int j = 0; j<2; j++)
    Console.WriteLine(matriz [i, j]+ "\t");
}
Console.WriteLine();


//Manipulação : somando 10 a cada elemento
Console.WriteLine("\nMatriz após adcionar 10 a cada elemento:");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 2; j++)
    {
        matriz[i, j] += 10;
        Console.Write(matriz[i, j] + "\t");
    }
    Console.WriteLine();
}
