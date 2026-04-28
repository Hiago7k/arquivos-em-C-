using ByteBankIO;

class Program
{
    static void Main(string[] args)
    {
        var endereçoDoArquivo = "contas.txt";
        var numeroDeBytesLidos = -1; 
        var fluxoDoArquivo = new FileStream(endereçoDoArquivo, FileMode.Open);

        var buffer = new byte[1024];

        while (numeroDeBytesLidos != 0)
        {
           numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
           EscreverBuffer(buffer);
        }
    }

    static void EscreverBuffer(byte[] buffer) 
    {
        foreach (var meuByte in buffer) 
        {
            Console.Write(meuByte);
            Console.Write(" ");
        }
    }
   
}