//Condicional IF

        string nome = "Ana";
if (nome == "Ana") 
{
    Console.WriteLine("O nome é Ana");
}

       string texto = "";

        if (string.IsNullOrEmpty(texto))
        {
            Console.WriteLine("A string está vázia ");
        }

        //Condiconal If/Else

        int idade = 18;

        if (idade >= 18)
        {
            Console.WriteLine("Você é maior de idade ");
        }
        else
        {
            Console.WriteLine("Você é menor de idade ");
        }

        int numero = 7;

        if (numero % 2 == 0)
        {
            Console.WriteLine("O número é par.");
        }
        else
        {
            Console.WriteLine("O número é impar");
        }

        //Condicional usando else if

        double nota = 6.5;

        if (nota >= 9.0)
        {
            Console.WriteLine("Você obteve uma Excelente nota!Aprovado com distinção.");
        }
        else if (nota >= 7.0)
        {
            Console.WriteLine("Você está aprovado");
        }

        else if (nota >= 5.0)
        {
            Console.WriteLine("Você está em recuperação.");
        }

        else if (nota >= 3.0)
        {
            Console.WriteLine("Você está em risco de reprovação.");
        }
        else 
        {
            Console.WriteLine("Você foi reprovado");
        }


    //Condicional switch
    double pontuacao = 9.5;


        //Arredondando a nota para o inteiro mais proximo
        double faixaNota = (int)Math.Round(pontuacao);

        switch (faixaNota)
        {
            case 10:
                Console.WriteLine("Você obteve uma excelente nota! Aprovado com distinção.");
                break;
            case 9:
            case 8:
                Console.WriteLine("Você está aprovado.");
                break;
            case 7:
            case 6:
                Console.WriteLine("Você está em recuperação.");
                break;
            case 5:
            case 4:
            case 3:
                Console.WriteLine("Você está com risco de reprovação");
                break;
            default:
                Console.WriteLine("Você foi Reprovado");
                break;
        }
    
