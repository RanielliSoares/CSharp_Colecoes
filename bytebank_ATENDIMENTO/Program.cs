Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

void testaArray ()
{
    int[] idades = new int[8];
    idades[0] = 30;
    idades[1] = 40;
    idades[2] = 17;
    idades[3] = 21;
    idades[4] = 18;
    idades[5] = 78;
    idades[6] = 12;
    idades[7] = 14;

    Console.WriteLine($"Tamanho do Array {idades.Length}");

    int acumulador = 0;
    for ( int i = 0; i < idades.Length; i++)
    {
        Console.WriteLine(idades[i]);
        acumulador += idades[i];
    }
    Console.WriteLine("MAior idade dentro do array");
    Console.WriteLine(idades.Max());
    Console.WriteLine("Menor idade dentro do Array");
    Console.WriteLine(idades.Min());
    int media = acumulador/idades.Length;
    Console.WriteLine($"Acumulador{acumulador}");
    Console.WriteLine($"Média: {media}");
}
void TestaBuscarPalavra()
{
    string[] arrayDePalavras = new string[5];
    for (int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.Write($"Digite {i + 1}ª Palavra: ");
        arrayDePalavras[i] = Console.ReadLine();
    }
    Console.Write("Digite palavra a ser encontrada: ");
    var busca = Console.ReadLine();

    foreach (string palavra in arrayDePalavras)
    {
        if (palavra.Equals(busca))
        {
            Console.WriteLine($"Palavra encontrada = {busca}.");
            break;
        }
        else
        {
            Console.WriteLine($"Palavra não encontrada.");
        }
    }
}
TestaBuscarPalavra();

//testaArray();