int [,] colecao = new int[3,2]{
    {4,76},{34,64},{23,19}
};

for(int linha =0; linha<colecao.GetLength(0);linha++){
    for(int coluna =0; coluna<colecao.GetLength(1);coluna++){
        Console.Write(colecao[linha,coluna]+" ");
    }
    Console.WriteLine();
}
