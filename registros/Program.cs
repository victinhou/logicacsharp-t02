using Aularegistroarquivos;

namespace Aularegistroarquivos
{ public struct Cliente
    {
        public string Nome;
        public int Idade;
        public string email;
    }
}

class Program
{
    static void Main(string[] args)
    {
        //Decl e uso basic de registros
        Cliente cliente1;
        cliente1.Nome = "João";
        cliente1.Idade = 30;
        cliente1.email = "emaildojoao@email.com";

        Console.WriteLine("====Cliente 1===");
        Console.WriteLine("Nome : " + cliente1.Nome);
        Console.WriteLine("Idade:" + cliente1.Idade);
        Console.WriteLine("email:" + cliente1.email);
        Console.WriteLine();

        //segunda gravação
        Cliente cliente2;
        cliente2.Nome = "Maria";
        cliente2.Idade = 45;
        cliente2.email = "emaildamaria@email.com";

        Console.WriteLine("====Cliente 2===");
        Console.WriteLine("Nome : " + cliente2.Nome);
        Console.WriteLine("Idade:" + cliente2.Idade);
        Console.WriteLine("email:" + cliente2.email);
        Console.WriteLine();


        //Organização de dados em tabela (vetor de registros)
        Cliente[] clientes = new Cliente[2];
        clientes[0].Nome = "João";
        clientes[0].Idade = 30;
        clientes[0].email = "emaildojoao@email.com";
        clientes[1].Nome = "Maria";
        clientes[1].Idade = 45;
        clientes[1].email = "emaildamaria@email.com";


        Console.WriteLine("=====Tabela de clientes====");
        foreach (Cliente cliente in clientes)
        {
            Console.WriteLine("Nome:" + cliente.Nome);
            Console.WriteLine("Idade:" + cliente.Idade);
            Console.WriteLine("email:" + cliente.email);
            Console.WriteLine();
        }
        // ==== Gravação de dados em arquivo ===
        Cliente cliente3;
        cliente3.Nome = "Carlos";
        cliente3.Idade = 40;
        cliente3.email = "carlos@example.com";

        string caminhoArquivo = "clientes.txt";

        using (StreamWriter sw = new StreamWriter(caminhoArquivo))
        {
            sw.WriteLine("===Cliente 3 ====");
            sw.WriteLine("Nome:" + cliente3.Nome);
            sw.WriteLine("Idade:" + cliente3.Idade);
            sw.WriteLine("Email:" + cliente3.email);
        }
        Console.WriteLine("======Gravação em Arquivo=====");
        Console.WriteLine($"Informações de {cliente3.Nome} gravadas em '{caminhoArquivo}'.");
        Console.WriteLine();

        //Leitura do arquivo gravado
        Console.WriteLine("===Conteúdo do Arquivo===");
        string conteudo = File.ReadAllText(caminhoArquivo);
        Console.WriteLine(conteudo);

        Console.WriteLine("\n===Fim da Execução===");
    }
}