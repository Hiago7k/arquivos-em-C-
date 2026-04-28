using ByteBankIO;

class Program
{
    static void Main(string[] args)
    {
        // Salvando Caminho do arquivo, que foi salvo na pasta do exe
        var endereçoDoArquivo = "contas.txt";
        // Configurando e passando os parametros, pro FileStream 
        var fluxoDoArquivo = new FileStream(endereçoDoArquivo, FileMode.Open);
        var buffer = new byte[1024]; // 1024 pois é o tamanho 1 kb
        fluxoDoArquivo.Read(buffer, 0, 1024);
        // public override int Read(byte[] array, int offset, int count)
        Console.WriteLine("a");
        Console.ReadLine();
    }

    static void EscreverBuffer(byte[] buffer) 
    {
        foreach (var meuByte in buffer) 
        {
            Console.Write(meuByte);
            Console.Write("");
        }
    }
   
}