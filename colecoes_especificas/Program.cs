using System.Collections.Generic;

Console.WriteLine("EXEMPLO DE FILA");
Queue<string> Fila = new Queue<string>();

Fila.Enqueue("Gabriel");
Fila.Enqueue("Diego");
Fila.Enqueue("Arthur");

while(Fila.Count >0){
    Console.WriteLine("Proximo a sair é {0}",Fila.Peek());
    Console.WriteLine("Retirando {0}",Fila.Dequeue());
}

Console.WriteLine("Pessoas na fila {0}",Fila.Count);


Console.WriteLine();
Console.WriteLine("EXEMPLO DE PILHA");
Stack<string> Pilha = new Stack<string>();

Pilha.Push("Duna");
Pilha.Push("Blade Runner");
Pilha.Push("1984");

while(Pilha.Count >0){
    Console.WriteLine("Proximo a sair é {0}",Pilha.Peek());
    Console.WriteLine("Retirando {0}",Pilha.Pop());
}
Console.WriteLine("Pessoas na Pilha {0}",Pilha.Count);