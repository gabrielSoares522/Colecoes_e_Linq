using System;
using System.Collections.Generic;

Dictionary<string,string> Estados = new Dictionary<string, string>();

Estados.Add("SP","São paulo");
Estados.Add("MG","Mina gerais");
Estados.Add("BA","Bahia");

foreach(KeyValuePair<string,string> item in Estados)
{
    Console.WriteLine($"Chave {item.Key} valor {item.Value}");
}


try{
Estados.Add("BA","");
}catch(Exception ex){
    Console.WriteLine("\nA chave nao pode ser duplicada pois acabara usando o mesmo Hash");
}

var ChaveValorProcurado = "BA";
Console.WriteLine($"\nAcessando o valor correspondente a chave {ChaveValorProcurado}: {Estados[ChaveValorProcurado]}");

Console.WriteLine($"\nRemovendo Valor da chave {ChaveValorProcurado}");

Estados.Remove(ChaveValorProcurado);
Console.WriteLine("");

foreach(KeyValuePair<string,string> item in Estados)
{
    Console.WriteLine($"Chave {item.Key} valor {item.Value}");
}

Console.WriteLine("\nAcessando o valor de forma segura");

if(Estados.TryGetValue(ChaveValorProcurado,out string estadoEncontrado)){
    Console.WriteLine($"Valor encontrado é {estadoEncontrado}");
}else{
    Console.WriteLine("Chave não encontrada");
}