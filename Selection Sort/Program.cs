int[] vetorDesordenado = {7,9,4,40,6};


int encontraIndiceMenorNumero(int inicioIndice)
{
    int indiceMenorNumero = inicioIndice;
    for (int indice = inicioIndice; indice < vetorDesordenado.Length; indice++)
    {
        if(vetorDesordenado[indice] < vetorDesordenado[indiceMenorNumero])
        {
            indiceMenorNumero = indice;
        }
    }
    return indiceMenorNumero;
}

void ordenaVetorNumerico()
{
    for(int indice = 0; indice < vetorDesordenado.Length; indice++)
    {
        int indiceMenorNumero = encontraIndiceMenorNumero(indice);
        int atualValor = vetorDesordenado[indice];
        int maiorValor = vetorDesordenado[indiceMenorNumero];

        vetorDesordenado[indice] = maiorValor;
        vetorDesordenado[indiceMenorNumero] = atualValor;
    }
}

ordenaVetorNumerico();

foreach (int indice in vetorDesordenado)
{
    Console.WriteLine(indice);
}