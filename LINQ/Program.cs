int[] numbers = { 11,10,9,8,7,6,6,8,7,5 };

Console.WriteLine("Array original "+String.Join(" , ",numbers));

Console.WriteLine("\nQuery syntax");
var numQuery = 
from num in numbers
where num % 2 == 0
orderby num
select num;

Console.WriteLine(String.Join(" , ",numQuery));

Console.WriteLine("\nMethod Syntax");
var numMethod = numbers.Where(x => x%2 ==0).OrderBy(x => x).ToList();

Console.WriteLine(String.Join(" , ",numMethod));

var Minimo = numbers.Min();
var Maximo = numbers.Max();
var Medio = numbers.Average();
var Soma = numbers.Sum();
var ListaDistinct = numbers.Distinct().ToArray();

Console.WriteLine($"\nMinimo {Minimo}");
Console.WriteLine($"Maximo {Maximo}");
Console.WriteLine($"Medio {Medio}");
Console.WriteLine("Array com valores distintos "+String.Join(" , ",ListaDistinct));


