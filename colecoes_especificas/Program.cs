using System.Collections.Generic;

Queue<string> Fila = new Queue<string>();

Fila.Enqueue("Gabriel");
Fila.Enqueue("Diego");
Fila.Enqueue("Arthur");

while(Fila.Count >0){
    Console.WriteLine("Proximo a sair é {0}",Fila.Peek());
    Console.WriteLine("Retirando {0}",Fila.Dequeue());
}

Console.WriteLine("Pessoas na fila {0}",Fila.Count);